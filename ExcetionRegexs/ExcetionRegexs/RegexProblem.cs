using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static ExcetionRegexs.UserRegistrationCustomException;

namespace ExcetionRegexs
{
    public class RegexProblem
    {
        private string message;

        public RegexProblem(string message)
        {
            this.message = message;
        }

        public string ValidateFirstName(string name)
        {
            string firstName = "^[A-Z][a-z]{3,}?";
            try
            {
                if (Regex.IsMatch(name, firstName))
                {

                    Console.WriteLine("Valid");
                }
                else
                {
                    Console.WriteLine("Invalid");
                }
                return name;
            }
            catch (NullReferenceException)
            {
                throw new UserRegistrationCustomException(ExceptionType.NULL_FIRSTNAME, " Do not Null Input");
            }

        }
        public string ValidateLastName(string name)
        {
            string lastName = "^[A-Z][a-z]{3,}?";
            try
            {
                if (Regex.IsMatch(name, lastName))
                {
                    Console.WriteLine("Valid");
                }
                else
                {
                    Console.WriteLine("Invalid");
                }
                return name;
            }
            catch (NullReferenceException)
            {
                throw new UserRegistrationCustomException(ExceptionType.NULL_LASTNAME, "Please do not Enter the Null Input");
            }
        }
    }
}
