using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class searchway : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["sessionuserid"] == null)
            {
                Server.Transfer("~/login/loginpage.aspx");
                Response.Redirect("~/login/loginpage.aspx");
                return;
            }

        }
        protected void Btnenhance_Click1(object sender, EventArgs e)
        {
            Session["serchtype"] = "1";
            Response.Redirect("Searchfile.aspx");
        }
        protected void btnbase_Click(object sender, EventArgs e)
        {
            Session["serchtype"] = "2";
            Response.Redirect("Searchfile.aspx");
        }
    }
}