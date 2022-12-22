using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public interface ICardHolder
    {
         void setPin ( int newPin );
         void setCard ( string newNumCard );
         void setFristName ( string newFName );
         void setLastName ( string newLName );
         void setDeposit ( double newDeposit );
         void setWithdraw ( double newWithdraw );
         void setBalance ( double newBalance );
         string getCard ();
         int getPin ();
         string getFristName ();
         string getLastName ();
         double getDeposit ();
         double getWithdraw ();
         double getBalance ();
    }
}
