using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;


/// <summary>
/// Summary description for MailHelper
/// </summary>
public class MailHelper
{
    public static void SendMailMessage(string from, string to, string subject, string body)
    {
        try
        {

            System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();
            msg.From = new MailAddress(from);  //from adress
            msg.To.Add(to);//Text Box for To Address
            msg.Subject = subject; //Text Box for subject
            msg.Body = body; // body
            msg.IsBodyHtml = true;
            msg.Priority = MailPriority.High;
            System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient("smtp.gmail.com", 25);
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential("sttuuddy@gmail.com", "123456789admin");
            client.Port = 25;
            // client.Host = "smtp.gmail.com";
            client.EnableSsl = true;
            object userstate = msg;
            client.Send(msg);
            
        }
        catch (Exception ex)
        {
            
        }

    }

    public static bool CheckForInternetConnection()
    {
        try
        {
            using (var client = new WebClient())
            using (var stream = client.OpenRead("http://www.google.com"))
            {
                return true;
            }
        }
        catch
        {
            return false;
        }
    }
}