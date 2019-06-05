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
            ViewBag.TopNavType = "Admin";
            var myViewModel = new ReportViewModel();

            myViewModel.LogViewModel = LogBackend.Instance.Index();


            myViewModel.UserCategoryList = new List<UserCategoryCountModel>();
            myViewModel.UserCategoryList.Add(new UserCategoryCountModel { Clinic = "Clinic A", UserNumber = 7 });
            myViewModel.UserCategoryList.Add(new UserCategoryCountModel { Clinic = "Clinic B", UserNumber = 15 });
            myViewModel.UserCategoryList.Add(new UserCategoryCountModel { Clinic = "Clinic C", UserNumber = 3 });
            myViewModel.UserCategoryList.Add(new UserCategoryCountModel { Clinic = "Clinic D", UserNumber = 12 });


            return View(myViewModel);
        }

        public ActionResult ReadPhone(string id = null)
        {
            ViewBag.TopNavType = "Admin";
            // If no ID passed in, jump to the Index page
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            var myData = LogBackend.Instance.Read(id);
            return View(myData);
        }

        // GET: Test Accuracy Report
        public ActionResult Accuracy()
        {
            ViewBag.TopNavType = "Admin";
            var myViewModel = new ReportViewModel();

            myViewModel.LogViewModel = LogBackend.Instance.Index();

            return View(myViewModel);
        }

        // GET: More Detail Report
        public ActionResult MoreDetail()
        {
            ViewBag.TopNavType = "Admin";
            var myViewModel = new ReportViewModel();

            return View(myViewModel);
        }
    }
}