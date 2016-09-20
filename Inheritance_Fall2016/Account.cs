using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Fall2016
{
    abstract class  Account
    {

        public virtual void Withdraw()
        {
            Console.WriteLine("We removed some cash.");
        }

        public virtual void Deposit()
        {
            Console.WriteLine("We addded some money to our piggy bank.");
        }

        public abstract void SendMoney();
    }
}
