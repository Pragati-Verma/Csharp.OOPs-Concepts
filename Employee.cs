using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CheckingExecution
{
    using System;
    using System.Collections.Generic;

    public class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }

        // Virtual method to be overridden
        public virtual double CalculateBonus()
        {
            return Salary * 0.05; // default bonus 5%
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Employee: {Name}, Salary: {Salary}, Bonus: {CalculateBonus()}");
        }
    }

    public class Manager : Employee
    {
        public Manager(string name, double salary)
            : base(name, salary) { }

        public override double CalculateBonus()
        {
            return Salary * 0.10; // 10% bonus for managers
        }
    }

    public class Developer : Employee
    {
        public Developer(string name, double salary)
            : base(name, salary) { }

        public override double CalculateBonus()
        {
            return Salary * 0.08; // 8% bonus for developers
        }
    }
}
