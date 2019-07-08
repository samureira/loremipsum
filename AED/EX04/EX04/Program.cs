using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 
namespace EX04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number: ");
            int iNumber = int.Parse(Console.ReadLine());

            if (iNumber > 30)
            {
                Console.WriteLine(iNumber + " is bigger than 30!");
            }
            else if (iNumber < 30)
            {
                Console.WriteLine(iNumber + " is smaller than 30!");
            }
            else
            {
                Console.WriteLine(iNumber + " is equal to 30!");
            }

        }
    }
}
