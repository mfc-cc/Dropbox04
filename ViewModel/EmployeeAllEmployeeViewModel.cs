using Dropbox04.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Dropbox04.ViewModels
{
    public class EmployeeAllEmployeeViewModel
    {
        public Employee Employee { get; set; }
        public Department Department { get; set; }
        public SelectList DepartmentList { get; set; }
    }
}