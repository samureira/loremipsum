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
            int Count = 0;

            do
            {
                Console.WriteLine("Give a number: ");
                GivenNumber = int.Parse(Console.ReadLine());

                //if (GivenNumber <= 1)
                //{
                //    Console.WriteLine(GivenNumber + " is not a prime!");
                //}

                for (var i = 1; i <= GivenNumber; i++)
                {
                    if (GivenNumber % i == 0)
                    {
                        Count = Count + 1;
                    }
                }

                if (Count == 2)
                {
                    Console.WriteLine(GivenNumber + " is a prime number!");
                    NumbersQuantity = NumbersQuantity + 1;
                }
                else
                {
                    Console.WriteLine(GivenNumber + " is not a prime number!");
                }

            } while (GivenNumber > 0);

            Console.WriteLine(NumbersQuantity + " prime numbers were entered!");
        }
    }
}
