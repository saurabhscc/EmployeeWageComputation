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
        const int MAX_HRS_IN_MONTH = 100;
        //variables
        int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;

        /// <summary>
        /// This Method is Used For find Employee Wage For Month With Working Hrs Or Day Reached 
        /// </summary>
        public void EmpMonthWage()

        {
            while (totalEmpHrs <= MAX_HRS_IN_MONTH && totalWorkingDays < NUM_OF_WORKING_DAYS)
            {

                totalWorkingDays++; 
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
                totalEmpHrs += empHrs;
                Console.WriteLine("days:" + totalWorkingDays + " Emp Hrs :" + empHrs);
            }
            int totalEmpWage = totalEmpHrs * EMP_WAGE_PER_HOUR;
            Console.WriteLine("Total Emp Wage : " + totalEmpWage);

        }
        
    }
}

