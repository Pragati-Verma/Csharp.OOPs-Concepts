using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckingExecution
{
    public class Car
    {
        private string _make;
        private string? _model;
        private int _year;
        public Car()
        {
            Make = "";
            Model = "";
            Year = 0;
        }
        public Car(string make, string model,int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }
        public string Make
        {
            get
            {
                return _make;
            }
            set
            {
                _make = value;
            }
        }
        public string Model { get; set; }
        public int Year { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"Make: {Make}\nModel: {Model}\nYear: {Year}");
        }
    }
}
