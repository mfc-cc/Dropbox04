using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Dropbox04.Models;
using Dropbox04.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Dropbox04.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: /<controller>/
        static List<Employee> allEmployee = new List<Employee>();
        List<Department> allDepartment = new List<Department>
    {
        new Department(){DepartmentId = 1, DepartmentName = "Accounting"},
        new Department(){DepartmentId = 2, DepartmentName = "Information Technology"},
        new Department(){DepartmentId = 3, DepartmentName = "Marketing"},
    };
        public IActionResult AllEmployee()
        {
            return View(allEmployee);
        }
        public IActionResult AddEmployee()
        {
            var departmentDisplay = allDepartment.Select
                (x => new { Id = x.DepartmentId, Value = x.DepartmentName });
            EmployeeAllEmployeeViewModel vm = new EmployeeAllEmployeeViewModel();
            vm.DepartmentList = new SelectList(departmentDisplay, "Id", "Value");
            return View(vm);
        }
        [HttpPost]
        public IActionResult AddEmployee(EmployeeAllEmployeeViewModel vm)
        {
            var department =
                allDepartment.SingleOrDefault(m => m.DepartmentId == vm.Department.DepartmentId);
            vm.Employee.Department = department;
            allEmployee.Add(vm.Employee);
            return RedirectToAction("AllEmployee");
        }
    }
}

