using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your height: ");
            double iHeight = double.Parse(Console.ReadLine());
            Console.WriteLine("enter your weight: ");
            double iWeight = double.Parse(Console.ReadLine());

            double iImc = iWeight / (iHeight * iHeight);
            Console.WriteLine(iImc);

            switch (iImc)
            {
                case double n when (iImc < 20):
                    Console.WriteLine("below 20!");
                    break;
                case double n when (iImc > 20 && iImc < 25):
                    Console.WriteLine("between 20 and 25");
                    break;
                case double n when (iImc > 25 && iImc < 30):
                    Console.WriteLine("between 25 and 30");
                    break;
                case double n when (iImc > 30 && iImc < 35):
                    Console.WriteLine("between 30 and 35");
                    break;
                default:
                    Console.WriteLine("above 35!");
                    break;

            }
        }
    }
}
