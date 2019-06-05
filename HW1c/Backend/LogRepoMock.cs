using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HW1c.Models;

namespace HW1c.Backend
{
    /// <summary>
    /// In Memory Implementation of a Log data store
    /// </summary>
    public class LogRepoMock : IPhoneRepo
    {
        public List<LogModel> dataset = new List<LogModel>();

        /// <summary>
        /// Constructor for Log Repository
        /// </summary>
        public LogRepoMock()
        {
            // Call for Sead data to be created
            Initialize();
        }

        /// <summary>
        /// Return the requested log item from the data store
        /// if not found, return null
        /// </summary>
        /// <param name="id">the item to find</param>
        /// <returns>the item from the datastore, or null</returns>
        public LogModel Read(String id)
        {
            // Get the first instance of the record
            var myData = dataset.First(m => m.PhoneID == id);
            return myData;
        }

        /// <summary>
        /// Return all items in the data store
        /// </summary>
        /// <returns>a list of all the items in the data store</returns>
        public List<LogModel> Index()
        {
            return dataset;
        }

        /// <summary>
        /// Sets Initial Seed Data
        /// </summary>
        public void Initialize()
        {
            dataset.Add(new LogModel { AppVersion = "1.0", PhoneID = "AA12CW776", RecordedDateTime = DateTime.Now, Location = "Clinic A", TestValue = "15", LabValue = "20", Accuracy = "Y", DeviationRate = "5%", PhoneFile="tecno1" });
            dataset.Add(new LogModel { AppVersion = "2.0", PhoneID = "AA13RF854", RecordedDateTime = DateTime.Parse("06/02/2019"), Location = "Clinic B", TestValue = "15", LabValue = "20", Accuracy = "Y", DeviationRate = "5%", PhoneFile = "tecno2" });
            dataset.Add(new LogModel { AppVersion = "3.0", PhoneID = "AA16TG096", RecordedDateTime = DateTime.Now.AddDays(-2), Location = "Clinic B", TestValue = "15", LabValue = "20", Accuracy = "Y", DeviationRate = "5%", PhoneFile = "iphone" });
            dataset.Add(new LogModel { AppVersion = "3.3", PhoneID = "AA15TK076", RecordedDateTime = DateTime.Now.AddDays(-5), Location = "Clinic D", TestValue = "15", LabValue = "20", Accuracy = "Y", DeviationRate = "5%", PhoneFile = "samsung" });
            dataset.Add(new LogModel { AppVersion = "2.0", PhoneID = "AA16EG025", RecordedDateTime = DateTime.Now.AddDays(-5), Location = "Clinic C", TestValue = "15", LabValue = "20", Accuracy = "Y", DeviationRate = "5%", PhoneFile = "tecno1" });
            dataset.Add(new LogModel { AppVersion = "2.3", PhoneID = "AA03TB093", RecordedDateTime = DateTime.Parse("05/28/2019"), Location = "Clinic B", TestValue = "15", LabValue = "20", Accuracy = "Y", DeviationRate = "5%", PhoneFile = "tecno2" });
            dataset.Add(new LogModel { AppVersion = "3.0", PhoneID = "AA56RU937", RecordedDateTime = DateTime.Now.AddDays(-7), Location = "Clinic C", TestValue = "15", LabValue = "20", Accuracy = "Y", DeviationRate = "5%", PhoneFile = "samsung" });
            dataset.Add(new LogModel { AppVersion = "3.3", PhoneID = "AA76BM405", RecordedDateTime = DateTime.Now.AddDays(-7), Location = "Clinic D", TestValue = "15", LabValue = "20", Accuracy = "Y", DeviationRate = "5%", PhoneFile = "iphone" });
            dataset.Add(new LogModel { AppVersion = "3.3", PhoneID = "AA36TD842", RecordedDateTime = DateTime.Now.AddDays(-8), Location = "Clinic D", TestValue = "15", LabValue = "20", Accuracy = "Y", DeviationRate = "5%", PhoneFile = "tecno1" });
           
        }
    }
}