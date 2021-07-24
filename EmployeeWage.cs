using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeewageComputation
{

    class EmployeeWage
    {   ///constants
        const int IS_PART_TIME = 1;
        const int IS_FULL_TIME = 2;
        const int EMP_WAGE_PER_HOUR = 20;
        //variables
        int empHrs = 0;
        int empWage = 0;
        /// <summary>
        /// This Method is Used to Check Employee Part Time Employee And Wage using SwitchCase
        /// </summary>
        public void PartTimeEmp()
                  
        {
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            switch (empCheck)
            {
                case IS_PART_TIME:
                    empHrs = 4;
                    break;
                case IS_FULL_TIME:
                    empHrs = 8;
                    break;
                default:
                    empHrs = 0;
                    break;
            }
            empWage = empHrs * EMP_WAGE_PER_HOUR;
                Console.WriteLine("Emp wage : " + empWage);

        }
        
    }
}
