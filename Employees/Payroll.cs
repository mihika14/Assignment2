using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    internal class Payroll: employees
    {
        string JoiningDate;
        int exp;
        float BasicSalary;
        float Da;
        float Hra;
        int pf;
        float NetSalary;

        public override void getDetails()
        {
            base.getDetails();
            Console.WriteLine("Enter joining Date");
            JoiningDate = Console.ReadLine();
            Console.WriteLine("Enter experience");
            exp = int.Parse( Console.ReadLine());
            Console.WriteLine("Enter basic saraly");
            BasicSalary = float.Parse(Console.ReadLine());
            salary();
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Joining Date: {JoiningDate}");
            Console.WriteLine($"Experience: {exp} years");
            Console.WriteLine($"Basic Salary: {BasicSalary}");
            Console.WriteLine($"DA: {Da}");
            Console.WriteLine($"HRA: {Hra}");
            Console.WriteLine($"PF: {pf}");
            Console.WriteLine($"Net Salary: {NetSalary}");

        }

        public void salary()
        {
            if(exp > 10)
            {
                Da = 0.1f * BasicSalary;
                Hra = 0.085f * BasicSalary;
                pf = 6200;
            }
            else if(exp > 7)
            {
                Da = 0.07f * BasicSalary;
                Hra = 0.065f * BasicSalary;
                pf = 4100;
            }
            else if (exp > 5)
            {
                Da = 0.041f * BasicSalary;
                Hra = 0.038f * BasicSalary;
                pf = 1800;
            }
            else 
            {
                Da = 0.019f * BasicSalary;
                Hra = 0.02f * BasicSalary;
                pf = 1200;
            }
            NetSalary = BasicSalary + Da + Hra - pf;
        }
    }
}
