using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dropbox04.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public decimal HourlyWage { get; set; }
        public Department Department { get; set; }
    }
}
