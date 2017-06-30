using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat
{
    class Program
    {
        static void Main(string[] args)
        {
            NAccount.Account A1 = new NAccount.Account();
            A1.showPass();

            Console.WriteLine("Введите пароль карточки");
            string carPass = Console.ReadLine();
            if (carPass==A1.pass)
            {
                Console.WriteLine("a. Вывод баланса");
                Console.WriteLine("b. Пополнение счёта");
                Console.WriteLine("c. Снять деньги");
                Console.WriteLine("d. Выход");
                var c = Console.ReadLine();
                while (true)
                {
                    switch (c)
                    {
                        case "a":
                            A1.getAmount();
                            Console.WriteLine("1. Вернутьсяв меню");
                            Console.WriteLine("2. Выход");
                            var a = Console.ReadLine();
                            switch (a)
                            {
                                case "1":
                                    break;
                                case "2":
                                    Console.ReadKey();
                                    break;

                            }
                            break;
                        case "b":
                            Console.Write("Сколько положите?: ");
                            A1.putCash(Double.Parse(Console.ReadLine()));
                            break;
                            //case "c":

                    }
                }
                
            }
        }
    }
}
