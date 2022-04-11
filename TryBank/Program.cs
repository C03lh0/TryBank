using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TryBank.Employees;

namespace TryBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee carlos = new Employee();

            carlos.Name = "Carlos Roberto";
            carlos.CPF = "125.654.215-30";
            carlos.Wage = 4500;

            Console.WriteLine(carlos.Name);
            Console.WriteLine(carlos.GetBonus());
            Console.ReadLine();
        }
    }
}