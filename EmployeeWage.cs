using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeewageComputation
{

    class EmployeeWage
    {///constants
        const int PER_HR_WAGE = 20;
        const int FULL_DAY_HR = 8;
        const int PART_TIME_HR = 4;
        //variables
        int totalWage;
        /// <summary>
        /// This Method is Used to Check Employee Part Time And Full Time WAge
        /// </summary>
        public void DailyWage()
                  
        {
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == 0)
            {
                totalWage = PER_HR_WAGE * FULL_DAY_HR;
            }
            else
            {
                totalWage = PER_HR_WAGE * PART_TIME_HR;
            }
            Console.WriteLine("Total emp wage" + totalWage);

        }
        
    }
}
