using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer;

namespace MVCDemo.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
           EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
           List<Employee> employees = employeeBusinessLayer.Employees.ToList();
           return View(employees);
        }

        //[HttpGet]
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public ActionResult Create(FormCollection formCollection)
        //{
        //    Employee employee = new Employee();
        //    // Retrieve form data using form collection
        //    employee.Name = formCollection["Name"];
        //    employee.Gender = formCollection["Gender"];
        //    employee.City = formCollection["City"];
        //    employee.DateOfBirth =
        //        Convert.ToDateTime(formCollection["DateOfBirth"]);

        //    EmployeeBusinessLayer employeeBusinessLayer =
        //        new EmployeeBusinessLayer();

        //    employeeBusinessLayer.AddEmmployee(employee);
        //    return RedirectToAction("Index");
        //}

        //[HttpPost]
        //public ActionResult Create(string name, string gender, string city, DateTime dateOfBirth)
        //{
        //    Employee employee = new Employee();
        //    employee.Name = name;
        //    employee.Gender = gender;
        //    employee.City = city;
        //    employee.DateOfBirth = dateOfBirth;

        //    EmployeeBusinessLayer employeeBusinessLayer =
        //        new EmployeeBusinessLayer();

        //    employeeBusinessLayer.AddEmmployee(employee);
        //    return RedirectToAction("Index");
        //}

        //[HttpPost]
        //public ActionResult Create(Employee employee)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        EmployeeBusinessLayer employeeBusinessLayer =
        //            new EmployeeBusinessLayer();

        //        employeeBusinessLayer.AddEmmployee(employee);
        //        return RedirectToAction("Index");
        //    }
        //    return View();
        //}

        //[HttpPost]
        //throw error
        //public ActionResult Create()
        //{
        //    if (ModelState.IsValid)
        //    {
        //        EmployeeBusinessLayer employeeBusinessLayer =
        //            new EmployeeBusinessLayer();

        //        Employee employee = new Employee();
        //        UpdateModel<Employee>(employee);

        //        employeeBusinessLayer.AddEmmployee(employee);
        //        return RedirectToAction("Index");
        //    }
        //    return View();
        //}

        [HttpGet]
        [ActionName("Create")]
        public ActionResult Create_Get()
        {
            return View();
        }

        //[HttpPost]
        //[ActionName("Create")]
        //public ActionResult Create_Post()
        //{
        //    if (ModelState.IsValid)
        //    {
        //        EmployeeBusinessLayer employeeBusinessLayer =
        //            new EmployeeBusinessLayer();

        //        Employee employee = new Employee();
        //        UpdateModel<Employee>(employee);

        //        employeeBusinessLayer.AddEmmployee(employee);
        //        return RedirectToAction("Index");
        //    }
        //    return View();
        //}

        //[HttpPost]
        //[ActionName("Create")]
        //public ActionResult Create_Post()
        //{
        //    EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
        //    Employee employee = new Employee();
        //    UpdateModel(employee);
        //    if(ModelState.IsValid)
        //    {
        //        employeeBusinessLayer.AddEmmployee(employee);
        //        return RedirectToAction("Index");
        //    }
        //    else
        //    {
        //        return View();
        //    }
        //}

        //[HttpPost]
        //[ActionName("Create")]
        //public ActionResult Create_Post()
        //{
        //    EmployeeBusinessLayer employeeBusinessLayer =
        //        new EmployeeBusinessLayer();

        //    Employee employee = new Employee();
        //    TryUpdateModel(employee);
        //    if (ModelState.IsValid)
        //    {
        //        employeeBusinessLayer.AddEmmployee(employee);
        //        return RedirectToAction("Index");
        //    }
        //    else
        //    {
        //        return View();
        //    }
        //}

        [HttpPost]
        [ActionName("Create")]
        public ActionResult Create_Post(Employee employee)
        {
            EmployeeBusinessLayer employeeBusinessLayer =
                new EmployeeBusinessLayer();

            if (ModelState.IsValid)
            {
                employeeBusinessLayer.AddEmmployee(employee);
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

    }
}