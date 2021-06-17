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
            Console.WriteLine(R.TestLastName("Wankhade"));
            Console.WriteLine(R.TestEmail("abc+100@gmail.com"));
            Console.WriteLine(R.TestMobileNumber("91 8082494818"));
            Console.WriteLine(R.TestPassword("AVFG@456"));
        }
    }
}
