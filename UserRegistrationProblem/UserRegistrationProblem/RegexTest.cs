using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationProblem
{
    class RegexTest
    {
        public string firstName = "^[A-Z]{1}[a-zA-z]{2,10}";
        public string lastName = "^[A-Z]{1}[a-zA-z]{2,10}";
        public string testEmail = "^[A-Za-z0-9.]{3,20}@[A-Za-z]{2,10}.(com|co.in)$";

        /// <summary>
        /// Method to test First Name
        /// </summary>
        /// <param name="fName"></param>
        /// <returns></returns>
        public bool TestFirstName(string fName)
        {
            return Regex.IsMatch(fName, firstName);
        }

        /// <summary>
        /// Method to test Last Name
        /// </summary>
        /// <param name="lName"></param>
        /// <returns></returns>
        public bool TestLastName(string lName)
        {
            return Regex.IsMatch(lName, lastName);
        }

        /// <summary>
        /// Method to test Email
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public bool TestEmail(string email)
        {
            return Regex.IsMatch(email, testEmail);
        }
    }
}
