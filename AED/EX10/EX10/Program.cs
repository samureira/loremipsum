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

            switch (true)
            {
                case iImc < 20:
                    Console.WriteLine("below weight!");
                    break;
                case iImc <= 20 && iImc > 25:
                    Console.WriteLine("asda");
                    break;
                case iImc > 25 && iImc <= 30:
                    Console.WriteLine("asdadsad");
                    break;
                case iImc > 30 && iImc <= 35:
                    Console.WriteLine("asdasd");
                    break;
                default:
                    Console.WriteLine("morbid obesity");
                    break;

            }
        }
    }
}
