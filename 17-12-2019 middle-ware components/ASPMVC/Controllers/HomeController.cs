using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPMVC.Controllers
{
    /*
    public class HomeController
    {
        public string Index()
        {
            return "Hello From MVC";
        }
    }
    */
    public class HomeController : Controller
    {
        public JsonResult Index()
        {
            return Json(new { id = 1, name = "LAKSHMI" });
        }
    }
}
