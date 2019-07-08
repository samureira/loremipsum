using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number:");
            int iNumber = int.Parse(Console.ReadLine());

            if (iNumber % 5 == 0)
            {
                Console.WriteLine("the number you entered «" + iNumber + "» is divisible by 5!");
            }
            else
            {
                Console.WriteLine("the number you entered «" + iNumber + "» is not divisible by 5!");
            }
        }
    }
}

/*
 *             Console.WriteLine("type your first number: ");
            int iFirstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("type your second number: ");
            int iSecondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("numbers: " + iFirstNumber + " | " + iSecondNumber);
*/
