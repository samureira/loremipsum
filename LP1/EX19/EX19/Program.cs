using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX19
{
    class Program
    {
        static void Main(string[] args)
        {

            int numbersAbove100And200 = 0;
            int number;

            do
            {
                Console.WriteLine("enter a number: ");
                number = int.Parse(Console.ReadLine());
                Console.WriteLine("you entered the number " + number);

                if (number > 100 && number < 200)
                {
                    numbersAbove100And200 = numbersAbove100And200 + 1;
                }
                else
                {
                    numbersAbove100And200 = numbersAbove100And200;
                }

            } while (number != 0);

            Console.WriteLine(number + " was entered, the program gets terminated!");
            Console.WriteLine("you entered " + numbersAbove100And200 + " times a number between 100 and 200");

        }
    }
}
