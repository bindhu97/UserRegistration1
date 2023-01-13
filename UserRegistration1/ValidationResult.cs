using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration1
{
    public  class ValidationResult
    {
        public string UserEntry { get; set; }
        public bool Result { get; set; }
        public ValidationResult(string userEntry, bool result)
        {
            UserEntry = userEntry;
            Result = result;
        }
    }
}
