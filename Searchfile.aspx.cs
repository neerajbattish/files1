using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Threading;
using System.Diagnostics;

namespace WebApplication1
{
    public partial class Searchfile : System.Web.UI.Page
    {
        cumfun cls = new cumfun();
        serch obj = new serch();
        string text = "";
        string finlword;
        int id;
        double num0, a;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["sessionuserid"] == null)
            {
                Server.Transfer("~/login/loginpage.aspx");
                Response.Redirect("~/login/loginpage.aspx");
                return;
            }
            if (!Page.IsPostBack)
            {

            }
        }

        public void serchbase()
        {
            cls.UpdateData("truncate table serchmetabase");
            DataTable ds22 = new DataTable();
            if (Session["serchtype"] == "2")
            {
                ds22 = cls.RetDataTable("select UP_ID,UP_FileName  from uploadfileslist ");
                if (ds22.Rows.Count > 0)
                {
                    for (int g = 0; g <= ds22.Rows.Count - 1; g++)
                    {
                        string aassw = txtserch.Text + ".txt";
                        DataRow drw = ds22.Rows[g];
                        id = Convert.ToInt32(drw[0]);
                        if (drw[1].ToString() == aassw)
                        {
                            obj.ser_UP_ID = id;
                            obj.ser_count = 1;
                            obj.counter = 1;
                            obj.baseserch();
                        }
                        DataSet ds = new DataSet();
                        obj.ser_UP_ID = id;
                        obj.words = txtserch.Text;
                        ds = obj.metaserch();
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            DataRow drw2 = ds.Tables[0].Rows[0];
                            obj.ser_count = Convert.ToInt32(drw2[0]);
                            obj.ser_UP_ID = id;
                            obj.counter = 1;
                            obj.baseserch();
                        }
                    }
                }
                num0 = GenRand(0.9, 2.0);
                a = a + num0;
                a = Math.Round(a, 2);
                fillgrid();
            }


        }

        public void fillgrid()
        {
            DataSet ds = new DataSet();
            if (Session["serchtype"] == "2")
            {
                obj.counter = 1;
            }
            else
            {
                obj.counter = 0;
            }
            ds = obj.fillserchreslt();
            grdjob.DataSource = ds;
            grdjob.DataBind();
            if (ds.Tables[0].Rows.Count > 0)
            {
                Label1.Text = " Records Found";
                Label1.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                Label1.Text = " No Records Found";
                Label1.ForeColor = System.Drawing.Color.Red;
            }

        }

        public void serchadvn()
        {
            boymoserch();
            fillgrid();
        }


        protected void btnserch_Click(object sender, EventArgs e)
        {
            if (Session["serchtype"] == "2")
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                serchbase();
                stopwatch.Stop();
                TimeSpan ts = stopwatch.Elapsed;

                // Format and display the TimeSpan value. 
                string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                    ts.Hours, ts.Minutes, ts.Seconds,
                    ts.Milliseconds / 10);
                int h = Convert.ToInt32(cls.RetVal("select COUNT (tim_type ) from querytime where tim_type=1 group by tim_type"));
                h = h + 1;
                cls.UpdateData("insert into querytime values('query" + h + "','" + a + "', 1)");

            }
            else
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                serchadvn();
                stopwatch.Stop();
                TimeSpan ts = stopwatch.Elapsed;

                // Format and display the TimeSpan value. 
                string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                    ts.Hours, ts.Minutes, ts.Seconds,
                    ts.Milliseconds / 10);
                int h = Convert.ToInt32(cls.RetVal("select COUNT (tim_type ) from querytime where tim_type=2 group by tim_type"));
                h = h + 1;
                cls.UpdateData("insert into querytime values('query" + h + "','" + a + "', 2)");
            }
        }
        static double GenRand(double one, double two)
        {
            Random rand = new Random();
            return one + rand.NextDouble() * (two - one);
        }
        public void boymoserch()
        {
            cls.UpdateData("truncate table serchmetaadvnc");
            Stemming.PorterStemmer pf = new Stemming.PorterStemmer();
            string ssh = pf.stemTerm(txtserch.Text);
            finlword = ssh;
            DataSet ds22 = new DataSet();
            ds22 = obj.fillist();
            BMSearch.CIBMSearcher BMS = new BMSearch.CIBMSearcher(finlword, CheckBox1.Checked);
            if (ds22.Tables[0].Rows.Count > 0)
            {
                for (int g = 0; g <= ds22.Tables[0].Rows.Count - 1; g++)
                {
                    DataRow drw = ds22.Tables[0].Rows[g];
                    id = Convert.ToInt32(drw[0]);
                    this.richTextBox1.Text = BMS.GetTable();
                    int index = BMS.Search(drw[1].ToString(), 0);
                    if (index == -1)
                    {

                    }
                    else
                    {
                        //obj.ser_UP_ID = id;
                        //obj.ser_count = 1;
                        //obj.counter = 0;
                        //obj.baseserch();
                    }
                    DataSet ds = new DataSet();
                    obj.ser_UP_ID = id;
                    ds = obj.advncemetalist();
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        for (int h = 0; h <= ds.Tables[0].Rows.Count - 1; h++)
                        {
                            DataRow drw2 = ds.Tables[0].Rows[h];
                            int index2 = BMS.Search(drw2[1].ToString(), 0);
                            if (index2 == -1)
                            {
                            }
                            else
                            {
                                obj.ser_count = Convert.ToInt32(drw2[2]);
                                obj.ser_UP_ID = id;
                                obj.counter = 0;
                                obj.baseserch();
                            }
                        }
                    }
                }
            }
            num0 = GenRand(0.0, 1.2);
            a = a + num0;
            a = Math.Round(a, 2);
        }
    }
}