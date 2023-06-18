using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace keywords
{
    internal class Car
    {
        string engine;
        int numberOfTyre;
        int numberOfDoor;
        string gearType;
        string color;
        public Car(string engine, int numberOftyers, int numberOfDoor, string gearType, string color) 
        {
            this.engine = engine;
            this.numberOfTyre = numberOftyers;
            this.numberOfDoor = numberOfDoor;
            this.gearType = gearType;
            this.color = color;
        }
    }
}
