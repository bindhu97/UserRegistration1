using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration1
{
    public class RegistrationOfUser
    {
        public void UserRegistration()
        {
            //UC1
            Regex firstName = new Regex("^[A-Z]{1}[a-z]{2,}$");
            Console.WriteLine("Enter your first Name :");
            string firstname = Console.ReadLine();
            if (firstName.IsMatch(firstname))
            {
                Console.WriteLine("Your Name is :" + firstname);
            }
            else
            {
                Console.WriteLine("Your entered name is in invalid pattern");
            }
        }
    }
}
