using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX24
{
    class Program
    {
        static void Main(string[] args)
        {

            int GivenNumber;
            int TotalOfMultiples = 0;
            int SumOfMultiples = 0;
            int GivenNumbersAvg = 0;
            
            do
            {
                Console.WriteLine("Enter a number bigger than 0!");
                GivenNumber = int.Parse(Console.ReadLine());

                if (GivenNumber % 3 == 0)
                {
                    if (GivenNumber != 0)
                    {
                        TotalOfMultiples = TotalOfMultiples + 1;
                        SumOfMultiples = SumOfMultiples + GivenNumber;
                        Console.WriteLine("the number " + GivenNumber + " is a multiple of 3!");
                    }                  
                }
            }
            while (GivenNumber > 0);

            GivenNumbersAvg = (SumOfMultiples / TotalOfMultiples);
            Console.WriteLine("The average of numbers that are multiple of three is: " + GivenNumbersAvg);

        }
    }
}

// programa tem de aceitar varios numeros inteiros (se for zero, sai)
// apresentar a media dos numeros multiplos de 3
