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
        public int Full_Day_Hour = 8;
        public int EmployeeWage;
        public void Attendance()
        {
            // Stroing RandomValue
            Random random = new Random();
            int empCheck = random.Next(0, 2); //checking Random Value in b/w 0 to 2
            if (empCheck == IS_PRESENT) // if  Is_Present = 1
            {
                Console.WriteLine("Employee is Present"); //Emp is Present
                CalculateDailyWage(); //Calculating Emp Full wage in this function
            }
            else  //if Is_Present = 0
            {
                Console.WriteLine("Employee is Absent"); //Emp is Absent
                Console.WriteLine("Employee Wage is null"); // if 0 it will be null
            }

        }
        //Calculation emp Full Wage
        public void CalculateDailyWage()
        {
             EmployeeWage = Wage_Per_Hours * Full_Day_Hour;  // Empwage = 20*8 
            Console.WriteLine("Employee Full Wage is : " + EmployeeWage); //op
        }
    }
}
