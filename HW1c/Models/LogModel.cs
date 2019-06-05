using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HW1c.Models
{
    public class LogModel
    {
        // The user id
        public string UserID { get; set; }

        // The Value Sent by the Phone, as a string
        public string Value { get; set; }

        // Recorded Date Time at the Server
        public DateTime RecordedDateTime { get; set; } = DateTime.Now;

        // ID of the Phone as a quid
        public string PhoneID { get; set; }

        // App Version string
        public string AppVersion { get; set; }

        // Location
        public string Location { get; set; }

        public string TestValue { get; set; }
        public string LabValue { get; set; }
        public string Accuracy { get; set; }
        public string DeviationRate { get; set; }

        // Name of the picture for the phone type
        public string PhoneFile { get; set; }

        /// <summary>
        /// Constructor for Log Model
        /// Calls to Initialize to set initial settings
        /// </summary>
        public LogModel()
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