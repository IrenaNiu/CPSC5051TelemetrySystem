using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HW1c.Models
{
    public class PhotoModel
    {
        public DateTime RecordedDateTime { get; set; } = new DateTime();

        // ID of the Phone as a quid
        public string PhoneID { get; set; }

        // App Version string
        public string PhotoID { get; set; }

        // Location
        public string Location { get; set; }

        public PhotoModel()
        {
            Initialize();
        }

        /// <summary>
        /// Intialize
        /// Sets default values, such as DateTime as needed by the system
        /// </summary>
        public void Initialize()
        {
            // None right now...
        }
    }
}