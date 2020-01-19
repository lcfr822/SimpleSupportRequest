using System;
using System.Net.Mail;
using System.Windows.Forms;

namespace SamsSimpleSupportRequest.Utilties
{
    /// <summary>
    /// Common Email functions.
    /// </summary>
    public static class EmailUtility
    {
        private const string USERNAME = "sss.requestservice@gmail.com";
        private const string PWORD = "77?Vpxz#SmhB%74A";

        /// <summary>
        /// 
        /// </summary>
        /// <param name="senderEmail"></param>
        /// <param name="senderName"></param>
        /// <param name="problem"></param>
        public static void SendRequest(string senderEmail, string senderName, string problem)
        {
            System.Diagnostics.Debug.WriteLine(senderEmail + " - " + senderName + " - " + problem);
            try
            {
                SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");
                smtpServer.UseDefaultCredentials = false;
                smtpServer.Port = 587;
                smtpServer.Credentials = new System.Net.NetworkCredential(USERNAME.Trim(), PWORD.Trim());
                smtpServer.EnableSsl = true;
                smtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpServer.Timeout = 20000;
                
                MailMessage requestMessage = new MailMessage();
                requestMessage.From = new MailAddress(USERNAME);
                requestMessage.To.Add(new MailAddress(USERNAME));
                requestMessage.CC.Add(new MailAddress(senderEmail));
                requestMessage.Subject = "Support Request from " + senderName + ", " + senderEmail;
                requestMessage.Body = problem;

                smtpServer.Send(requestMessage);
                MessageBox.Show("Support request successfully sent!", "Request Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Something went wrong sending your support request. Please call the support number you were given.", "Error Sending Request", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Diagnostics.Debug.WriteLine(ex.Message.ToString());
            }
        }
    }
}
