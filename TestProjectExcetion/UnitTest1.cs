using ExcetionRegexs;
using static ExcetionRegexs.UserRegistrationCustomException;
using System.Text.RegularExpressions;

namespace TestProjectExcetion
{
    public class Tests
    {
        // class
        RegexProblem regex = new RegexProblem(null);

        [Test]
        public void Given_Empty_FirstName_Should_Throw_UserRegistrationException()
        {
            try
            {
                string result = regex.ValidateFirstName("Prince");
            }
            catch (UserRegistrationCustomException obj)
            {
                Assert.AreEqual("Do not Null Input", obj.Message);
            }
        }
        [Test]
        public void Given_Empty_LastName_Should_Throw_UserRegistrationException()
        {
            try
            {
                string result = regex.ValidateLastName("Kotadiya");
            }
            catch (UserRegistrationCustomException obj)
            {
                Assert.AreEqual("Do not Null Input", obj.Message);
            }
        }
        [Test]
        public void Given_Empty_EMAIL_ID_Should_Throw_UserRegistrationException_Indicating_EmptyInput()
        {
            try
            {
                string result = regex.ValidateEmail("prince.kotadiya@gmail.co.in");
            }
            catch (UserRegistrationCustomException obj)
            {
                Assert.AreEqual("Do not Null Input", obj.Message);
            }
        }
        [Test]
        public void Given_Empty_PhoneNumber_Should_Throw_UserRegistrationException_Indicating_EmptyInput()
        {
            try
            {
                string result = regex.ValidatePhoneNumber(" 91 6352129268");
            }
            catch (UserRegistrationCustomException obj)
            {
                Assert.AreEqual("Do not Null Input", obj.Message);
            }
        }
        [Test]
        public void Given_Empty_Password_Should_Throw_UserRegistrationException_Indicating_EmptyInput()
        {
            try
            {
                string result = regex.ValidatePassword("Princes7");
            }
            catch (UserRegistrationCustomException obj)
            {
                Assert.AreEqual("Do not Null Input", obj.Message);
            }
        }
        [Test]
        public void Given_Empty_ValidatePassword2_Should_Throw_UserRegistrationException_Indicating_EmptyInput()
        {
            try
            {
                string result = regex.ValidatePassword2("PRINCES7");
            }
            catch (UserRegistrationCustomException obj)
            {
                Assert.AreEqual("Do not Null Input", obj.Message);
            }
        }
        [Test]
        public void Given_Empty_ValidatePassword3_Should_Throw_UserRegistrationException_Indicating_EmptyInput()
        {
            try
            {
                string result = regex.ValidatePassword3("Princes7");
            }
            catch (UserRegistrationCustomException obj)
            {
                Assert.AreEqual("Do not Null Input", obj.Message);
            }
        }
    }
}