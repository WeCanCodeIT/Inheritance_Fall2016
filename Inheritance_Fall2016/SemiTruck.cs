using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Fall2016
{
    class SemiTruck : Vehicle
    {
        private int maxPayload;

        public SemiTruck( int maxPayload)
        {
            Seats = 2;
            Wheels = 18;
            hornVolume = 30.0;
            this.maxPayload = maxPayload;
        }

        public override void Display()
        {
            hornVolume = 40.0;
            Console.WriteLine("Seats: {0}, Wheels: {1}, Horn Volume: {2}, Max payload is {3} lbs", Seats, Wheels, hornVolume, maxPayload);
        }
    }
}
