using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class Airplane : Vehicle //Airplane class inherits from the vehicle class.
    {
        public override void Drive() //Overrides the base class method Drive.
        {
            Console.WriteLine("Flying");
        }
        public void TakeOff()
        {
            Console.WriteLine("Taking Off");
        }
        public void Land()
        {
            Console.WriteLine("Landing");
        }
    }
}
