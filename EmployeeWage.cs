using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeewageComputation
{

   public class EmployeeWage
   {   ///constants
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
         
        private string company;
        private int empRatePerHour;
        private int numOfWorkingDays;
        private int maxHoursinMonth;
        private int totalEmpWage;

        public EmployeeWage (string company, int empRatePerHour, int numOfWorkingDays, int maxHoursinMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursinMonth = maxHoursinMonth; 
        }
         public void computeEmpWage()
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;


            while (totalEmpHrs <= this.maxHoursinMonth && totalWorkingDays < this.numOfWorkingDays)
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
            totalEmpWage = totalEmpHrs * this.empRatePerHour;
            Console.WriteLine("Total Emp Wage for company :" + company + " is " + totalEmpWage);
            
        }
        public string toString()
        {
            return "Total Emp Wage for company :" + company + " is " + totalEmpWage;
        }
      
    }

}


