using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration1
{
    public class UserCustomException : Exception
    {
        public enum ExceptionType
        {
            NULL_INPUT,
            EMPTY_INPUT
        }
        public ExceptionType type;
        public UserCustomException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
