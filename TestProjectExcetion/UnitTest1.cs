using ExcetionRegexs;

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
                string result = regex.ValidateFirstName("prince.kotadiya@gmail.co.in");
            }
            catch (UserRegistrationCustomException obj)
            {
                Assert.AreEqual("Do not Null Input", obj.Message);
            }
        }
    }
}