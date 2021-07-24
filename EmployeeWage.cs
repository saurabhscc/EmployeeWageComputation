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
        const int NUM_OF_WORKING_DAYS = 20;
        //variables
        int empHrs = 0, empWage = 0, totalEmpWage = 0;

        /// <summary>
        /// This Method is Used to Check Employee Wage For Month
        /// </summary>
        public void EmpMonthWage()

        {
            for (int day = 0; day < NUM_OF_WORKING_DAYS; day++)
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
                totalEmpWage += empWage;
                Console.WriteLine("Emp wage : " + empWage);
            }
            Console.WriteLine("Total Emp Wage : " + totalEmpWage);

        }
        
    }
}

