using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblemUsingOops
{   /// <summary>
/// interface for ComputeEmpWage
/// </summary>
    interface IComputeEmpWage
    {
        //  interface method of AddCompany( with body)
        void AddCompany(string companyName, int wagePerHour, int maxWorkingDays, int maxWorkingHours);
        //  interface method of ComputeMonthlyWage( with body)
        //Calculating 
        int ComputeMonthlyWage(CompanyEmpWage company);
        // interface method (does not have a body)
        //Company Display Comany Wages 
        void DisplayCompanyWages();
    }
}
