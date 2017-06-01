using System;
using System.Net.Mail;

namespace Member
{
    public partial class Contact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Uploademailmessg(object sender, EventArgs e)
        {

            MailMessage sms = new MailMessage();
            sms.From = new MailAddress("alex610assignment2@gmail.com");
            sms.To.Add("alex610assignment2@gmail.com");
            sms.CC.Add(new MailAddress(SmsTextBox.Text));
            sms.Subject = thesubjectbox.Text;

            sms.Body = "Name:" + thenamebox.Text + " " + "Email: " + SmsTextBox.Text + " " + "Message: " + information.Text;
            sms.IsBodyHtml = true;

            SmtpClient client = new SmtpClient();
            client.Host = "smtp.gmail.com";
            System.Net.NetworkCredential credential = new System.Net.NetworkCredential();
            credential.UserName = "alex610assignment2@gmail.com";
            credential.Password = "789632145Aa";

            client.UseDefaultCredentials = true;
            client.Credentials = credential;
            client.Port = 587;

            client.EnableSsl = true;
            client.Send(sms);
            lblMsg.Text = "Thank you for the SmsTextBox, will get back to you.";



        }
    }
}