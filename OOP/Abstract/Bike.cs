using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public class Bike : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Kick start");
        }
    }
}
