using System;
using System.Collections.Generic;

namespace Classes
{
    public class Program
    {
        static void Main(string[] args)

        {


            Company company = new Company();

            Employee employee = new Employee
            {
                FirstName = "Vishal",
                LastName = "Trivedi",
                Title = "Software EngineerI",

            };
            Employee employee2 = new Employee
            {
                FirstName = "Chris",
                LastName = "Larson",
                Title = "Software EngineerII",
            };
            Employee employee3 = new Employee
            {
                FirstName = "Alex",
                LastName = "Triveck",
                Title = "Software Engineer",
            };
            List<Employee> ListEmployees = new List<Employee>();
            ListEmployees.Add(employee);
            ListEmployees.Add(employee2);
            ListEmployees.Add(employee3);

            company.Employees = ListEmployees;

            company.ListEmployees();

            Company company2 = new Company();


        }

    }
}



// ln 43: Create a new Company of Company type, given a "company2" name and setting it 
//  equal to new Company construct

// create a company ln 16
// Create three employees

// Assign the employees to the company

/*
    Iterate the company's employee list and generate the
    simple report shown above
*/

