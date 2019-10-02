﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebStore.Infrastructure.Interfaces;
using WebStore.ViewModels;

namespace WebStore.Controllers
{
   // [Route ("users")]
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            
            _employeeService = employeeService;
        }
        
        // GET: Home
       // [Route("all")]
        public ActionResult Index()
        {
            // return Content("My first CONTROLLER");
            return View(_employeeService.GetAll());
        }
        //[Route ("{id}")]
        public ActionResult Details(int id)
        {
            // return Content("My first CONTROLLER");
            return View(_employeeService.GetById(id));
        }
        [HttpGet]
        [Route ("edit/{id?}")]
        public IActionResult Edit(int? id)
        {
            if (!id.HasValue) return View(new EmployeeView());
            EmployeeView model = _employeeService.GetById(id.Value);
            if (model == null) return NotFound();

            return View(model);

        }
        [HttpPost]
        [Route("edit/{id?}")]
        public IActionResult Edit(EmployeeView model)
        {
            if (model.Age < 18 || model.Age > 100)
            { ModelState.AddModelError("Age", "Минимальный возраст 18 лет"); }
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if (model.Id>0)
            {
                var dbItem = _employeeService.GetById(model.Id);
                if (ReferenceEquals(dbItem, null)) { return NotFound(); }

                dbItem.FirstName = model.FirstName;
                dbItem.LastName = model.LastName;
                dbItem.Patronymic = model.Patronymic;
                dbItem.Age = model.Age;
            }
            else
            {
                _employeeService.AddNew(model);
            }
            _employeeService.Commit();
            return RedirectToAction(nameof(Index));
        }
        [Route("delete/{id}")]
        public IActionResult Delete(int id)
        {
            _employeeService.Delete(id);
            return RedirectToAction("Index");
        }
        };  
}