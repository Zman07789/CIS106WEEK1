//By Zackary Paulson
using System;

namespace CIS106WEEK1
{
    public class Employee
    {
        //Here i'm adding properties of the Employee Class
        public string Name { get; set; }
        public Guid EmployeeId { get; private set; }

        //Here i'm constructing the class
        public Employee()
        {
            EmployeeId = Guid.NewGuid();
        }
    }
}
