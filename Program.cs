using System;
using SampleApp;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World Updated!");
            Employee employee  = new Employee{Id = 101,Name="Vinod",Salary = 50000.00};
            Console.WriteLine(employee);
        }
    }

