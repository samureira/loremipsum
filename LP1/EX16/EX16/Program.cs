using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's the age of the athlete?");
            int iAge = int.Parse(Console.ReadLine());

            switch (iAge)
            {
                case int n when (iAge >= 5 && iAge <= 7):
                    Console.WriteLine("Mini A");
                    break;
                case int n when (iAge >= 8 && iAge <= 10):
                    Console.WriteLine("Mini B");
                    break;
                case int n when (iAge >= 11 && iAge <= 13):
                    Console.WriteLine("Iniciado");
                    break;
                case int n when (iAge >= 14 && iAge <= 17):
                    Console.WriteLine("Cadete");
                    break;
                case int n when (iAge >= 16 && iAge <= 25):
                    Console.WriteLine("Junior B / Junior A");
                    break;
                default:
                    Console.WriteLine("Senior");
                    break;
            }
        }
    }
}
