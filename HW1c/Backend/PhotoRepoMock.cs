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
    public class PhotoRepoMock : IPhotoRepo
    {
        public List<PhotoModel> dataset = new List<PhotoModel>();

        /// <summary>
        /// Constructor for Log Repository
        /// </summary>
        public PhotoRepoMock()
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
        public PhotoModel Read(String id)
        {
            // Get the first instance of the record
            var myData = dataset.First(m => m.PhotoID == id);
            return myData;
        }
        /// <summary>
        /// Return all items in the data store
        /// </summary>
        /// <returns>a list of all the items in the data store</returns>
        public List<PhotoModel> Index()
        {
            return dataset;
        }

        /// <summary>
        /// Sets Initial Seed Data
        /// </summary>
        public void Initialize()
        {
            dataset.Add(new PhotoModel { Value = "13", Location = "A", RecordedDateTime = DateTime.Parse("04/23/2019"), UserID = "1", PhoneID = "AA12CW776", AppVersion = "1.0", PhotoFile="testGood1.png"});
            dataset.Add(new PhotoModel { Value = "25", Location = "A", RecordedDateTime = DateTime.Parse("04/23/2019"), UserID = "1", PhoneID = "AA13RF854", AppVersion = "2.0", PhotoFile= "testGood2.png"});
            dataset.Add(new PhotoModel { Value = "11", Location = "B", RecordedDateTime = DateTime.Parse("04/25/2019"), UserID = "2", PhoneID = "AA16TG096", AppVersion = "3.0", PhotoFile= "testGood3.png"});
            dataset.Add(new PhotoModel { Value = "N/A", Location = "B", RecordedDateTime = DateTime.Parse("04/25/2019"), UserID = "2", PhoneID = "AA15TK076", AppVersion = "3.3", PhotoFile= "testBad1.png"});
            dataset.Add(new PhotoModel { Value = "N/A", Location = "C", RecordedDateTime = DateTime.Parse("04/26/2019"), UserID = "3", PhoneID = "AA16EG025", AppVersion = "2.0", PhotoFile= "testBad2.png"});
            dataset.Add(new PhotoModel { Value = "N/A", Location = "C", RecordedDateTime = DateTime.Parse("04/26/2019"), UserID = "4", PhoneID = "AA03TB093", AppVersion = "2.3", PhotoFile= "testBad3.png"});
            dataset.Add(new PhotoModel { Value = "28", Location = "B", RecordedDateTime = DateTime.Parse("04/27/2019"), UserID = "4", PhoneID = "AA56RU937", AppVersion = "3.0", PhotoFile = "testGood1.png"});
            dataset.Add(new PhotoModel { Value = "15", Location = "C", RecordedDateTime = DateTime.Parse("04/27/2019"), UserID = "5", PhoneID = "AA76BM405", AppVersion = "3.3", PhotoFile = "testGood2.png"});
            dataset.Add(new PhotoModel { Value = "27", Location = "C", RecordedDateTime = DateTime.Parse("04/28/2019"), UserID = "5", PhoneID = "AA36TD842", AppVersion = "3.0", PhotoFile = "testGood3.png"});
            dataset.Add(new PhotoModel { Value = "N/A", Location = "A", RecordedDateTime = DateTime.Parse("04/28/2019"), UserID = "6", PhoneID = "AA39FH782", AppVersion = "2.3", PhotoFile = "testBad1.png"});
            dataset.Add(new PhotoModel { Value = "N/A", Location = "A", RecordedDateTime = DateTime.Parse("04/29/2019"), UserID = "6", PhoneID = "AA41KL853", AppVersion = "2.0", PhotoFile = "testBad2.png"});
            dataset.Add(new PhotoModel { Value = "N/A", Location = "B", RecordedDateTime = DateTime.Parse("04/29/2019"), UserID = "6", PhoneID = "AA89ES378", AppVersion = "1.0", PhotoFile = "testBad3.png"});
            

        }
    }
}