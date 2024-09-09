using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;
using System.Net;
public class log
{

    public string EmailID { get; set; }

    public static bool SendOTP(string EmailID)
    {
        String To, From, Password, Mail;
        To = EmailID;
        From = "19bmiit053@gmail.com";
        Password = "prasiddh0000";

        MailMessage msg = new MailMessage();
        msg.From = new MailAddress(From);
        msg.To.Add(To);
        msg.Subject = "MOLLA";
        msg.Body = "<h2>please chechout your cart and enjoy it. <h2>";
        msg.IsBodyHtml = true;

        SmtpClient smtp = new SmtpClient("smtp.gmail.com");
        smtp.EnableSsl = true;
        smtp.Port = 587;
        smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
        smtp.Credentials = new NetworkCredential(From, Password);

        try
        {
            smtp.Send(msg);
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }
}