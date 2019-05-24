using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HW1c.Models;
namespace HW1c.Backend
{
    public class PhotoBackend
    {
        public PhotoViewModel Index()
        {
            var myData = new PhotoViewModel();

            // TODO:  Populate some Log Data here...
            myData.PhotoList.Add(new PhotoModel { PhotoID = "1", PhoneID = "ABC", RecordedDateTime = DateTime.Now, Location = "Mocc" });
            
            return myData;
        }
    }
}