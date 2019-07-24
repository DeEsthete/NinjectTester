using NinjectTester.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NinjectTester.Controllers
{
    public class HomeController : Controller
    {
        private ISender sender;

        public HomeController(ISender sender)
        {
            this.sender = sender;
        }

        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Message = sender.Send("Сообщение");
            return View();
        }
    }
}