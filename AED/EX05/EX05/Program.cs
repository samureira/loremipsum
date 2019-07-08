using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the first number:");
            int iFirst = int.Parse(Console.ReadLine());
            Console.WriteLine("enter a second number (different from the previous):");
            int iSecond = int.Parse(Console.ReadLine());
            Console.WriteLine("enter a third number (different from the previous two):");
            int iThird = int.Parse(Console.ReadLine());

            int[] numbers = new int[3];
            numbers[0] = iFirst;
            numbers[1] = iSecond;
            numbers[2] = iThird;

            Array.Sort(numbers);
            Array.Reverse(numbers);

            Console.WriteLine("in descending order, the numbers you entered are: ");
            foreach (int iValueNumber in numbers)
            {
                Console.WriteLine(iValueNumber + " ");
            }

        }
    }
}
