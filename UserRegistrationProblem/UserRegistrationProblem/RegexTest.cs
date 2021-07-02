using System.Text.RegularExpressions;
using System;

namespace UserRegistrationProblem
{
    public class RegexTest
    {
        private string _firstName = "^[A-Z]{1}[a-zA-z]{2,10}$";
        private string _lastName = "^[A-Z]{1}[a-zA-z]{2,10}$";
        private string _testEmail = "^[A-Za-z0-9+.-]{3,20}@[A-Za-z0-9]{1,10}.+(com|co.in|net|com.au)$";
        private string _mobileNumber = "^[9][1]\\s[6-9]{1}[0-9]{9}$";
        private string _password = "^(?=.*[A-Z])(?=.*[0-9])(?=.*[~!@#$%^&*.-])[a-zA-Z0-9].{7,}$";

        /// <summary>
        /// Method to test First Name
        /// </summary>
        /// <param name="fName"></param>
        /// <returns></returns>
        public bool TestFirstName(string fName)
        {
            if (Regex.IsMatch(fName, _firstName) == false)
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_NAME, "First letter of name must be capital");

            return Regex.IsMatch(fName, _firstName);
        }

        /// <summary>
        /// Method to test Last Name
        /// </summary>
        /// <param name="lName"></param>
        /// <returns></returns>
        public bool TestLastName(string lName)
        {
            if (Regex.IsMatch(lName, _lastName) == false)
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_NAME, "First letter of name must be capital");

            return Regex.IsMatch(lName, _lastName);
        }

        /// <summary>
        /// Method to test Email
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public bool TestEmail(string email)
        {
            if (Regex.IsMatch(email, _testEmail) == false)
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_EMAIL, "Invalid email");

            return Regex.IsMatch(email, _testEmail);
        }

        /// <summary>
        /// Method to test Mobile Number
        /// </summary>
        /// <param name="mNumber"></param>
        /// <returns></returns>
        public bool TestMobileNumber(string mNumber)
        {
            if (Regex.IsMatch(mNumber, _mobileNumber) == false)
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_MOBILE_NUMBER, "Please mention country code and put a space after that");

            return Regex.IsMatch(mNumber, _mobileNumber);
        }

        /// <summary>
        /// Method to test Password
        /// </summary>
        /// <param name="pWord"></param>
        /// <returns></returns>
        public bool TestPassword(string pWord)
        {
            if (Regex.IsMatch(pWord, _password) == false)
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_PASSWORD, "Please follow password setting rules");

            return Regex.IsMatch(pWord, _password);
        }
    }
}
