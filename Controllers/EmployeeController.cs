using EmployeeManagement.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeManagement.Controllers
{
    public class EmployeeController : Controller

    {
        private EMSContext db;
        
            public EmployeeController(EMSContext _db)

        {
            db = _db;
        }
        
        public ActionResult Index()
        {
           
            var employees = db.Employees.ToList();
            return View(employees);
        }
        public ActionResult Detail(int id)
        {

            var employee = db.Employees.Find(id);
            return View(employee);
        } [HttpGet]
        public ActionResult Add()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult Add(person peerson)
        {
            db.Employees.Add(peerson);
            db.SaveChanges();
            return RedirectToAction(nameof(Index));
        } 
        public ActionResult Edit(int id)
        {
            var employee = db.Employees.Find(id);
            return View(employee);
        }
        [HttpPost]
        public ActionResult Edit(person peerson)
        {
            
            db.Employees.Update(peerson);
            db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public ActionResult Delete(int id)
        {
            var employee = db.Employees.Find(id);
            return View(employee);
        }
        [HttpPost]
        public ActionResult Delete(person peerson)
        {
            
            db.Employees.Remove(peerson);
            db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
    
}
