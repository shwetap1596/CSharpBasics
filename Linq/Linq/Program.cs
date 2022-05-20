using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> lsEmp = Employee.Create();
            List<Employee> thirdHeighEmp = lsEmp.GroupBy(a => a.salary).OrderByDescending(a => a.Key).Skip(2).First().ToList();
            var emp = lsEmp.GroupBy(a => a.salary).OrderByDescending(a => a.Key).Select(a => a.Count());
        }
        public class Employee
        {
            public int id { get; set; }
            public string name { get; set; }
            public string department { get; set; }
            public decimal salary { get; set; }

            public static List<Employee> Create()
            {
                return new List<Employee>()
                {
                    new Employee() { id = 1, name = "Shweta", department = "Development", salary = 50000 },
                    new Employee() { id = 2, name = "Dhaval", department = "IT", salary = 70000 },
                    new Employee() { id = 3, name = "Abhishek", department = "HR", salary = 75000 },
                    new Employee() { id = 4, name = "Devanshi", department = "QA", salary = 50000 },
                    new Employee() { id = 5, name = "Aman", department = "Development", salary = 100000 }
                };
            }
        }
    }
}
