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
            double amount;
            Random rnum = new Random();

            public Account ()
            {
                accNumber = rnum.Next(1, 100).ToString();
                pass = "pass" + rnum.Next(1, 100).ToString();
            }
            //public string CreateAccNumber()
            //{
            //    Random rnum = new Random();
            //    accNumber = rnum.Next(1, 100).ToString();
            //    return accNumber;
            //}
            //public string CreatePass()
            //{
            //    Random rnum = new Random();
            //    pass="pass"+ rnum.Next(1, 100).ToString();
            //    return pass;
            //}
            public void putCash(double c)
            {
                amount = amount+c;
            }
            public void showPass()
            {
               Console.WriteLine(pass);
            }
            public void getAmount()
            {
                Console.WriteLine(amount);
            }
        }
    }
}