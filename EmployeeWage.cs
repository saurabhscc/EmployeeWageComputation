using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeewageComputation
{
    class EmployeeWage
    {/// <summary>
    /// This method is used to check if Employee is absent or present
    /// </summary>
        public void Attendance()
        {
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == 0)
                Console.WriteLine("Employee is Present");
            else
                Console.WriteLine("Employee is Absent");
        }
    }
}
