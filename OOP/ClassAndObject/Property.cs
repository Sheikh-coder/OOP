using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject
{
    public class Property
    {
        private int age;
        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 0)
                    age = value;

                else
                    throw new ArgumentException("Age Cannot be negative");
            }
        }
    }
}
