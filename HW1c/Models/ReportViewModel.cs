using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HW1c.Models
{
    public class ReportViewModel
    {
        // The List of Logs
        public LogViewModel LogViewModel { get; set; }

        public List<UserCategoryCountModel> UserCategoryList { get; set; }
        
        // The Number of Users
        public int NumberOfUsers { get; set; }

        // The Number of Compared Tests
        public int NumberOfTests { get; set; }

        // The Accuracy
        public double Accuracy { get; set; }

    }
}