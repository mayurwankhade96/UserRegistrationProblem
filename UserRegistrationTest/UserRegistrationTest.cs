using NUnit.Framework;
using UserRegistrationProblem;

namespace UserRegistrationTest
{
    public class Tests
    {
        RegexTest regex = new RegexTest();

        /// <summary>
        /// UC10 TC to validate first name if entered correct
        /// </summary>
        [Test]
        public void GivenValidFirstNameShouldReturnTrue()
        {
            // Arrange
            bool expected = true;

            // Act
            bool result = regex.TestFirstName("Mayur");

            // Assert
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// UC10 TC to validate first name if entered incorrect
        /// </summary>
        [Test]
        public void GivenInvalidFirstNameShouldReturnFalse()
        {
            // Arrange
            bool expected = false;

            // Act
            bool result = regex.TestFirstName("mayur");

            // Assert
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// UC10 TC to validate last name if entered correct
        /// </summary>
        [Test]
        public void GivenValidLastNameShouldReturnTrue()
        {
            // Arrange
            bool expected = true;

            // Act
            bool result = regex.TestLastName("Wankhade");

            // Assert
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// UC10 TC to validate last name if entered incorrect
        /// </summary>
        [Test]
        public void GivenInvalidLastNameShouldReturnFalse()
        {
            // Arrange
            bool expected = false;

            // Act
            bool result = regex.TestLastName("wankhade");

            // Assert
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// UC10 TC to validate email
        /// </summary>
        [Test]
        public void GivenValidEmailShouldReturnTrue()
        {
            // Arrange
            bool expected = true;

            // Act
            bool result = regex.TestEmail("mayur.wankhade2@gmail.com");

            // Assert
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// UC10 TC to validate mobile number if entered correct
        /// </summary>
        [Test]
        public void GivenValidMobileNumberShouldReturnTrue()
        {
            // Arrange
            bool expected = true;

            // Act
            bool result = regex.TestMobileNumber("91 8082494818");

            // Assert
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// UC10 TC to validate mobile number if entered incorrect
        /// </summary>
        [Test]
        public void GivenInvalidMobileNumberShouldReturnFalse()
        {
            // Arrange
            bool expected = false;

            // Act
            bool result = regex.TestMobileNumber("8082494818");

            // Assert
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// UC10 TC to validate password if entered with specified conditions
        /// </summary>
        [Test]
        public void GivenValidPasswordShouldReturnTrue()
        {
            // Arrange
            bool expected = true;

            // Act
            bool result = regex.TestPassword("sfsfsA@gdff124");

            // Assert
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// UC10 TC to validate password if conditions are not followed
        /// </summary>
        [Test]
        public void GivenInvalidPasswordShouldReturnFalse()
        {
            // Arrange
            bool expected = false;

            // Act
            bool result = regex.TestPassword("sfsf@1w");

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}