using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using views.Models;
using views.Viewmodels;

namespace views.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;

        public HomeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;

        }
        [Route("")]
        [Route("Home")]
        [Route("Home/Index")]
        public ViewResult Index()
        {
            var model = _employeeRepository.GetAllEmployee();
            return View(model);
            //return _employeeRepository.GetEmployee(1).Name;
        }
       
      [Route("Home/Details")]
        public ViewResult Details(int id)
        {

            // Employee model = _employeeRepository.GetEmployee(1);


            // ViewData["Employee"] = model;
            //ViewData["PageTitle"] = "Employee Details";
            //return View();

            /*
             Employee model = _employeeRepository.GetEmployee(1);

             ViewBag.Employee = model;
              ViewBag.PageTitle = "EmployeeDetails";
             return View();
           */
            //Employee model = _employeeRepository.GetEmployee(1);

            //  ViewBag.PageTitle = "EmployeeDetails";
            // return View(model); //this is for strongly typed

            HomeDetailsviewmodels homeDetailsviewmodel = new HomeDetailsviewmodels()
            {
                Employee = _employeeRepository.GetEmployee(1),
                //for putting id optional, then getEmployee(1) we wrote in place of id
                PageTitle = "Employee Details"
            };
            return View(homeDetailsviewmodel);

    }


}
}
