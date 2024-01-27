/*You will be setting up your local development environment and creating a simple .NET console project 
to confirm a basic understanding of data types and classes, as well as confirm you can use the .Net CLI and 
VS Code Integrated Development Environment.

Setup your local dev environment.

Create a new console project.

dotnet new console -n CIS106WEEK1
Create two classes which contain a unique ID, and at least one other field.

These can be anything you want! An example could be an Employee class and a Task class.

Create getters and setters for your fields, whether implicitly or through {get; set;}.

Instantiate both classes and their fields as needed.

Write the objects/their fields to the console.

Change the val ues of their fields in some way and rewrite them to the console.
When completed, upload your program.cs file and both of your class files. 
*/

//By Zackary Paulson
using System;

namespace CIS106WEEK1
{
    class Program 
    {
        static void Main()
        {
            Employee employee = new Employee();
            employee.Name = "John Cena";

            Task task = new Task();
            task.TablesToClean = 7;

            Console.WriteLine($"Employee ID: {employee.EmployeeId}, Name: {employee.Name}");
            Console.WriteLine($"Task Tables to clean: {task.TablesToClean}");

            // Here I'm modifying the values for employee.name and TablesToClean
            employee.Name = "You can't see me";
            task.TablesToClean = 100;

            Console.WriteLine($"Employee ID: {employee.EmployeeId}, Name: {employee.Name}");
            Console.WriteLine($"Task Tables to clean: {task.TablesToClean}");
        }
    }
}
