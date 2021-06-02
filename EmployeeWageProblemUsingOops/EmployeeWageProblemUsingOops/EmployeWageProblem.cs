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
        // public int Count_Work_Day = 20;
        // public int Emp_Per_Rate_Hour = 20;
        //public int MAx_Hrs_Or_Day_Month= 100;
        public int Working_Days_Per_Month =20;
        public int Working_Days = 0;
        public int empHrs = 0;
        public int EmployeeWage = 0;
        int totalWage = 0;
        int totalHours = 0;
        public void Attendance(string CompanyName, int WagePerHour, int NumWorkingDays, int MaxHoursPerMonth) //
        {
            // Stroing RandomValue
            for (int Day = 1; Day <= Working_Days_Per_Month; Day++)
            {
                Random random = new Random(); //Random Value

                int empCheck = random.Next(0, 3); //Check Random in b/w 0 to 3
                switch (empCheck) // switch Case
                {
                    case Emp_Full_Time: // For Full Time =1
                        empHrs = WagePerHour * 8; // *8
                        break;

                    case Emp_Part_Time: //for Part Time = 2
                        empHrs = WagePerHour * 4; //*4
                        break;

                    default:
                        empHrs = 0; //Default 0
                        break;
                }

                // EmployeeWage += empHrs; // EmployeeWage = EmployeeWage+ empHrs
                //Console.WriteLine("Day#:" + Working_Days + "Employee Hrs:" + empHrs);
                //checking total number of hours
                totalHours += empHrs / 20; //calculate total hours worked
                totalWage += empHrs; // calculating montly wage
                if (totalHours >= MaxHoursPerMonth) //maximum total hours 
                    break;
            }   
                
            //EmpSalary = EmployeeWage + Emp_Per_Rate_Hour; // EmpSalary = EmployeeWage + Emp_Per_Rate_Hour
           // Console.WriteLine("Employee Wage : " + EmployeeWage); // op
            Console.WriteLine();
            Console.WriteLine("Company Name :" + CompanyName);
            Console.WriteLine("Number Of Hour Employee  Worked  :" + totalHours);
            Console.WriteLine("Employee Wage Per Hour :" + WagePerHour);
            Console.WriteLine("Monthly wage :" + totalWage);      
            Console.WriteLine();
        } 
    }
}