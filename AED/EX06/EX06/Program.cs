using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert the 1st number: ");
            int iFirst = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert the 2nd number: ");
            int iSecond = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert the 3rd number: ");
            int iThird = int.Parse(Console.ReadLine());

            Console.WriteLine(iFirst + " | " + iSecond + " | " + iThird);

            if (iFirst > 0 && iSecond > 0 && iThird > 0)
            {
                Console.WriteLine("The above numbers can be part of a triangle!");
            }else
            {
                Console.WriteLine("These 3 numbers all together can't form a triangle!");
            }

        }
    }
}
