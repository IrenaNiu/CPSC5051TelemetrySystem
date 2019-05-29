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
            myData.LogList.Add(new LogModel { AppVersion = "1.0",PhoneID = "AA12CW776",RecordedDateTime = DateTime.Now,Location = "Clinic A" ,TestValue = "15",LabValue = "20",Accuracy="Y", DeviationRate ="5%"});
            myData.LogList.Add(new LogModel { AppVersion = "2.0", PhoneID = "AA13RF854", RecordedDateTime = DateTime.Parse("01/23/2019"),Location = "Clinic B", TestValue = "15", LabValue = "20", Accuracy = "Y", DeviationRate = "5%" });
            myData.LogList.Add(new LogModel { AppVersion = "3.0", PhoneID = "AA16TG096", RecordedDateTime = DateTime.Now.AddDays(-2), Location = "Clinic B", TestValue = "15", LabValue = "20", Accuracy = "Y", DeviationRate = "5%" });
            myData.LogList.Add(new LogModel { AppVersion = "3.3", PhoneID = "AA15TK076", RecordedDateTime = DateTime.Now.AddYears(-1), Location = "Clinic D", TestValue = "15", LabValue = "20", Accuracy = "Y", DeviationRate = "5%" });
            myData.LogList.Add(new LogModel { AppVersion = "2.0", PhoneID = "AA16EG025", RecordedDateTime = DateTime.Now, Location = "Clinic C", TestValue = "15", LabValue = "20", Accuracy = "Y", DeviationRate = "5%" });
            myData.LogList.Add(new LogModel { AppVersion = "2.3", PhoneID = "AA03TB093", RecordedDateTime = DateTime.Parse("01/29/2019"), Location = "Clinic B", TestValue = "15", LabValue = "20", Accuracy = "Y", DeviationRate = "5%" });
            myData.LogList.Add(new LogModel { AppVersion = "3.0", PhoneID = "AA56RU937", RecordedDateTime = DateTime.Now.AddDays(-3), Location = "Clinic C", TestValue = "15", LabValue = "20", Accuracy = "Y", DeviationRate = "5%" });
            myData.LogList.Add(new LogModel { AppVersion = "3.3", PhoneID = "AA76BM405", RecordedDateTime = DateTime.Now.AddYears(-2), Location = "Clinic D", TestValue = "15", LabValue = "20", Accuracy = "Y", DeviationRate = "5%" });
            myData.LogList.Add(new LogModel { AppVersion = "3.3", PhoneID = "AA36TD842", RecordedDateTime = DateTime.Now.AddYears(-2), Location = "Clinic D", TestValue =  "15", LabValue = "20", Accuracy = "Y", DeviationRate = "5%" });

            return myData;
        }

    }
}