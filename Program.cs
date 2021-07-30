using System;

namespace EmployeewageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeWage dMart = new EmployeeWage("Dmart", 20, 2, 10);
            dMart.computeEmpWage();
            Console.WriteLine(dMart.toString());
            EmployeeWage reliance = new EmployeeWage("Reliance", 40, 4, 20);
            reliance.computeEmpWage();
            Console.WriteLine(reliance.toString());
        }
    }
}
