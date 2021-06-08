using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblemUsingOops
{
    // class For CompanyEmpWage
    class CompanyEmpWage
    {
        //instance variable
        public readonly string companyName;
        public readonly int wagePerHour;
        public readonly int maxWorkingDays;
        public readonly int maxWorkingHours;
        // by default wagesPerMonth  0 
        public int wagesPerMonth = 0;
        // by default wagesPerMonth  0 
        public int dailyWage = 0;
        //constructor for  CompanyEmpWage using multiple parameters
        public CompanyEmpWage(string companyName, int wagePerHour, int maxWorkingDays, int maxWorkingHours)
        {
            // diff b/w global varable and constructor variable
            this.companyName = companyName;
            this.wagePerHour = wagePerHour;
            this.maxWorkingDays = maxWorkingDays;
            this.maxWorkingHours = maxWorkingHours;
        }
        //instance method for setWagesPerMonth
        public void setWagesPerMonth(int wagesPerMonth)
        {
            this.wagesPerMonth = wagesPerMonth;
        }
        public void setDailyWage(int dailyWage)
        {
            this.dailyWage = dailyWage;
        }
        //instance method for printMonthlyWage
        public void printMonthlyWage()
        {
            //prinitng  Wage Of a company
            Console.WriteLine($"Wages for the company {companyName} for the month : {wagesPerMonth}");
        }
        //instance method for printDailyWage
        public void printDailyWage()
        {
            //op printing daily wage for a company
            Console.WriteLine($"Daily Wage for the company {companyName} : {dailyWage}");
        }
    }
}
