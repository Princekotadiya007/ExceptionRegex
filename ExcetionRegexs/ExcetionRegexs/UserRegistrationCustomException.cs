using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcetionRegexs
{
    public class UserRegistrationCustomException : Exception
    {
        public enum ExceptionType
        {
            NULL_FIRSTNAME
        }
        public ExceptionType Type;
        public UserRegistrationCustomException(ExceptionType Type, string message) : base(message)
        {
            this.Type = Type;
        }
    }
}
