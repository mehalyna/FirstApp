using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstApp.Models
{
    public class Departs
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public string Address { get; set; }
        
        public int EmployeeId { get; set; } 
        public Employee Employee { get; set; }
    }
}
