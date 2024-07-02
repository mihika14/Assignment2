using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    internal class employees
    {
        int id;
        string name;
        string manager;

        public virtual void getDetails()
        {
            Console.WriteLine("Enter employee id");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("enter name");
            name = Console.ReadLine();
            Console.WriteLine("ENter manager name");
            manager = Console.ReadLine();
        }

        public virtual void DisplayDetails()
        {
            Console.WriteLine($"id: {id} , name: {name} , manager: {manager}");
        }

        public employees() { }
        public employees(int id , string name , string manager)
        {
            this.id = id;
            this.name = name;
            this.manager = manager;
        }
    }
}
