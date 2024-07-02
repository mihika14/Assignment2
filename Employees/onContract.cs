using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    internal class onContract : employees
    {
        string contractDate;
        int duration;
        float charges;

        public override void getDetails()
        {
            base.getDetails();
            Console.WriteLine("Enter Contract Date:");
            contractDate = Console.ReadLine();
            Console.WriteLine("Enter Contract Duration (in months):");
            duration = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Charges Per Day:");
            charges = float.Parse(Console.ReadLine());
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"contract date: {contractDate} , Duration in months: {duration}, Charges per Day: {charges} ");
        }
    }
}
