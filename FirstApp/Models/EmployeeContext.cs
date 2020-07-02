using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstApp.Models
{
    public class EmployeeContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Departs> Departs { get; set; }

        public EmployeeContext(DbContextOptions<EmployeeContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
