using System;
using System.Collections.Generic;
using System.Linq;


public class StartUp
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<Employee> employees = new List<Employee>();
        for (int i = 0; i < n; i++)
        {
            string[] inputLine = Console.ReadLine().Split();
            string name = inputLine[0];
            decimal salary = decimal.Parse(inputLine[1]);
            string position = inputLine[2];
            string department = inputLine[3];

            Employee employee = new Employee(name, salary, position, department);

            if (inputLine.Length == 5)
            {
                string ageOrEmail = inputLine[4];
                int age;
                bool isNumber = int.TryParse(ageOrEmail, out age);
                if (isNumber)
                {
                    employee.age = age;
                }
                else
                {
                    employee.email = ageOrEmail;
                }
            }
            if (inputLine.Length > 5)
            {
                string email = inputLine[4];
                int age = int.Parse(inputLine[5]);
                employee.age = age;
                employee.email = email;
            }
            employees.Add(employee);
        }

        var result = employees
            .GroupBy(e => e.department)
            .Select(e => new
            {
                DepartmentName = e.Key,
                AverageSalary = e.Average(c => c.salary),
                Employees = e.OrderByDescending(emp => emp.salary)
            })
            .OrderByDescending(d => d.AverageSalary)
            .FirstOrDefault();

        Console.WriteLine($"Highest Average Salary: {result.DepartmentName}");
        foreach (var res in result.Employees)
        {
            Console.WriteLine($"{res.name} {res.salary:f2} {res.email} {res.age}");
        }

    }
}
