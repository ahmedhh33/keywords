using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace keywords
{
    internal class sportCars : Car
    {
        string nitros;
        string seatBults;
        public sportCars(string engine, int numberOftyers, int numberOfDoor, string gearType, string color, string nitros, string seatBults) : base(engine, numberOftyers, numberOfDoor, gearType, color)
        {
            this.nitros = nitros;
            this.seatBults = seatBults;
        }
    }
}
