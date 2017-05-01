using System;
using System.Net.Mail;

public partial class Pages_ContactUs : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void sendmessagebtn(object sender, EventArgs e)
    {



        

        MailMessage sms = new MailMessage();
        sms.From = new MailAddress("alex610assignment2@gmail.com");
        sms.To.Add("alex610assignment2@gmail.com");
        sms.CC.Add(new MailAddress(theboxname.Text));
        sms.Subject = thesubjectbox.Text;
        
        sms.Body = "Email: " + theboxname.Text + "Message: " + mailbody.Text;
        sms.IsBodyHtml = true;

        SmtpClient clientsmtp = new SmtpClient();
        clientsmtp.Host = "smtp.gmail.com";
        System.Net.NetworkCredential mailcredentials = new System.Net.NetworkCredential();
        mailcredentials.UserName = "alex610assignment2@gmail.com";
        mailcredentials.Password = "789632145Aa";
        clientsmtp.UseDefaultCredentials = true;
        clientsmtp.Credentials = mailcredentials;
        clientsmtp.Port = 587;
        clientsmtp.EnableSsl = true;
        clientsmtp.Send(sms);
        lblMsg.Text = "Email has been sent successfully.";



    }
}
