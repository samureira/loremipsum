using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX02
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("type your first number: ");
            int iFirstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("type your second number: ");
            int iSecondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("numbers: " + iFirstNumber + " | " + iSecondNumber);

            int iTotal = iFirstNumber + iSecondNumber;

            if (iTotal > 10)
            {
                Console.WriteLine("result bigger than 10!");
            }
            else if (iTotal == 10)
            {
                Console.WriteLine("result equal to 10!");
            }
            else
            {
                Console.WriteLine("result smaller than 10!");
            }
  
        }
    }
}
