using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX15
{
    class Program
    {
        static void Main(string[] args)
        {
            double iDomesticEnergy = 0.60;
            double iComercialEnergy = 0.48;
            double iIndustrialEnergy = 1.29;

            double iCost;

            Console.WriteLine("Type of Client? (D for Domestic, C for Comercial and I for Industrial)");
            string sClientType = Console.ReadLine().ToUpper();
            Console.WriteLine("How many hours?");
            int iHours = int.Parse(Console.ReadLine());

            if (sClientType == "D")
            {
                Console.WriteLine(iCost = iDomesticEnergy * iHours);
            }
            else if (sClientType == "C")
            {
                Console.WriteLine(iCost = iComercialEnergy * iHours);
            }
            else if (sClientType == "I")
            {
                Console.WriteLine(iCost = iIndustrialEnergy * iHours);
            }

        }
    }
}
