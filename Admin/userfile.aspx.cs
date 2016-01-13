using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace WebApplication1.Admin
{
    public partial class userfile : System.Web.UI.Page
    {
        cumfun cls = new cumfun();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["sessionuserid"] == null)
            {
                Server.Transfer("~/login/loginpage.aspx");
                Response.Redirect("~/login/loginpage.aspx");
                return;
            }
            if (!IsPostBack)
            {
                Literal1.Text = HttpUtility.UrlDecode(Request.QueryString["R_Id"]);
                fillgrid();
                fillgrid1();
            }

        }

        protected void fillgrid()
        {
            string str = "select up_filename,UP_Discription from uploadfileslist where UP_r_id='" + Literal1.Text + "' ";
            DataSet ds = cls.RetDataset(str);
            GridView1.DataSource = ds;
            GridView1.DataBind();

        }
        protected void fillgrid1()
        {
            string str = "select up_filename,UP_Discription from advncuploadfileslist where UP_r_id ='" + Literal1.Text + "'";
            DataSet ds = cls.RetDataset(str);
            GridView2.DataSource = ds;
            GridView2.DataBind();

        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            fillgrid();
        }

        protected void GridView2_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView2.PageIndex = e.NewPageIndex;
            fillgrid1();
        }
    }
}