using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Bankomat
{

    namespace NAccount
    {
        class Account
        {
            string accNumber;
            public string pass;
            public double amount;
            Random rnum = new Random();

            public Account()
            {
                accNumber = rnum.Next(1, 100).ToString();
                pass = "pass" + rnum.Next(1, 100).ToString();
                Console.Write("Сколько хотите положить денег?: ");
                try
                {
                    amount = Double.Parse(Console.ReadLine());
                }
                catch (System.FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            public void putCash(double c)
            {
                amount = amount + c;
                Console.WriteLine("Вы положиди на счёт {0}. Теперь у вас {1}.", c, amount);
            }
            public void showPass()
            {
                Console.WriteLine(pass);
            }
            public void getAmount()
            {
                Console.WriteLine(amount);
            }
            public void getCash(double c)
            {
                amount = amount - c;
            }
        }
    }
}