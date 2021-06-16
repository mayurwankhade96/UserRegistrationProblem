using System;

namespace UserRegistrationProblem
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome To User Registration Problem!");

            RegexTest R = new RegexTest();
            Console.WriteLine(R.TestFirstName("Mayur"));
        }
    }
}
