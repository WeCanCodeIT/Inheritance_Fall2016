using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Fall2016
{
    class Car : Vehicle
    {

        public Car()
        {
            Seats = 5;
            Wheels = 4;
            hornVolume  =  20.0;
        }

        public void Display()
        {
            Console.WriteLine("Seats: {0}, Wheels: {1}, Horn Volume: {2}", Seats, Wheels, hornVolume);
        }
    }
}
