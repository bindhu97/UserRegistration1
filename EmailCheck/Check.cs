using EmailCheck;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationProgram.EmailCheck
{
    public class Check
    {
        public static void Main(string[] args)
        {
            Pattern pattern = new Pattern();
            Console.WriteLine("Checking the sample email address");
            string email1 = "bin@gmail.com"; //valid
            pattern.Validation(email1);
            string email2 = "bin-100@gmail.com"; //valid
            pattern.Validation(email2);
            string email3 = "bin.100@gmail.com"; //valid
            pattern.Validation(email3);
            string email4 = "bin97@yahoo.com"; //valid
            pattern.Validation(email4);
            string email5 = "bin-100@yahoo.net"; //valid
            pattern.Validation(email5);
            string email6 = "bin.100@yahoo.com.au"; //valid
            pattern.Validation(email6);
            string email7 = "bin@1.com"; //invalid
            pattern.Validation(email7);
            string email8 = "bin@gmail.com.com"; //valid
            pattern.Validation(email8);
            string email9 = "bin+100@gmail.com"; //valid
            pattern.Validation(email9);
        }
    }
}
