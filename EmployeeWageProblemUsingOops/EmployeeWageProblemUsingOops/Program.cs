using EmployeeWageProblem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblemUsingOops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            //Emp is Present Or Absent
            // invoke constructor
            EmployeWageProblem empWageBuilder = new EmployeWageProblem();
            ///string companyName, int wagePerHour, int maxWorkingDays, int maxWorkingHours
            empWageBuilder.AddCompany("TCS", 20, 2, 10);
            empWageBuilder.AddCompany("TATA", 30, 2, 10);
            empWageBuilder.AddCompany("Infoys", 40, 2, 10);
            empWageBuilder.AddCompany("Google", 50, 2, 10);
            empWageBuilder.DisplayCompanyWages();
            empWageBuilder.DisplayCompanyDailyWages();
            Console.ReadKey();
        }

        
    }
}
