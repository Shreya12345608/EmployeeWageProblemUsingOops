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
            //EmployeWageProblem EmployeeWage = new EmployeWageProblem();
            //EmployeeWage.Attendance("DMart", 20, 2, 10);
            //EmployeeWage.Attendance("BigBazar", 10, 4, 20);
            //create anf initialize object                                                                // invoke constructor
            EmployeeWageProblem.EmpWageBuilderObject DMart = new EmployeeWageProblem.EmpWageBuilderObject("DMart", 20, 2, 10);
            EmployeeWageProblem.EmpWageBuilderObject BigBazar = new EmployeeWageProblem.EmpWageBuilderObject("BigBazar", 10, 4, 20);
            DMart.Attendance(); 
            Console.WriteLine(DMart.Result());
            BigBazar.Attendance();
            Console.WriteLine(BigBazar.Result());
            Console.ReadKey();
        }
    }
}
