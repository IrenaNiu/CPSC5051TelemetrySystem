using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HW1c.Models
{
    public class ReportViewModel
    {
        // The List of Logs
        public LogViewModel LogViewModel { get; set; }

        public List<UserCategoryCountModel> UserCategoryList { get; set; }
              

    }
}