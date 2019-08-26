using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX21
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

                if (NumberEntered % 6 == 0)
                {
                    break;
                }

                PowNumber = NumberEntered * NumberEntered;
                Console.WriteLine("the power of the number " + NumberEntered + " is " + PowNumber);

            } while (NumberEntered % 6 != 0);

            Console.WriteLine("Program Terminated!");
        }
    }
}
