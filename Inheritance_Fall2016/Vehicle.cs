using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Fall2016
{
    class Vehicle
    {
        private int numberOfWheels;
        private int numberOfSeats;

        public int Wheels
        {
            get { return this.numberOfWheels; }
            set { numberOfWheels = value; }
        }

        public int Seats
        {
            get { return this.numberOfSeats; }
            set { numberOfSeats = value; }
        }

        protected double hornVolume;


    }
}
