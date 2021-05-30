using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblemUsingOops
{
    class EmployeWageProblem
    {
        public int IS_PRESENT = 1;
        public int Wage_Per_Hours = 20;
        // public int Full_Day_Hour = 8;
        readonly int Emp_Full_Time = 2;
        readonly int Emp_Part_Time = 1;
        public int empHrs;
        public int EmployeeWage;
        public void Attendance()
        {
            // Stroing RandomValue
            Random random = new Random();
            int empCheck = random.Next(0, 2); //checking Random Value in b/w 0 to 2
            if (empCheck == Emp_Part_Time) //check if 1 == 1 
            {
                Console.WriteLine("Employee is Present"); //Present
                empHrs = 4; //* by 4
            }
            else //if Random is 2 
            {
                Console.WriteLine("Employee is Absent"); //absent
                empHrs = 0; // * 0
            }
            //calculate 
            EmployeeWage = empHrs * Wage_Per_Hours;
            Console.WriteLine("Employee Full Wage is : " + EmployeeWage); //op
        }
    }
}