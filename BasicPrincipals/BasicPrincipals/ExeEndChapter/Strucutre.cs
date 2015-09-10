using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicPrincipals.ExeEndChapter
{
     struct employee {
        public string employee_name;
        public float employee_salary;
        public int employee_age;
    }

    class Strucutre
    {
        static void Main(String[] args)
        {
            employee e;

            Console.WriteLine("Enter employee name:");
            e.employee_name = Console.ReadLine();

            Console.WriteLine("\nEnter employee salary:");
            e.employee_salary = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("\nEnter employee age:");
            e.employee_age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("==================================");
            Console.WriteLine("Employee");
            Console.WriteLine("==================================");
            Console.WriteLine(e.employee_name);
            Console.WriteLine(e.employee_salary);
            Console.WriteLine(e.employee_age);
            Console.ReadLine();
        }
    }
}
