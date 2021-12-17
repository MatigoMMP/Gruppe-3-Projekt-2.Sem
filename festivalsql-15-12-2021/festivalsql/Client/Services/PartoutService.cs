using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using festivalsql.Shared.Models;
using MailKit.Net.Smtp;
using MimeKit;
using Microsoft.EntityFrameworkCore;



namespace festivalsql.Client.Services
{
    public class PartoutService : IEmailSender
    {
        private readonly EmailConfiguration _emailConfig;

        private readonly FestivalContext _partout = new ();


        public PartoutService(EmailConfiguration emailConfig)
        {
            _emailConfig = emailConfig;
        }

        public PartoutService()
        {

        }
        
        public IEnumerable<Partout> GetAllPartout()
        {
            try
            {
                return _partout.partout.ToList();
            }
            catch { throw; }
        }

        public void AddPartout(Partout partout)
        {
            try
            {
                _partout.partout.Add(partout);
                _partout.SaveChanges();
            }
            catch { throw; }
        }

        public void UpdatePartout(Partout partout)
        {
            try
            {
                _partout.Entry(partout).State = EntityState.Modified;
                _partout.SaveChanges();
            }
            catch { throw; }
        }

        public Partout GetPartoutData(int id)
        {
            try
            {
                return _partout.partout.First(partout => partout.partout_id == id);
            }
            catch { throw; }
        }

        public void DeletePartout(int id)
        {
            try
            {
                var entity = _partout.partout.First(partout => partout.partout_id == id);
                _partout.partout.Remove(entity);
                _partout.SaveChanges();
            }
            catch { throw; }
        }


        public void SendEmail(Message message)
        {
            var emailMessage = CreateEmailMessage(message);

            send(emailMessage);
        }

        private MimeMessage CreateEmailMessage(Message message)
        {
            var emailMessage = new MimeMessage();
            emailMessage.From.Add(new MailboxAddress(_emailConfig.From));
            emailMessage.To.AddRange(message.To);
            emailMessage.Subject = message.Subject;
            emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Text) { Text = message.Content };

            return emailMessage;

        }

        private void send(MimeMessage mailMessage)
        {
            using (var client = new SmtpClient())
            {
                try
                {
                    client.Connect(_emailConfig.SmtpServer, _emailConfig.Port, true);
                    client.AuthenticationMechanisms.Remove("XOAUTH2");
                    client.Authenticate(_emailConfig.UserName, _emailConfig.Password);

                    client.Send(mailMessage);
                }
                catch
                {
                    throw;
                }
                finally
                {
                    client.Disconnect(true);
                    client.Dispose();
                }
            }
        }
    }
}
