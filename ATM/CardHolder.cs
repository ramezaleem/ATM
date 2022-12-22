using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class CardHolder : Card
    {
        public int ch;
        public void check ()
        {
            Card user = new CardHolder();
            user.balance = 150.30;
            ch = int.Parse(Console.ReadLine());

            if ( ch == 1 )
            {

                Console.WriteLine("How much $$ would you like to deposit");
                user.deposit = double.Parse(Console.ReadLine());
                user.setBalance(user.getBalance() + user.deposit);
                Console.WriteLine("Thank you for your $$. Your new balance is : " + user.getBalance());
            }
            else if ( ch == 2 )
            {

                Console.WriteLine("How much $$ would you like to withdraw");
                user.withdraw = double.Parse(Console.ReadLine());
                if ( user.getBalance() < user.withdraw )
                {
                    Console.WriteLine("InSufficient balance :(");
                }
                else
                {
                    user.setBalance(user.getBalance() - user.withdraw);
                    Console.WriteLine("you're good to go! Thank you :)");
                }
            }
            else if ( ch == 3 )
            {

                Console.WriteLine("Your Current Balance : " + user.getBalance());
            }

        }


    }

}

