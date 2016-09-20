using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Fall2016
{
    class Program
    {
        static void Main(string[] args)
        {
            Car celica = new Car();
            SemiTruck mac = new SemiTruck(24000);


            List<Vehicle> vehicleList = new List<Vehicle>();

            vehicleList.Add(celica);
            vehicleList.Add(mac);

            foreach (Vehicle currentVehicle in vehicleList)
            {
                currentVehicle.Display();
            }


            //CheckingAccount check = new CheckingAccount();

            //check.Withdraw();
            //check.SendMoney();

        }
    }
}
