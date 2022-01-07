using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountClient
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount ba = new BankAccount("Mr. Bryan Walton", 10);

            ba.Credit(5);
            ba.Debit(5);
            Console.WriteLine("Current balance is ${0}", ba.Balance);
            Console.ReadKey();
        }
    }
}
