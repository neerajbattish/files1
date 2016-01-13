using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.login
{
    public partial class Register : System.Web.UI.Page
    {
        cumfun cls = new cumfun();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

            }
        }
        public void clearall()
        {
            txtemail.Text = "";
            txtpassword.Text = "";
            txtrepasswrd.Text = "";
            txtuseridname.Text = "";
            txtusername.Text = "";


        }
        protected void txtuseridname_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (cls.IsExists("select * from Registerlist where R_logid='" + txtuseridname.Text + "' ") == true)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "popup",
                    "alert('UserId Already exist');", true);
                    txtuseridname.Text = "";
                }

            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "popup",
                   "alert(" + ex + ");", true);
            }
        }
        protected void lbsignup_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckBox1.Checked == false)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "popup",
                        "alert('Please Select the Checkbox.');", true);
                    return;
                }
                else
                {

                    register rg = new register();
                    rg.R_FName = txtusername.Text;
                    //rg.R_gender = rbtngender.SelectedValue; ;
                    rg.R_emailid = txtemail.Text;
                    rg.R_logid = txtuseridname.Text;
                    rg.R_password = txtpassword.Text;
                    rg.insertuser();

                    ScriptManager.RegisterStartupScript(this, this.GetType(), "popup",
                "alert('You have successful register.Please LogIn');", true);
                    Response.Redirect("~/login/loginpage.aspx");
                    clearall();
                }
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "popup",
                   "alert('" + ex + "');", true);
            }

        }
    }
}