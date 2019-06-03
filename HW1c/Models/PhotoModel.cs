using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HW1c.Models
{
    public class PhotoModel
    {     
        // Photo ID string
        public string PhotoID { get; set; } = Guid.NewGuid().ToString();

        // The Value Sent by the Phone, as a string
        public string Value { get; set; }

        // Location
        public string Location { get; set; }

        // Recorded Date Time at the Server
        public DateTime RecordedDateTime { get; set; } = new DateTime();

        // User ID of photo taken
        public string UserID { get; set; }

        // ID of the Phone as a quid
        public string PhoneID { get; set; }

        // App Version string
        public string AppVersion { get; set; }

        // Name of the picture for the photo
        public string PhotoFile { get; set; }

        // Photo status of pass or failed to pass
        public string PhotoStatus { get; set; }

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