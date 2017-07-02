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


            var i = 0;
            while (i < 3)
            {
                Console.WriteLine("Введите пароль карточки");
                string carPass = Console.ReadLine();

                if (carPass == A1.pass)
                {
                    while (true)
                    {
                        {
                            Console.WriteLine("a. Вывод баланса");
                            Console.WriteLine("b. Пополнение счёта");
                            Console.WriteLine("c. Снять деньги");
                            Console.WriteLine("d. Выход");


                            var c = Console.ReadLine();
                            switch (c)
                            {
                                case "a":
                                    A1.getAmount();
                                    Console.WriteLine("1. Вернуться в меню");
                                    Console.WriteLine("2. Выход");
                                    var a = Console.ReadLine();
                                    switch (a)
                                    {
                                        case "1":
                                            break;
                                        case "2":
                                            return;
                                    }
                                    break;
                                case "b":
                                    Console.Write("Сколько положите?: ");
                                    A1.putCash(Double.Parse(Console.ReadLine()));
                                    Console.WriteLine("1. Вернуться в меню");
                                    Console.WriteLine("2. Выход");
                                    var b1 = Console.ReadLine();
                                    switch (b1)
                                    {
                                        case "1":
                                            break;
                                        case "2":
                                            return;
                                    }
                                    break;
                                case "c":
                                    Console.Write("У Вас имеется: ");
                                    A1.getAmount();
                                    Console.Write("Сколько желаете снять?: ");
                                    double am;
                                    try
                                    {
                                        am = Double.Parse(Console.ReadLine());
                                    }
                                    catch (System.FormatException e)
                                    {
                                        Console.WriteLine(e.Message);
                                        break;

                                    }

                                    if (am > A1.amount)
                                    {
                                        Console.WriteLine("Недостаточно средств!");
                                    }
                                    else
                                    {

                                        A1.getCash(am);

                                    }
                                    Console.WriteLine("1. Вернуться в меню");
                                    Console.WriteLine("2. Выход");
                                    var b2 = Console.ReadLine();
                                    switch (b2)
                                    {
                                        case "1":
                                            break;
                                        case "2":
                                            return;
                                    }

                                    break;
                                case "d":
                                    return;
                                default: break;

                            }


                        }


                    }
                }
                else
                {
                    Console.WriteLine("Невеный пароль");
                    i++;
                }

            }
        }
    }
}
