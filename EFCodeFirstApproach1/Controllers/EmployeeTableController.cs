using EFCodeFirstApproach1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EFCodeFirstApproach1.Controllers
{
    public class EmployeeTableController : Controller
    {
        EmployeeTabDbContext db = new EmployeeTabDbContext();
        // GET: EmployeeTable
        [HttpGet]
        public ActionResult Index(string search="")
        {
            //var emps = db.Employees.ToList();
            ViewBag.Search = search;
            var res = db.Employees.Where(e => e.EName.Contains(search)).ToList();
            return View(res);
            //var allemps = db.Employees.ToList();
            //return View(allemps);
        }
        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.Depts = db.Departments.ToList();
            ViewBag.Mang = db.Manager.ToList();

            return View();
        }
        [HttpPost]
        public ActionResult Create(EmployeeTable ee)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Create");
            }
                db.Employees.Add(ee);
                db.SaveChanges();
           
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Details(int id)
        {
            EmployeeTable res = db.Employees.Where(e => e.Id == id).FirstOrDefault();
            return View(res);
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var del = db.Employees.Where(e => e.Id == id).FirstOrDefault();
            return View(del);
        }
        [HttpPost]
        public ActionResult Delete(int id, EmployeeTable employee)
        {
            var del = db.Employees.Where(r => r.Id == id).FirstOrDefault();
            db.Employees.Remove(del);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Update(int id)
        {
            ViewBag.Depts = db.Departments.ToList();
            ViewBag.Mgs = db.Manager.ToList();
            var empUpdate = db.Employees.Where(e => e.Id == id).FirstOrDefault();
            return View(empUpdate);
        }
        [HttpPost]
        public ActionResult Update(EmployeeTable emp)
        {
            var updated = db.Employees.Where(e => e.Id == emp.Id).FirstOrDefault();
            updated.EName = emp.EName;
            updated.ESalary = emp.ESalary;
            updated.DeptId = emp.DeptId;
            updated.MId = emp.MId;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}