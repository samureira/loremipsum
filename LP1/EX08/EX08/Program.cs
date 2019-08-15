using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert a 1st number: ");
            int iFirstNr = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert a 2nd number: ");
            int iSecondNr = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert a 3rd number: ");
            int iThirdNr = int.Parse(Console.ReadLine());

            Console.WriteLine("The numbers inserted are: " + iFirstNr + ", " + iSecondNr + " and " + iThirdNr);

            if (iFirstNr > 0 && iSecondNr > 0 && iThirdNr > 0)
            {
                Console.WriteLine("The above numbers can form a triangle!");
                if (iFirstNr == iSecondNr && iSecondNr == iThirdNr)
                {
                    Console.WriteLine("The numbers form an Equilateral triangle since all numbers are equal!");
                }
                else if (iFirstNr != iSecondNr && iSecondNr != iThirdNr)
                {
                    Console.WriteLine("The numbers form a Scalene triangle!");
                }
                else
                {
                    Console.WriteLine("The numbers form an Isosceles triangle!");
                }
            }
            else
            {
                Console.WriteLine("the sequence of numbers can not form a triangle!");
            }
        }
    }
}
