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
            ViewBag.TopNavType = "Report";
            var myViewModel = new ReportViewModel();

            myViewModel.LogViewModel = new LogBackend().Index();
            myViewModel.NumberOfUsers = 3;


            myViewModel.UserCategoryList = new List<UserCategoryCountModel>();
            myViewModel.UserCategoryList.Add(new UserCategoryCountModel { Clinic = "Clinic A", UserNumber = 113 });
            myViewModel.UserCategoryList.Add(new UserCategoryCountModel { Clinic = "Clinic B", UserNumber = 81 });
            myViewModel.UserCategoryList.Add(new UserCategoryCountModel { Clinic = "Clinic C", UserNumber = 46 });
            myViewModel.UserCategoryList.Add(new UserCategoryCountModel { Clinic = "Clinic D", UserNumber = 150 });


            return View(myViewModel);
        }

        // GET: Test Accuracy Report
        public ActionResult Accuracy()
        {
            ViewBag.TopNavType = "Report";
            var myViewModel = new ReportViewModel();

            myViewModel.LogViewModel = new LogBackend().Index();
            myViewModel.NumberOfTests = 30;
            myViewModel.Accuracy = 0.85;

            return View(myViewModel);
        }

        // GET: More Detail Report
        public ActionResult MoreDetail()
        {
            ViewBag.TopNavType = "Report";
            var myViewModel = new ReportViewModel();

            myViewModel.LogViewModel = new LogBackend().Index();
            myViewModel.NumberOfUsers = 3;

            return View(myViewModel);
        }

        public ActionResult ViewTry()
        {
            ViewBag.TopNavType = "Report";
            return View();
        }
    }
}