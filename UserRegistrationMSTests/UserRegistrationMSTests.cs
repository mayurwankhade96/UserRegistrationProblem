using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UserRegistrationProblem.UserRegistrationMSTests
{
    [TestClass]
    public class UserRegistrationMSTests
    {
        RegexTest regex = new RegexTest();

        /// <summary>
        /// UC12 throw custom exception in case of invalid first name
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(UserRegistrationException))]
        public void TestFirstName_EnteredInvalid_ThrowsUserRegistrationException()
        {
            // Act
            try
            {
                regex.TestFirstName("mayur");
            }
            catch(UserRegistrationException ex)
            {
                Assert.AreEqual("First letter of name must be capital", ex.Message);
                throw;
            }
        }

        /// <summary>
        /// UC12 throw custom exception in case of invalid last name
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(UserRegistrationException))]
        public void TestLastName_EnteredInvalid_ThrowsUserRegistrationException()
        {
            // Act
            try
            {
                regex.TestLastName("wankhade");
            }
            catch (UserRegistrationException ex)
            {
                Assert.AreEqual("First letter of name must be capital", ex.Message);
                throw;
            }
        }

        /// <summary>
        /// UC12 throw custom exception in case of invalid email
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(UserRegistrationException))]
        public void TestEmail_EnteredInvalid_ThrowsUserRegistrationException()
        {
            // Act
            try
            {
                regex.TestEmail("_mayur.wankhade2@gmail.com");
            }
            catch (UserRegistrationException ex)
            {
                Assert.AreEqual("Invalid email", ex.Message);
                throw;
            }
        }

        /// <summary>
        /// UC12 throw custom exception in case of invalid mobile number
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(UserRegistrationException))]
        public void TestMobileNumber_EnteredInvalid_ThrowsUserRegistrationException()
        {
            // Act
            try
            {
                regex.TestMobileNumber("8082494818");
            }
            catch (UserRegistrationException ex)
            {
                Assert.AreEqual("Please mention country code and put a space after that", ex.Message);
                throw;
            }
        }

        /// <summary>
        /// UC12 throw custom exception in case of invalid password
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(UserRegistrationException))]
        public void TestPassword_EnteredInvalid_ThrowsUserRegistrationException()
        {
            // Act
            try
            {
                regex.TestPassword("Acbv@1a");
            }
            catch (UserRegistrationException ex)
            {
                Assert.AreEqual("Please follow password setting rules", ex.Message);
                throw;
            }
        }
    }
}
