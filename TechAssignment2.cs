using System;

namespace Conditional_Statement
{
	class Program
	{
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Your Expected Grade...");

            string input = Console.ReadLine();


            decimal grade = decimal.Parse(input);



            if (grade >= 90 && grade <= 100)
            {
                Console.WriteLine("You receive an A");

            }

            else if (grade >= 80 && grade <= 90)
            {
                Console.WriteLine("You receive a B");
            }
            else if (grade >= 70 && grade <= 80)
            {
                Console.WriteLine("You receive a C");
            }
            else if (grade >= 60 && grade <= 70)
            {
                Console.WriteLine("You receive a D");
            }

			else if (grade <= 70)
            {
                Console.WriteLine("You receive an F");
            }
        }
    }
}
