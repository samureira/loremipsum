using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX14
{
    class Program
    {
        static void Main(string[] args)
        {
            int iCarClassA = 12;
            int iCarClassB = 9;
            int iCarClassC = 8;

            int iCarConsume;


            Console.WriteLine("Write the distance (in Kms):");
            int iDistance = int.Parse(Console.ReadLine());
            Console.WriteLine("Write the class of the car:");
            string sCarClass = Console.ReadLine();

            if (sCarClass == "A")
            {
                Console.WriteLine(iCarConsume = iDistance / iCarClassA);
            }
            else if (sCarClass == "B")
            {
                Console.WriteLine(iCarConsume = iDistance / iCarClassB);
            }
            else if (sCarClass == "C")
            {
                Console.WriteLine(iCarConsume = iDistance / iCarClassC);
            }
            else
            {
                Console.WriteLine("Not a valid Car Class!");
            }

        }
    }
}
