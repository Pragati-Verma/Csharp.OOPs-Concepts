using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CheckingExecution
{
    public interface IEmployee
    {
        public string Name { get; set; }
        public string Type { get; }
        public double CalculatePay();
        public void Payslip();
    }

    public class FullTimeEmployee : IEmployee
    {
        public string Name { get; set; }
        public string Type { get; }
        double Salary { get; set; }
        public FullTimeEmployee(string name, double salary)
        {
            Name = name;
            Type = "Full-time";
            Salary = salary;
        }
        public double CalculatePay() 
        {
            return Salary * 12;
        }

        void IEmployee.Payslip()
        {
            Console.WriteLine($"{Name}: {CalculatePay():N2}Rs"); 
        }
    }

    public class ContractEmployee : IEmployee
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Hours {  get; set; }
        public double HourlyRate { get; set; }
        public ContractEmployee(string name, int hours, double hourlyRate)
        {
            Name = name;
            Type = "Part-time";
            Hours = hours;
            HourlyRate = hourlyRate;
        }
        public double CalculatePay() 
        {
            return (Hours * HourlyRate) * 0.10;
        }
        void IEmployee.Payslip()
        {
            Console.WriteLine($"{Name}: {CalculatePay()*12:N2}Rs");
        }
    }

}
