using ASPmodel.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPmodel1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ModelRepository _modelRepository;

        public HomeController(ModelRepository modelRepository)
        {
            _modelRepository = modelRepository;
        }
        public string Index()
        {
            return _modelRepository.GetModels(1).Name;
        }
       
          public JsonResult Details()
          {
              Models model = _modelRepository.GetModels(1);
              return Json(model);

               //for getting json data in the browser, (localhost:   \home\Details)

          }
         
        
    }
}
