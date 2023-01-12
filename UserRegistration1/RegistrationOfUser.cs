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
            //UC2
            Regex LastName = new Regex("^[A-Z]{1}[a-z]{2,}$");
            Console.WriteLine("Enter your Last Name:");
            string lastname = Console.ReadLine();
            if (LastName.IsMatch(lastname))
            {
                Console.WriteLine("Your last Name is: " + lastname);
            }
            else
            {
                Console.WriteLine("Your entered last name is in invalid pattern");
            }
        }
    }
}
