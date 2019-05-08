﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HW1c.Models;
namespace HW1c.Backend
{
    public class LogBackend
    {

        /// <summary>
        ///  Returns the List of Logs
        /// </summary>
        /// <returns></returns>
        public LogViewModel Index()
        {
            var myData = new LogViewModel();

            // TODO:  Populate some Log Data here...
            myData.LogList.Add(new LogModel { AppVersion = "1",PhoneID = "ABC" });
            myData.LogList.Add(new LogModel { AppVersion = "2", PhoneID = "MNO" });
            myData.LogList.Add(new LogModel { AppVersion = "3", PhoneID = "ZYX" });

            return myData;
        }

    }
}