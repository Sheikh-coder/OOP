using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class PermanentEmployee : IEmployee 
    {
        public string Name { get; set; }

        public double CalculateSalary()
        {
            return 40000;
        }

        public void PrintName()
        {
            Console.WriteLine($"Employee Name : {Name}");
        }
    }
}
