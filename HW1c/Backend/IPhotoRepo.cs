using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HW1c.Models;

namespace HW1c.Backend
{
    public interface IPhotoRepo
    {
        PhotoModel Read(String id);

        PhotoModel ReadPass(String id);

        PhotoModel ReadFail(String id);

        List<PhotoModel> Index();

        List<PhotoModel> Pass();

        List<PhotoModel> Fail();
    }
}