using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing
{
    class Program
    {
        static void Main(string[] args)
        {
            IndieGoat.SMTP.SMTPEmailSender.SendEmail("officialvortexstudio@gmail.com", "braydelritter@gmail.com", "testing tets", "test");
            Console.WriteLine("Done");
            Console.Read();
        }
    }
}
