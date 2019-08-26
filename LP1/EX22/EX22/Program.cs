using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX22
{
    class Program
    {
        static void Main(string[] args)
        {

            int GivenNumber;
            int NumbersQuantity = 0;
            //int FlagVar = 0;

            do
            {
                Console.WriteLine("Give a number: ");
                GivenNumber = int.Parse(Console.ReadLine());

                if (GivenNumber <= 1)
                {
                    Console.WriteLine(GivenNumber + "is not a prime!");
                }

                for (var i = 2; i <= GivenNumber/2; i++)
                {
                    if (GivenNumber % i == 0)
                    {
                        Console.WriteLine(GivenNumber + "is not a prime number!");
                    }
                    else
                    {
                        Console.WriteLine(GivenNumber + " it is a prime number!");
                        NumbersQuantity = NumbersQuantity + 1;
                    }
                }

            } while (GivenNumber > 0);

            Console.WriteLine(NumbersQuantity + " numbers were entered!");
        }
    }
}
