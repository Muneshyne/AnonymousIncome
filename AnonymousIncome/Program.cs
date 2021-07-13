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
            //person1
            Console.WriteLine("Person1");
            Console.ReadLine();
            // hour rate
            Console.WriteLine("What is the hourly rate?");
            string hourlyRate = Console.ReadLine();
            int rate = Convert.ToInt32(hourlyRate);
            Console.WriteLine("Hourly Rate: " + hourlyRate);
            Console.ReadLine();
            // hours worked
            Console.WriteLine("How many hours worked this week?");
            string hoursWorked = Console.ReadLine();
            int hours = Convert.ToInt32(hoursWorked);
            Console.WriteLine("Hours worked this week: " + hours);
            Console.ReadLine();
            int weekly = rate * 40;
            int annual = weekly * 52;
            Console.WriteLine("Annual Salary: " + annual);
            Console.ReadLine();


            // Person2 start
            Console.WriteLine("Person2");
            Console.ReadLine();
            //hourly rate
            Console.WriteLine("What is the hourly rate?");
            string hourRate = Console.ReadLine();
            int hRate = Convert.ToInt32(hourRate);
            Console.WriteLine("Hourly Rate: " + hourRate);
            Console.ReadLine();
            // hours worked
            Console.WriteLine("How many hours worked this week?");
            string hourWorked = Console.ReadLine();
            int hWorked = Convert.ToInt32(hourWorked);
            Console.WriteLine("Hours worked this week: " + hWorked);
            Console.ReadLine();
            // times salary for 52 weeks
            int weeklySalary = hRate * 40;
            int annualSalary = weeklySalary * 52;
            Console.WriteLine("Annual Salary: " + annualSalary);
            Console.ReadLine();

            //boolean for Persons
            bool compare = annual > annualSalary;
            Console.WriteLine("Is Person1 Annual income more than Person2? " + compare.ToString());
            Console.ReadLine();
        }
    }
}
