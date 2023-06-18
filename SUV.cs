using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace keywords
{
    internal class SUV : Car
    {
        string specialTyer;
        string foldableSeats;
        int extandableLegSpace;
        public SUV(string engine, int numberOftyers, int numberOfDoor, string gearType, string color, string specialTyer, string foldableSeats, int extandableLegSpace) : base(engine, numberOftyers, numberOfDoor, gearType, color)
        {
            this.specialTyer = specialTyer;
            this.foldableSeats = foldableSeats;
            this.extandableLegSpace = extandableLegSpace;
        }
    }
}
