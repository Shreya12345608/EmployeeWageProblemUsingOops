using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageProblem
{
    // accessModifier class class name
    public class EmpWageBuilderObject 
    {
        //constants
        const int Emp_Full_Time = 1;
        const int Emp_Part_Time = 2;
        //properties 
        private string CompanyName;
        private int WagePerHour;
        private int NumWorkingDays;
        private int MaxHoursPerMonth;
        private int totalWage;

        // Constructor class of EmpWageBuilderObject
        public EmpWageBuilderObject(string CompanyName, int WagePerHour, int NumWorkingDays, int MaxHoursPerMonth)
        {
            //Constructors
            this.CompanyName = CompanyName;
            this.WagePerHour = WagePerHour;
            this.NumWorkingDays = NumWorkingDays;
            this.MaxHoursPerMonth = MaxHoursPerMonth;
        }
        public void Attendance()
        //instance method
        {

            //variables
            int DailyWage = 0;
            int days, isPresent;
            // int totalWage = 0;
            int totalHours = 0;
            //random number generation
            Random rand = new Random();
            //calculating for month
            for (days = 1; days <= this.NumWorkingDays; days++) // calculating for 20 working days
            {
                isPresent = rand.Next(0, 3);
                //using switch case
                switch (isPresent)
                {
                    case Emp_Full_Time: // Employee is present full time
                        {
                            //instance Variable Name
                            DailyWage = this.WagePerHour * 8;
                            break;
                        }
                    case Emp_Part_Time: //employee is present for part time
                        {
                            //instance Variable Name
                            DailyWage = this.WagePerHour * 4;
                            break;
                        }
                    default: // employee is absent
                        {
                            DailyWage = isPresent;
                            break;
                        }
                }
                //checking total number of hours
                totalHours += DailyWage / 20; //calculate total hours worked
                totalWage += DailyWage; // calculating montly wage
                if (totalHours >= this.MaxHoursPerMonth) //maximum total hours 
                    break;
            }
            //Console.WriteLine($"Montly wage is {totalWage} and working hours is {totalHours}"); // output 
            Console.WriteLine();
            Console.WriteLine($"Company Name :{this.CompanyName}"); // DMart
            Console.WriteLine($"No. of hours worked :{totalHours}"); // 8
            Console.WriteLine($"Wage Per hour :{this.WagePerHour}"); //20
            Console.WriteLine($"Monthly wage :{this.totalWage}");//160
        }
        //displaying results
        public string Result()
        {
            //Op Will be Total Employee wage for Comapny : DMart is 160
            return "Total Employee wage for Comapny : " + this.CompanyName + " is " + this.totalWage;
        }
    }
}