﻿using System;
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
            dataset.Add(new PhotoModel { Value = "13", Location = "A", RecordedDateTime = DateTime.Parse("04/23/2019"), PhoneID = "ABC", AppVersion = "1.0", PhotoFile="testBad1.png"});
            dataset.Add(new PhotoModel { Value = "25", Location = "A", RecordedDateTime = DateTime.Parse("04/23/2019"), PhoneID = "MNO", AppVersion = "2.0", PhotoFile="testBad2.png" });
            dataset.Add(new PhotoModel { Value = "11", Location = "B", RecordedDateTime = DateTime.Parse("04/25/2019"), PhoneID = "XYZ", AppVersion = "1.0", PhotoFile="testBad3.png" });
            dataset.Add(new PhotoModel { Value = "28", Location = "B", RecordedDateTime = DateTime.Parse("04/25/2019"), PhoneID = "CDV", AppVersion = "2.0", PhotoFile="testGood1.png" });
            dataset.Add(new PhotoModel { Value = "15", Location = "C", RecordedDateTime = DateTime.Parse("04/26/2019"), PhoneID = "BMF", AppVersion = "2.0", PhotoFile="testGood2.png" });
            dataset.Add(new PhotoModel { Value = "27", Location = "C", RecordedDateTime = DateTime.Parse("04/26/2019"), PhoneID = "JJW", AppVersion = "2.0", PhotoFile="testGood3.png" });

        }
    }
}