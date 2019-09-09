using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX23
{
    class Program
    {
        static void Main(string[] args)
        {
            int AccountNumber;
            int AccountBalance;

            int NegAccounts = 0;
            int AccountsQuantity = 0;

            int NegPercentage;

            do
            {
                Console.WriteLine("Enter account number");
                AccountNumber = int.Parse(Console.ReadLine());

                if (AccountNumber <= 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Enter account balance");
                    AccountBalance = int.Parse(Console.ReadLine());

                    if (AccountBalance < 0)
                    {
                        Console.WriteLine("Negative Balance!");
                        NegAccounts = NegAccounts + 1;
                        AccountsQuantity = AccountsQuantity + 1;
                    }
                    else
                    {
                        Console.WriteLine("Non-Negative Balance!");
                        AccountsQuantity = AccountsQuantity + 1;
                    }
                }

            } while (AccountNumber > 0);

            NegPercentage = (NegAccounts / AccountsQuantity) * 100;
            Console.WriteLine("(-) Percentage: " + NegPercentage);
        }
    }
}
