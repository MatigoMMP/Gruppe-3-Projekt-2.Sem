//using System;
//using System.Linq;
//using System.Collections.Generic;
//using MimeKit;

//namespace festivalsql.Client.Services
//{
//    public class Message
//    {
//        public List<MailboxAddresse> To { get; set; }
//        public string Subject { get; set; }
//        public string Content { get; set; }


//        public Message(IEnumerable<string> to, string subject, string content)
//        {
//            To = new List<MailboxAddresse>();

//            To.AddRange(to.Select(x => new MailboxAddresse(x)));
//            Subject = subject;
//            Content = content;
//        }
//    }
//}
