using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class EmployeeController1 : Controller
    {
        //public ActionResult Details()
        //{
        //    Employee employee = new Employee()
        //    {
        //        EmployeeId = 101,
        //        Name = "John",
        //        Gender = "Male",
        //        City = "London"
        //    };
        //    return View(employee);
        //}
        //public ActionResult Index()
        //{
        //    EmployeeContext employeeContext = new EmployeeContext();
        //    List<Employee> employees = employeeContext.Employees.ToList();

        //    return View(employees);
        //}
        public ActionResult Index(int departmentId)
        {
            EmployeeContext employeeContext = new EmployeeContext();
            List<Employee> employees = employeeContext.Employees.Where(emp => emp.DepartmentId == departmentId).ToList();

            return View(employees);
        }
        public ActionResult Details(int id)
        {
            EmployeeContext employeeContext = new EmployeeContext();
            Employee employee = employeeContext.Employees.Single(x => x.EmployeeId == id);

            return View(employee);
        }
    }
}