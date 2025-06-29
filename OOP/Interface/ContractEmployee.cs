using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class ContractEmployee : IEmployee
    {
        public string Name { get; set; }

        public double CalculateSalary()
        {
            return 10 * 400;
        }

        public void PrintName()
        {
            Console.WriteLine($"Employee Name : {Name}");
        }
    }
}
