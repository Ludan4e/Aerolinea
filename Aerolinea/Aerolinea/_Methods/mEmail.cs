using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace Aerolinea
{
    class mEmail
    {
        public void SendMail(string mTo, string mBody, string mAttachment)
        {
            string mFrom = "avisoftware@hotmail.com";
            string mFromPass = "tecnologico2015";
            MailMessage m = new MailMessage(mFrom, mTo, "Aerolínea AVI Soft", mBody);
            if (mAttachment != "")
            {
                m.Attachments.Add(new Attachment(mAttachment));
            }
            SmtpClient c = new SmtpClient("smtp.live.com", 587);
            c.Credentials = new NetworkCredential(mFrom, mFromPass);
            c.EnableSsl = true;
            try
            {
                c.Send(m);
                MessageBox.Show("exito.");
            }
            catch (SmtpException e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
