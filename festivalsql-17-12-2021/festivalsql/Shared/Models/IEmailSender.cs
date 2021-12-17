using MimeKit;

namespace festivalsql.Shared.Models
{
    public interface IEmailSender
    {
        void SendEmail(Message message);

        MimeMessage CreateEmailMessage(Message message);

        void Send(MimeMessage mailMessage);
    }
}
