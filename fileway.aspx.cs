using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class fileway : System.Web.UI.Page
    {
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



            }
        }

        protected void btnbase_Click(object sender, EventArgs e)
        {
            Response.Redirect("uploadbase.aspx");
        }

        protected void Btnenhance_Click1(object sender, EventArgs e)
        {
            Response.Redirect("uploadadvnce.aspx");
        }
    }
}