using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public abstract class Card : ICardHolder
    {
        public string cardNum;
        public int pin;
        public string FName;
        public string LName;
        public double balance ;
        public double deposit;
        public double withdraw;

        public double getBalance ()
        {
            return this.balance;
        }

        public string getCard ()
        {
            return cardNum;
        }

        public double getDeposit ()
        {
            return this.deposit;
        }

        public string getFristName ()
        {
            return FName;
        }

        public string getLastName ()
        {
            return LName;
        }

        public int getPin ()
        {
            return pin;
        }

        public double getWithdraw ()
        {
            return withdraw;
        }

        public void setBalance ( double newBalance )
        {
            this.balance = newBalance;
        }

        public void setDeposit ( double newDeposit )
        {
            this.deposit = newDeposit;
        }


        public void setCard ( string newNumCard )
        {
            cardNum = newNumCard;
        }


        public void setFristName ( string newFName )
        {
            FName = newFName;
        }


        public void setLastName ( string newLName )
        {
            LName = newLName;
        }


        public void setPin ( int newPin )
        {
            pin = newPin;
        }


        public void setWithdraw ( double newWithdraw )
        {
            this.withdraw = newWithdraw;
        }

    }
}
