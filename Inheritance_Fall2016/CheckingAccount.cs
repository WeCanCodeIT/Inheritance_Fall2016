using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Fall2016
{
    class CheckingAccount : Account
    {
        public override void SendMoney()
        {
            throw new NotImplementedException();
        }

        public override void Withdraw()
        {
            base.Withdraw();
            Console.WriteLine("We removed some cash in a different way.");
        }
    }
}
