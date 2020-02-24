using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class Car : Vehicle //Cars inherits from the vehicle class.
    {
        public override void Drive() //Overrides the base class method Drive.
        {
            Console.WriteLine("Motoring");
        }
        public void Accelerate()
        {
            Console.WriteLine("Accelerating");
        }
        public void Brake()
        {
            Console.WriteLine("Braking");
        }
    }
}
