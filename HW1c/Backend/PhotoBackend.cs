using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HW1c.Models;
namespace HW1c.Backend
{
    public class PhotoBackend
    {
        public class LogBackend
        {
            #region SingletonPattern
            private static volatile LogBackend instance;
            private static object syncRoot = new object();

            private LogBackend() { }

            public static LogBackend Instance
            {
                get
                {
                    if (instance == null)
                    {
                        lock (syncRoot)
                        {
                            if (instance == null)
                                instance = new LogBackend();
                        }
                    }

                    return instance;
                }
            }
            #endregion SingletonPattern

            // Hook up the Repositry
            private ILogRepository repository = new LogRepositoryMock();

            /// <summary>
            /// Read
            /// </summary>
            /// <param name="id"></param>
            /// <returns></returns>
            public LogModel Read(string id)
            {
                var myData = repository.Read(id);
                return myData;
            }

            /// <summary>
            ///  Returns the List of Logs
            /// </summary>
            /// <returns></returns>
            public PhotoViewModel Index()
            {
                var myData = new PhotoViewModel();
                myData.PhotoList = repository.Index();

                return myData;
            }
        }
    }