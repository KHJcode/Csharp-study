using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study03
{
    abstract class MessageBase
    {
        protected Guid id = Guid.NewGuid();
        public string ToWhom { get; set; }
        public string Message { get; set; }

        public abstract void Send();

        protected void DebugMessageInfo()
        {
            Debug.WriteLine("Message Id: {0}", id);
            Debug.WriteLine("To: {0}", ToWhom);
            Debug.WriteLine("Message: {0}", Message);
        }
    }

    sealed class EmailMessage : MessageBase
    {
        public string Email { get; set; }

        public EmailMessage(string email)
        {
            Email = email;

        }

        public override void Send()
        {
            MailMessage msg = new MailMessage("sender@live.com", this.Email, "제목", this.Message);
            SmtpClient smtp = new SmtpClient("smtp.live.com", 587);
            smtp.EnableSsl = true;
            smtp.Credentials = new NetworkCredential("sender@live.com", "password");
            smtp.Send(msg);
        }
    }

    class SMSMessage : MessageBase
    {
        public string PhoneNumber { get; set; }

        public override void Send()
        {

        }

    }
}
