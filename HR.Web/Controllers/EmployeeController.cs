using HR.DataModel.DAL;
using HR.DataModel.Entities;
using HR.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HR.Web.Controllers
{
    public class EmployeeController : Controller
    {
        private IHRRepository hrRepository;

        public EmployeeController(IHRRepository repository)
        {
            hrRepository = repository;
        }

        // GET: Employee
        public ActionResult Index()
        {
            List<Employee> employees = hrRepository.GetAllEmployees().ToList();
            return View(employees);
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            EmployeeView model = new EmployeeView
                {
                    Employee = new Employee(),
                    Departments = hrRepository.GetAllDepartments().ToList()
                };
            return View(model);
        }

        // POST: Employee/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EmployeeView model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    hrRepository.AddEmployee(model.Employee);
                    return RedirectToAction("Index");
                }
                else
                {
                    return View();
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            EmployeeView model = new EmployeeView
            {
                Employee = hrRepository.GetEmployee(id),
                Departments = hrRepository.GetAllDepartments().ToList()
            };
            return View(model);
        }

        // POST: Employee/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EmployeeView model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    hrRepository.UpdateEmployee(model.Employee);
                    return RedirectToAction("Index");
                }
                else
                {
                    return View();
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {
            Employee theEmployee = hrRepository.GetEmployee(id);
            return View(theEmployee);
        }

        // POST: Employee/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Employee employee)
        {
            try
            {
                hrRepository.DeleteEmployee(employee);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
