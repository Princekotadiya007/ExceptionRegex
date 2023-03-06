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
            NULL_FIRSTNAME,
            NULL_LASTNAME,
            NULL_EMAIL_ID,
            NULL_PHONENUMBER,
            NULL_PASSWORD,
            NULL_PASSWORDRULE2,
            NULL_PASSWORDRULE3,
            NULL_PASSWORDRULE4
        }
        public ExceptionType Type;
        public UserRegistrationCustomException(ExceptionType Type, string message) : base(message)
        {
            this.Type = Type;
        }
    }
}
