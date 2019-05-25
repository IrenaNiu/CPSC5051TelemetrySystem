using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HW1c.Backend
{
    public class PhotoRepoMock : Controller
    {
        // GET: PhotoRepoMock
        public ActionResult Index()
        {
            return View();
        }
    }
}