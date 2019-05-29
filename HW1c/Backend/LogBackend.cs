using System;
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
            myData.LogList.Add(new LogModel { AppVersion = "1",PhoneID = "ABC",RecordedDateTime = DateTime.Now,Location = "Clinic A" ,TestValue = "15",LabValue = "20",Accuracy="Y", DeviationRate ="5%"});
            myData.LogList.Add(new LogModel { AppVersion = "2", PhoneID = "MNO", RecordedDateTime = DateTime.Parse("01/23/2019"),Location = "Clinic B", TestValue = "15", LabValue = "20", Accuracy = "Y", DeviationRate = "5%" });
            myData.LogList.Add(new LogModel { AppVersion = "3", PhoneID = "ZYX", RecordedDateTime = DateTime.Now.AddDays(-2), Location = "Clinic B", TestValue = "15", LabValue = "20", Accuracy = "Y", DeviationRate = "5%" });
            myData.LogList.Add(new LogModel { AppVersion = "3.3", PhoneID = "ZYXa", RecordedDateTime = DateTime.Now.AddYears(-1), Location = "Clinic D", TestValue = "15", LabValue = "20", Accuracy = "Y", DeviationRate = "5%" });
            myData.LogList.Add(new LogModel { AppVersion = "2", PhoneID = "EEE", RecordedDateTime = DateTime.Now, Location = "Clinic C", TestValue = "15", LabValue = "20", Accuracy = "Y", DeviationRate = "5%" });
            myData.LogList.Add(new LogModel { AppVersion = "2.3", PhoneID = "MQD", RecordedDateTime = DateTime.Parse("01/29/2019"), Location = "Clinic B", TestValue = "15", LabValue = "20", Accuracy = "Y", DeviationRate = "5%" });
            myData.LogList.Add(new LogModel { AppVersion = "3", PhoneID = "ZX", RecordedDateTime = DateTime.Now.AddDays(-3), Location = "Clinic C", TestValue = "15", LabValue = "20", Accuracy = "Y", DeviationRate = "5%" });
            myData.LogList.Add(new LogModel { AppVersion = "3.3", PhoneID = "Ya", RecordedDateTime = DateTime.Now.AddYears(-2), Location = "Clinic D", TestValue = "15", LabValue = "20", Accuracy = "Y", DeviationRate = "5%" });
            myData.LogList.Add(new LogModel { AppVersion = "3.3", PhoneID = "Ya", RecordedDateTime = DateTime.Now.AddYears(-2), Location = "Clinic D", TestValue =  "15", LabValue = "20", Accuracy = "Y", DeviationRate = "5%" });

            return myData;
        }

    }
}