using System;

namespace UserRegistrationProblem
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome To User Registration Problem!");

            // Creating object
            RegexTest R = new RegexTest();

            Console.WriteLine(R.TestFirstName("Mayur"));
            Console.WriteLine(R.TestLastName("Wankgade"));
            Console.WriteLine(R.TestEmail("abc.xyz@bl.co.in"));
            Console.WriteLine(R.TestMobileNumber("91 8082494818"));
            Console.WriteLine(R.TestPassword("abdgf657848"));
        }
    }
}
