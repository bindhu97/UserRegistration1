using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration1
{
    public class CustomException
    {
        public static string firstName = "^[A-Z][a-zA-Z]{2,}$";
        public static string LastName = "^[A-Z][a-zA-Z]{2,}$";
        public static string EmailId = "^[a-zA-Z0-9]+([-.+_#$][a-zA-Z0-9]+)*[@][a-zA-Z0-9]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2})?$";
        public static string MobileNo = "^[1-9][0-9]\\s[1-9]{1}[0-9]{9}$";
        public static string PASSWORD4 = "((?=.*[A-Z])(?=.*[0-9])(?=^[a-zA-Z0-9]*[@$#^!-+][a-zA-Z0-9]*$)).{8,}";
        public bool validateFirstName(string fName)
        {
            try
            {
                if (firstName.Equals(string.Empty))
                {
                    throw new UserCustomException(UserCustomException.ExceptionType.EMPTY_INPUT, "First Name should not be empty");
                }
                return Regex.IsMatch(fName, firstName);
            }
            catch (NullReferenceException)
            {
                throw new UserCustomException(UserCustomException.ExceptionType.NULL_INPUT, "First Name should not be null");
            }
        }
        public bool validateLastName(string lName)
        {
            try
            {
                if (lName.Equals(string.Empty))
                {
                    throw new UserCustomException(UserCustomException.ExceptionType.EMPTY_INPUT, "Last Name should not be empty");
                }
                return Regex.IsMatch(lName, LastName);
            }
            catch (NullReferenceException)
            {
                throw new UserCustomException(UserCustomException.ExceptionType.NULL_INPUT, "Last Name should not be null");
            }
        }
        public bool validateEmail(string email)
        {
            try
            {
                if (email.Equals(string.Empty))
                {
                    throw new UserCustomException(UserCustomException.ExceptionType.EMPTY_INPUT, "Email should not be empty");
                }
                return Regex.IsMatch(email, EmailId);
            }
            catch (NullReferenceException)
            {
                throw new UserCustomException(UserCustomException.ExceptionType.NULL_INPUT, "Email should not be null");
            }
        }
        public bool validateNumber(string number)
        {
            try
            {
                if (number.Equals(string.Empty))
                {
                    throw new UserCustomException(UserCustomException.ExceptionType.EMPTY_INPUT, "Mobile Number should not be empty");
                }
                return Regex.IsMatch(number, MobileNo);
            }
            catch (NullReferenceException)
            {
                throw new UserCustomException(UserCustomException.ExceptionType.NULL_INPUT, "Mobile Number should not be null");
            }
        }
        public bool validatePassword(string password)
        {
            try
            {
                if (password.Equals(string.Empty))
                {
                    throw new UserCustomException(UserCustomException.ExceptionType.EMPTY_INPUT, "Password should not be empty");
                }
                return Regex.IsMatch(password, PASSWORD4);
            }
            catch (NullReferenceException)
            {
                throw new UserCustomException(UserCustomException.ExceptionType.NULL_INPUT, "Password should not be null");
            }
        }
    }
}
