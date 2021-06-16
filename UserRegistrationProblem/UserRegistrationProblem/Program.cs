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
        }
    }
}
