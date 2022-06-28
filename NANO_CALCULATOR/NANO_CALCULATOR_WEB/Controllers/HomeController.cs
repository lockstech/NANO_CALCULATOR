using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NANO_CALCULATOR;

namespace NANO_CALCULATOR_WEB.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Operation = new SelectListItem[]
            {
                new SelectListItem() { Value = "1", Text ="sum"},
                new SelectListItem() { Value = "2", Text ="minus" },
                new SelectListItem() { Value = "3", Text ="multiply" },
                new SelectListItem() { Value = "4", Text ="division" },
                new SelectListItem() { Value = "5", Text ="sin" },
                new SelectListItem() { Value = "6", Text ="cos" },
                new SelectListItem() { Value = "7", Text ="ln" }
            };
            return View();
        }
        [HttpPost]
        public ActionResult Index(
            int op,
            double firstNumber,
            double secondNumber)
        {
            Form1 res = new Form1();
            string result = res.calculate(op, firstNumber, secondNumber);
            ViewBag.Result = result;
            ViewBag.Operation = new SelectListItem[]
            {
 new SelectListItem() { Value = "1", Text ="sum" },
 new SelectListItem() { Value = "2", Text ="minus" },
 new SelectListItem() { Value = "3", Text ="multiply" },
 new SelectListItem() { Value = "4", Text ="division" },
 new SelectListItem() { Value = "5", Text ="sin" },
 new SelectListItem() { Value = "6", Text ="cos" },
 new SelectListItem() { Value = "7", Text ="ln" }
            };
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