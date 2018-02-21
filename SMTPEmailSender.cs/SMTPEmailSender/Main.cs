using QiHe.CodeLib.Net;
using System;
using System.Threading;

namespace IndieGoat.SMTP
{
    public static class SMTPEmailSender
    {
        public static void SendEmail(string from, string to, string subject, string body)
        {
            bool Result = EmailSender.Send(from, to, subject, body);
            if (Result) Console.WriteLine("Sent mail!");
            if (!Result) Console.WriteLine("Sent mail failed!");
        }
        public static void SendEmailAsync(string from, string to, string subject, string body)
        {
            new Thread(new ThreadStart(() =>
            {
                bool Result = EmailSender.Send(from, to, subject, body);
                if (Result) Console.WriteLine("Sent mail!");
                if (!Result) Console.WriteLine("Sent mail failed!");
            })).Start();
        }
    }
}
