using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstApp.Models;

namespace FirstApp
{
    public class SampleData
    {
        public static void Initialize(EmployeeContext context)
        {
            if (!context.Employees.Any())
            {
                context.Employees.AddRange(
                    new Employee
                    {
                        FirstName = "Jhon",
                        LastName = "Dou",
                        YearsStuff = 5
                    },
                    new Employee
                    {
                        FirstName = "Martin",
                        LastName = "Green",
                        YearsStuff = 4
                    },
                    new Employee
                    {
                        FirstName = "Ann",
                        LastName = "Grey",
                        YearsStuff = 3
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
