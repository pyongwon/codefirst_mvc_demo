using HR.DataModel.DAL;
using HR.DataModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HR.Web.Controllers
{
    public class DepartmentController : Controller
    {
        private IHRRepository hrRepository;

        public DepartmentController(IHRRepository repository)
        {
            hrRepository = repository;
        }

        // GET: Department
        public ActionResult Index()
        {
            List<Department> departments = hrRepository.GetAllDepartments().ToList();
            return View(departments);
        }

        // GET: Department/Create
        public ActionResult Create()
        {
            Department newDepartment = new Department();
            return View(newDepartment);
        }

        // POST: Department/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Department department)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    hrRepository.AddDepartment(department);
                    return RedirectToAction("Index"); // redirect to the list
                }
                else
                {
                    return View(); // redirect to current and show the validation errors
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: Department/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Department/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Department/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Department/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
