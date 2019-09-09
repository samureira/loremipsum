using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX13
{
    class Program
    {
        static void Main(string[] args)
        {

            int iResult = 0;

            Console.WriteLine("pick a first number: ");
            double iFirstNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("pick a second number: ");
            double iSecondNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("choose the operation: ");

            string sAdd = "1";
            string sSubtract = "2";
            string sMultiplication = "3";
            string sDivision = "4";

            string sOperation = Console.ReadLine();

            if (sOperation == sAdd)
            {
                iResult = Convert.ToInt32(iFirstNumber) + Convert.ToInt32(iSecondNumber);
                Console.WriteLine("(+) Result: " + iResult);
            }
            else if (sOperation == sSubtract)
            {
                iResult = Convert.ToInt32(iFirstNumber) - Convert.ToInt32(iSecondNumber);
                Console.WriteLine("(-) Result: " + iResult);
            }
            else if (sOperation == sMultiplication)
            {
                iResult = Convert.ToInt32(iFirstNumber) * Convert.ToInt32(iSecondNumber);
                Console.WriteLine("(*) Result: " + iResult);
            }
            else if(sOperation == sDivision)
            {
                iResult = Convert.ToInt32(iFirstNumber) / Convert.ToInt32(iSecondNumber);
                Console.WriteLine("(/) Result: " + iResult);
            }
            else
            {
                Console.WriteLine("operation not recognized!");
            }

        }
    }
}
