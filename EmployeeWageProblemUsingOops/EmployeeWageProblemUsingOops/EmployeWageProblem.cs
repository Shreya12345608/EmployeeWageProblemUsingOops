using EmployeeWageProblemUsingOops;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageProblem
{
    /// <summary>
    /// 
    /// </summary>
    class EmployeWageProblem

    {
        //variable with there value
        public int FULL_DAY_HOUR = 8;
        public int PART_TIME_HOUR = 4;
        const int EMP_FULL_TIME = 1;
        const int EMP_PART_TIME = 2;
        // CompanyEmpWage array [] companies 
        CompanyEmpWage[] companies;
        int noOfCompanies;
        //constructor of EmployeeWageProblem
        public EmployeWageProblem()
        {
            //storing 10 CompanyEmpWage in array
            companies = new CompanyEmpWage[10];
            //by default noOfCompanies =0;
            noOfCompanies = 0;
        }
        //Instance method with parameters
        public void AddCompany(string companyName, int wagePerHour, int maxWorkingDays, int maxWorkingHours)
        {
            //creating constructor object of CompanyEMpWage
            CompanyEmpWage company = new CompanyEmpWage(companyName, wagePerHour, maxWorkingDays, maxWorkingHours);
            company.setWagesPerMonth(this.ComputeMonthlyWage(company));
            companies[noOfCompanies] = company;
            //noofCompanies = noofCompanies +1
            noOfCompanies++;
        }
        //method for add company
        public void AddCompany(CompanyEmpWage company)
        {
            company.setWagesPerMonth(this.ComputeMonthlyWage(company));
            companies[noOfCompanies] = company;
            //noofCompanies = noofCompanies +1
            noOfCompanies++;
        }
        public int ComputeMonthlyWage(CompanyEmpWage company)
        {
            //variable
            int workingHours = 0;
            int workingDays = 0;
            int wagesPerMonth = 0;
            int attendance;
            int empHrs = 0;
            // creating randoom object
            Random rand = new Random();
            //checking in while 
            while (workingHours < company.maxWorkingHours && workingDays < company.maxWorkingDays)
            {
                attendance = rand.Next(0, 3); //Check Random in b/w 0 to 3
                //using switch case
                switch (attendance)
                {
                    //Emp Full Time
                    case EMP_FULL_TIME:
                        workingDays += 1; // workingDays = workingDays +1
                        empHrs = FULL_DAY_HOUR;  //8 
                        break;
                    //Emp PArt Time
                    case EMP_PART_TIME:
                        workingDays += 1; // workingDays = workingDays +1
                        empHrs = PART_TIME_HOUR; --4
                        break;
                    default:
                        break;
                }//end Switch
                 //  workingHours = workingHours  + empHrs
                workingHours += empHrs;
                //wagesPerMonth + (company.wagePerHour * workingHours);
                wagesPerMonth += (company.wagePerHour * workingHours);

            }//end while
            //return value
            return wagesPerMonth;
        } // end  ComputeMonthlyWage(CompanyEmpWage company)

        //Adding Multiple Company using loop
        public void DisplayCompanyWages()
        {
            for (int Display_i = 0; Display_i < noOfCompanies; Display_i++)
                companies[Display_i].printMonthlyWage();
         }

    }
}