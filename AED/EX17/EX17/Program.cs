using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX17
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Enter a number of your choice: ");
            int iNumber = int.Parse(Console.ReadLine());
            int iNewNumber = iNumber * 3;

            while (iNumber != -999)
            {
                Console.WriteLine("The triple of " + iNumber + " is: " + iNewNumber);
                Console.WriteLine("Enter again a number of your choice: ");
                iNumber = int.Parse(Console.ReadLine());
                iNewNumber = iNumber * 3;
            }

            Console.WriteLine("You introduced number -999! The program is terminated!");
        }
    }
}
