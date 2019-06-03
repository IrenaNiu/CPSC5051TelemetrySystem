using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HW1c.Models;
namespace HW1c.Backend
{
    public class PhotoBackend
    {
        #region SingletonPattern
        private static volatile PhotoBackend instance;
        private static object syncRoot = new object();

        private PhotoBackend() { }

        public static PhotoBackend Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new PhotoBackend();
                    }
                }

                return instance;
            }
        }
        #endregion SingletonPattern

        // Hook up the Repositry
        private IPhotoRepo repository = new PhotoRepoMock();

        /// <summary>
        /// Read
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public PhotoModel Read(string id)
        {
            var myData = repository.Read(id);
            return myData;
        }

        public PhotoModel ReadPass(string id)
        {
            var myData = repository.ReadPass(id);
            return myData;
        }

        public PhotoModel ReadFail(string id)
        {
            var myData = repository.ReadFail(id);
            return myData;
        }

        /// <summary>
        ///  Returns the List of Photo Logs
        /// </summary>
        /// <returns></returns>
        public PhotoViewModel Index()
        {
            var myData = new PhotoViewModel();
            myData.PhotoList = repository.Index();

            return myData;
        }

        public PhotoViewModel Pass()
        {
            var myData = new PhotoViewModel();
            myData.PhotoList = repository.Pass();

            return myData;
        }

        public PhotoViewModel Fail()
        {
            var myData = new PhotoViewModel();
            myData.PhotoList = repository.Fail();

            return myData;
        }


    }
}