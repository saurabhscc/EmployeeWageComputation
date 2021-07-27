using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeewageComputation
{

   public class EmployeeWage
    {   ///constants
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
         int empHrs = 0;
         int totalEmpHrs = 0;
         int totalWorkingDays = 0;

        /// <summary>
        /// This Method Use Calculate Employee wage For Multiple Companies
        /// </summary>
        /// <param name="company"></param>
        /// <param name="empwagePerHour"></param>
        /// <param name="numOfWorkingDays"></param>
        /// <param name="maxHoursinMonth"></param>
        /// <returns></returns>
        public int ComputeEmpWage(String company, int empwagePerHour, int numOfWorkingDays, int maxHoursinMonth)
                
        {
            
            while (totalEmpHrs <= maxHoursinMonth && totalWorkingDays < numOfWorkingDays)
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
            int totalEmpWage = totalEmpHrs * empwagePerHour;
            Console.WriteLine("Total Emp Wage for company :" + company + " is " + totalEmpWage);
            return totalEmpWage;

        }
        
    }
}

