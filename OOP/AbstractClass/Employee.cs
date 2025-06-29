using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public abstract class Employee
    {
        public string Name { get; set; }

        public abstract double CalculateSalary();

        public void PrintName()
        {
            Console.WriteLine($"Employee Name : {Name}");
        }
    }
}
