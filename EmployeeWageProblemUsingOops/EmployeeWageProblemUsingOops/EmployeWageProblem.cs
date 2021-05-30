using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblemUsingOops
{
    class EmployeWageProblem
    {
        const int Emp_Full_Time = 1;
        const int Emp_Part_Time = 2;
        public int Wage_Per_Hours = 20;
        public int empHrs = 0;
        public int EmployeeWage;
        public void Attendance()
        {
            // Stroing RandomValue
            Random random = new Random();
            int empCheck = random.Next(0, 3); //checking Random Value in b/w 0 to 3
            //Switch Case
            switch (empCheck)
            {
                case Emp_Full_Time: // For Emp Full Time  =1
                    empHrs = 8; // * 8
                    break;

                case Emp_Part_Time: // For Emp Full Time  =2
                    empHrs = 4; // * 4
                    break;

                default:
                    empHrs = 0; //By Default 0
                    break;
            }

           // Calculate
            EmployeeWage = empHrs * Wage_Per_Hours; 
            Console.WriteLine("Employee wage: " + EmployeeWage); // op
        }
    }
}