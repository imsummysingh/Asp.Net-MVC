﻿using System;
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

        [HttpGet]
        public ActionResult Edit(int id)
        {
            EmployeeBusinessLayer employeeBusinessLayer =  new EmployeeBusinessLayer();
            Employee employee = employeeBusinessLayer.Employees.Single(emp => emp.ID == id);

            return View(employee);
        }

        //[HttpPost]
        //public ActionResult Edit(Employee employee)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        EmployeeBusinessLayer employeeBusinessLayer =
        //            new EmployeeBusinessLayer();
        //        employeeBusinessLayer.SaveEmmployee(employee);

        //        return RedirectToAction("Index");
        //    }
        //    return View(employee);
        //}

        //[HttpPost]
        //[ActionName("Edit")]
        //public ActionResult Edit_Post(int id)
        //{
        //    EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
        //    Employee employee = employeeBusinessLayer.Employees.Single(x => x.ID == id);

        //    //include property
        //    //UpdateModel(employee, null, null, new string[] { "Name" });
        //    UpdateModel(employee, new string[] { "ID", "Gender", "City", "DateOfBirth" });

        //    if (ModelState.IsValid)
        //    {
        //        employeeBusinessLayer.SaveEmmployee(employee);

        //        return RedirectToAction("Index");
        //    }

        //    return View(employee);
        //}


        //[HttpPost]
        //[ActionName("Edit")]
        //public ActionResult Edit_Post([Bind(Exclude = "Name")] Employee employee)
        //{
        //    EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
        //    employee.Name = employeeBusinessLayer.Employees.Single(x => x.ID == employee.ID).Name;

        //    if (ModelState.IsValid)
        //    {
        //        employeeBusinessLayer.SaveEmmployee(employee);

        //        return RedirectToAction("Index");
        //    }
        //    return View(employee);
        //}

        //OR

        //[HttpPost]
        //[ActionName("Edit")]
        //public ActionResult Edit_Post([Bind(Include = "Id, Gender, City, DateOfBirth")] Employee employee)
        //{
        //    EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
        //    employee.Name = employeeBusinessLayer.Employees.Single(x => x.ID == employee.ID).Name;

        //    if (ModelState.IsValid)
        //    {
        //        employeeBusinessLayer.SaveEmmployee(employee);

        //        return RedirectToAction("Index");
        //    }
        //    return View(employee);
        //}

        //Include and exclude properties using interface

        [HttpPost]
        [ActionName("Edit")]
        public ActionResult Edit_Post(int id)
        {
            EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
            Employee employee = employeeBusinessLayer.Employees.Single(x => x.ID == id);
            UpdateModel<IEmployee>(employee);

            if (ModelState.IsValid)
            {
                employeeBusinessLayer.SaveEmmployee(employee);
                return RedirectToAction("Index");
            }

            return View(employee);
        }

        //public ActionResult Delete(int id)
        //{
        //    EmployeeBusinessLayer employeeBusinessLayer =
        //        new EmployeeBusinessLayer();
        //    employeeBusinessLayer.DeleteEmployee(id);
        //    return RedirectToAction("Index");
        //}

        [HttpPost]
        public ActionResult Delete(int id)
        {
            EmployeeBusinessLayer employeeBusinessLayer =
                new EmployeeBusinessLayer();
            employeeBusinessLayer.DeleteEmployee(id);
            return RedirectToAction("Index");
        }



    }
}