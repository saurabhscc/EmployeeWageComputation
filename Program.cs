using System;

namespace EmployeewageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeWage empwage = new EmployeeWage();
            empwage.ComputeEmpWage("Dmart",20,2,10);
            empwage.ComputeEmpWage("Reliance", 10, 4, 20);

        }

    }
}
