using Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly IExampleService _exampleService;

        public HomeController(IExampleService exampleService)
        {
            this._exampleService = exampleService;
        }

        public ActionResult Index()
        {
            ViewData["ExampleList"] = this._exampleService.GetAll();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}