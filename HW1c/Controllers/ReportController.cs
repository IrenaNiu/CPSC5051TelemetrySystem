using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HW1c.Models;
using HW1c.Backend;

namespace HW1c.Controllers
{
    public class ReportController : Controller
    {
        // GET: Index
        public ActionResult Index()
        {
            ViewBag.LeftNavType = "Report";
            var myViewModel = new ReportViewModel();

            myViewModel.LogViewModel = new LogBackend().Index();
            myViewModel.NumberOfUsers = 3;

            return View(myViewModel);
        }

        // GET: Test Accuracy Report
        public ActionResult Accuracy()
        {
            ViewBag.LeftNavType = "Report";
            var myViewModel = new ReportViewModel();

            myViewModel.LogViewModel = new LogBackend().Index();
            myViewModel.NumberOfTests = 30;
            myViewModel.Accuracy = 0.85;

            return View(myViewModel);
        }

        // GET: More Detail Report
        public ActionResult MoreDetail()
        {
            ViewBag.LeftNavType = "Report";
            var myViewModel = new ReportViewModel();

            myViewModel.LogViewModel = new LogBackend().Index();
            myViewModel.NumberOfUsers = 3;

            return View(myViewModel);
        }

        public ActionResult ViewTry()
        {
            ViewBag.LeftNavType = "Report";
            return View();
        }
    }
}