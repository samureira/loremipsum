using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX01
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("introduza um primeiro numero: ");
            int iPrimeiroNumero = Int32.Parse(Console.ReadLine());
            Console.WriteLine("introduza um segundo numero: ");
            int iSegundoNumero = Int32.Parse(Console.ReadLine());

            int iSoma = iPrimeiroNumero + iSegundoNumero;
            Console.WriteLine("Resultado da soma: " + iSoma);

            if (iSoma > 10)
            {
                Console.WriteLine("o resultado é superior a 10!");
            }

        }
    }
}
