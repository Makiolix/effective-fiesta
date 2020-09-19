using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter a number");

            int UserNumber = int.Parse(Console.ReadLine());

            if (UserNumber == 1)
            {
                Console.WriteLine("Your number is one");
            }

            if (UserNumber == 2)
            {
                Console.WriteLine("Your number is two");
            }

            if (UserNumber == 3)
            {
                Console.WriteLine("Your number is three");
            }

            else
            {
                Console.WriteLine("Your number is not between 1 and 3");
            }

        }
    }
}