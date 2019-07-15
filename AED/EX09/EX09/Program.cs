using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce your height: ");
            double iHeight = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduce your genre: ");
            string sGenre = Console.ReadLine();

            Console.WriteLine("Given height: " + iHeight);
            Console.WriteLine("Given genre (M/F): " + sGenre);

            double iWeight;

            if (sGenre == "M")
            {
                iWeight = (72.7 * iHeight) - 58;
                Console.WriteLine("You should have a weight of: " + iWeight + "kgs");
            }
            else if (sGenre == "F")
            {
                iWeight = (62.1 * iHeight) - 44.7;
                Console.WriteLine("you should have a weight of: " + iWeight + "kgs");
            }
            else
            {
                Console.WriteLine("Please introduce a proper genre value");
            }
        }
    }
}
