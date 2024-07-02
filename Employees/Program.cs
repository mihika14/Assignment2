namespace Employees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<employees> employees = new List<employees>();
            bool continueAdding = true;

            while (continueAdding)
            {
                Console.WriteLine("Select Employee Type: 1. On Contract 2. On Payroll");
                int choice = int.Parse(Console.ReadLine());

                employees emp;
                if (choice == 1)
                {
                    emp = new onContract();
                }
                else
                {
                    emp = new Payroll();
                }

                emp.getDetails();
                emp.DisplayDetails();
                employees.Add(emp);

                Console.WriteLine("Do you want to add another employee? (y/n)");
                string response = Console.ReadLine();
                if (response.ToLower() != "y")
                {
                    continueAdding = false;
                }
            }

            Console.WriteLine("Employee Details:");
            foreach (var emp in employees)
            {
                emp.DisplayDetails();
                Console.WriteLine();
            }

            Console.WriteLine($"Total Number of Employees: {employees.Count}");
        }
    }
}
