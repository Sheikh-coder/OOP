using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public class Car : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Key start");
        }
    }
}
