using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;

namespace WebApplication1.login
{
    public partial class loginpage : System.Web.UI.Page
    {
        cumfun cls = new cumfun();
        SqlDataReader dr;
        String pass, emal;
        String a;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

            }

        }
        protected void lbtnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                logincls obj = new logincls();
                bool flag = false;
                bool status = false;
                flag = obj.loginchk(txtuseridname.Text.Trim(), txtpassword.Text.Trim(), RadioButton1.SelectedValue.ToString());
                status = obj.loginchkstatus(txtuseridname.Text.Trim(), txtpassword.Text.Trim(), RadioButton1.SelectedValue.ToString());
                if (status == true)
                {
                    Session["UserName"] = txtuseridname.Text;
                    if (RadioButton1.SelectedValue == "A")
                    {
                        Response.Redirect("~/Admin/userlist.aspx");
                    }
                    else
                    {
                        Response.Redirect("~/Home.aspx");
                    }


                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "popup",
                          "alert('Check your UserName Password or Group');", true);

                }
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "popup",
              "alert(" + ex + ");", true);
            }
        }
        protected void lbtnforgetpass_Click(object sender, EventArgs e)
        {

            if (txtforgrtid.Text == "")
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "popup",
                        "alert('Please Enter The User_ID.');", true);
                return;
            }
            else
            {
                a = txtforgrtid.Text;
            }
            try
            {
                dr = cls.FillDataReader("select R_password , R_EmailId from Registerlist where R_logid='" + a + "'");
                if (dr.Read())
                {
                    if (!dr.IsDBNull(0))
                    {
                        pass = dr.GetValue(0).ToString();
                    }
                    if (!dr.IsDBNull(1))
                    {
                        emal = dr.GetValue(1).ToString();
                    }
                }
                dr.Close();
                if (pass == null && emal == null)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "popup",
                        "alert('Not a valid User_ID.');", true);
                    txtforgrtid.Text = "";
                    return;
                }
                else
                {
                    bool var = MailHelper.CheckForInternetConnection();
                    if (var == true)
                    {
                        MailHelper.SendMailMessage("mydamincloud@gmail.com", emal, "Password", "Your Password:'" + pass + "'");
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "popup",
                                 "alert('Password have been sent to your registered email_ID.');", true);
                        txtforgrtid.Text = "";
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "popup",
                            "alert('Please Check Your Internet Connection.');", true);
                        txtforgrtid.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "popup",
                   "alert(" + ex + ");", true);
            }
        }
        protected void lnkUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}