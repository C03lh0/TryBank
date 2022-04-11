using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryBank.Employees
{
    public class Employee
    {
        public string Name { get; set; }
        public string CPF { get; set; }
        public double Wage { get; set; }

        public double GetBonus()
        {
            return Wage * 0.10;
        }
    }
}
