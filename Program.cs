//{ Driver Code Starts
// Initial Template for C#

using CheckingExecution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriverCode
{

    class Program
    {
        static void Main(string[] args)
        {
            /*
            Car car = new Car("Chevrolet", "Equinox", 2024);
            car.DisplayInfo();
            Console.WriteLine();
            Car car2 = new Car();
            car2.Make = "Mahindra";
            car2.Model = "Thar";
            car2.Year = 2010;
            car2.DisplayInfo();
            */
            

            /*
            List<Employee> employees = new List<Employee>
            {
                new Manager("Alice", 90000),
                new Developer("Bob", 80000),
                new Developer("Charlie", 85000),
                new Employee("Eve", 70000)
            };

            foreach (var emp in employees)
            {
                emp.DisplayInfo();
            }
            */

            List<IEmployee> employees = new List<IEmployee>()
            {
                new FullTimeEmployee("Pragati Verma",65000),
                new ContractEmployee("ABC",6,2500),
                new ContractEmployee("XYZ",8,3000),
                new FullTimeEmployee("Verma",80000)
            };

            foreach(var emp in employees)
            {
                emp.Payslip();
            }

            Console.WriteLine();

            var salaries = employees.Where(e => e.CalculatePay() <= 10000);
            foreach (var emp in salaries)
            {
                Console.WriteLine($"{emp.Name} - {emp.CalculatePay()}");
            }
            Console.WriteLine();
            var groupEmployees = employees.GroupBy(emp => emp.Type);
            foreach (var emp in groupEmployees)
            {
                Console.WriteLine(emp.Key);
                foreach (var employee in emp)
                {
                    Console.WriteLine($"{employee.Name}");
                }
            }
        }
    }
}