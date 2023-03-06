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
                Assert.AreEqual("Please do not Enter the Null Input", obj.Message);
            }
        }
        [Test]
        public void Given_Empty_LastName_Should_Throw_UserRegistrationException()
        {
            try
            {
                string result = regex.ValidateFirstName("Kotadiya");
            }
            catch (UserRegistrationCustomException obj)
            {
                Assert.AreEqual("Please do not Enter the Null Input", obj.Message);
            }
        }
    }
}