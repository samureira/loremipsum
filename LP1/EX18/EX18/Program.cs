using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX18
{
    class Program
    {
        static void Main(string[] args)
        {
            int iTotalOfNumbers = 0;

            Console.WriteLine("Enter a positive number");
            int iPosNumber = int.Parse(Console.ReadLine());
            

            while (iPosNumber > 0)
            {
                Console.WriteLine("Enter a positive number again");
                iPosNumber = int.Parse(Console.ReadLine());
                iTotalOfNumbers = iTotalOfNumbers + 1;
            }

            Console.WriteLine("Amount of numbers given: " + iTotalOfNumbers);
        }
    }
}
