using System;

namespace IntroductionToCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the student's first name.");
            string FirstName = Console.ReadLine();

            Console.WriteLine("Please enter the student's surname.");
            string LastName = Console.ReadLine();

            Console.WriteLine("Please enter the student's GPA.");
            string GPA = Console.ReadLine();

            Console.WriteLine("Student {0} {1}, GPA {2}", FirstName, LastName, GPA);

        }
    }
}