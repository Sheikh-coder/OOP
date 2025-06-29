using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public interface IEmployee
    {
        string Name { get; set; }
        double CalculateSalary();
        void PrintName();
    }
}
