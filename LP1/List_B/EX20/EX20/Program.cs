using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX20
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumberEntered;
            int PowNumber;

            do
            {
                Console.WriteLine("Enter a number: ");
                NumberEntered = int.Parse(Console.ReadLine());
                PowNumber = NumberEntered * NumberEntered;
                Console.WriteLine("the power of the number " + NumberEntered + " is " + PowNumber);

            } while (NumberEntered % 6 != 0);

            //Console.WriteLine("Enter a number: ");
            //int NumberEntered = int.Parse(Console.ReadLine());
            //int PowNumber;

            //while (NumberEntered % 6 != 0)
            //{
            //    Console.WriteLine("Enter a number: ");
            //    NumberEntered = int.Parse(Console.ReadLine());
            //    PowNumber = NumberEntered * NumberEntered;
            //    Console.WriteLine("the power of the number "+ NumberEntered + " is "+ PowNumber);
            //}

            Console.WriteLine("You entered a multiple of 6 with the number " + NumberEntered);
            Console.WriteLine("Program Terminated!");
        }
    }
}
