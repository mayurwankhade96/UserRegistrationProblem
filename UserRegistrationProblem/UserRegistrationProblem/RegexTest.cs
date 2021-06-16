using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationProblem
{
    class RegexTest
    {
        public string firstName = "^[A-Z]{1}[a-zA-z]{2,10}";

        public bool TestFirstName(string fName)
        {
            return Regex.IsMatch(fName, firstName);
        }
    }
}
