using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();
            Console.WriteLine("Person1");
            Console.ReadLine();
            int hourlyRate = 15;
            Console.WriteLine("Hourly Rate: " + hourlyRate);
            Console.ReadLine();
            int hoursWorked = 40;
            Console.WriteLine("Hours worked this week: " + hoursWorked);
            Console.ReadLine();
            int weekly = hourlyRate * 40;
            int annual = weekly * 52;
            Console.WriteLine("Annual Salary: " + annual);
            Console.ReadLine();

            Console.WriteLine("Person2");
            Console.ReadLine();
            int hourRate = 20;
            Console.WriteLine("Hourly Rate: " + hourRate);
            Console.ReadLine();
            int hourWorked = 40;
            Console.WriteLine("Hours worked this week: " + hourWorked);
            Console.ReadLine();
            int weeklySalary = hourRate * 40;
            int annualSalary = weeklySalary * 52;
            Console.WriteLine("Annual Salary: " + annualSalary);
            Console.ReadLine();

            bool compare = annual > annualSalary;
            Console.WriteLine("Is Person1 Annual income more than Person2? " + compare.ToString());
            Console.ReadLine();
        }
    }
}
