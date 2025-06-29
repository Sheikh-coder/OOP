using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class PermanentEmployee : Employee
    {
        public override double CalculateSalary()
        {
            return 30000;
        }
    }
}
