﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected string RenderMenu()
        {
            var result = new StringBuilder();

            RenderMenuItem("Home", "Home.aspx", result);
            RenderMenuItem("Upload", "fileway.aspx", result);
            RenderMenuItem("Search", "searchway.aspx", result);
            return result.ToString();
        }

        void RenderMenuItem(string title, string address, StringBuilder output)
        {
            output.AppendFormat("<li><a href=\"{0}\" ", address);

            var requestUrl = HttpContext.Current.Request.Url;
            if (requestUrl.Segments[requestUrl.Segments.Length - 1].Equals(address, StringComparison.OrdinalIgnoreCase)) // If the requested address is this menu item.
                output.Append("class=\"ActiveMenuButton\"");
            else
                output.Append("class=\"MenuButton\"");

            output.AppendFormat("><span>{0}</span></a></li> ", title);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("~/login/loginpage.aspx");
        }
    }
}