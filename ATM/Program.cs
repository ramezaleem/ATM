using System;
using System.Collections.Generic;
using System.Linq;

namespace ATM
{

    class Program
    {
        static void Main ( string[] args )
        {
            Console.WriteLine("Welcome Ramez :)");
            CardHolder user = new CardHolder();
            do
            {
                Console.WriteLine("Please choose from one of the following option...");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Show Balance"); // 160
                Console.WriteLine("4. Exit");
                user.check();
            } while ( user.ch!= 4);
            Console.WriteLine("Thank you! Have a nice day :)");
           


        }
    }
}
