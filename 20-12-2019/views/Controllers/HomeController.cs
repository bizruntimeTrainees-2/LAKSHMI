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
        private IEmployeeRepository _employeeRepository;

        public HomeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;

        }

        public IActionResult Index()
        {
            return View("Views/Home/Index.cshtml");
           
        }

       
        [Route("Home/Details/{id}")]
        public ViewResult Details(int id)
        {

            Employee model = _employeeRepository.GetEmployee(id);

            //return View("views1/Home/Index.cshtml");
            //return View(model); //this line is for Details.cshtml
            //return View("MyViews/Test.cshtml");
            //return View("../Test/Update");



            // ViewData["Employee"] = model;
            // ViewData["PageTitle"] = "Employee Details";
            // return View();
            ViewBag.Employee = model;
            ViewBag.PageTitle = "EmployeeDetails";
            return View();
        }
        public ViewResult IDetails1()
        {
            Employee model = _employeeRepository.GetEmployee(1);
            ViewBag.PageTitle = "Employee Details";
            return View(model);

           
        }
        public ViewResult HomeDetails()
        {
           

            HomeDetailsviewmodels homedetailsviewmodels = new HomeDetailsviewmodels()
            {
                Employee = _employeeRepository.GetEmployee(1),
                 PageTitle = "Employee Details"
                };
            return View(homedetailsviewmodels);
        
        }
        [Route("")]
        [Route("Home")]
        [Route("Home/Index1)")]

        public ViewResult Index1()
        {
            var model = _employeeRepository.GetAllEmployee();
            return View(model);
        }

        public ViewResult Index2()
        {
            var model = _employeeRepository.GetAllEmployee();
            return View(model);
        }

        public ViewResult Details2(int id)
        {


            HomeDetailsviewmodels homedetailsviewmodels = new HomeDetailsviewmodels()
            {
                Employee = _employeeRepository.GetEmployee(id),
                PageTitle = "Employee Details"
            };
            return View(homedetailsviewmodels);

        }






    }
}
