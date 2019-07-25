using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX12
{
    class Program
    {
        static void Main(string[] args)
        {
            double iRendimento;

            Console.WriteLine("introduzir aplicacao mensal: ");
            double iValorAplicacaoMensal = double.Parse(Console.ReadLine());

            Console.WriteLine("introduzir taxa: ");
            double iTaxa = double.Parse(Console.ReadLine());

            Console.WriteLine("introduzir numero de meses: ");
            int iNumeroDeMeses = int.Parse(Console.ReadLine());

            iRendimento = iValorAplicacaoMensal * Math.Pow((1 + iTaxa), Convert.ToDouble(iNumeroDeMeses)) - 1 / iTaxa;
            Console.WriteLine("iRendimento: " + iRendimento);

        }
    }
}
