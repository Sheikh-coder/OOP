using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class ContractEmployee : Employee
    {
        public override double CalculateSalary()
        {
            return 10 * 200;
        }
    }
}
