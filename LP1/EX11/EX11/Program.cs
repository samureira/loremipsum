using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of X: ");
            double iValueX = double.Parse(Console.ReadLine());

            double i1stFunc = ((5*iValueX)+3);
            double i2ndFunc = ( ((iValueX*iValueX)-16) * 0.5);

            double iFinalFunc = (i1stFunc / i2ndFunc);

            Console.WriteLine("iFinalFunc: " + iFinalFunc);
        }
    }
}
