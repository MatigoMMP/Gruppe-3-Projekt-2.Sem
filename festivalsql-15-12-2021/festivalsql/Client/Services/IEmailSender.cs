using System;
namespace festivalsql.Client.Services
{
    public interface IEmailSender
    {
        void SendEmail(Message message);
    }
}
