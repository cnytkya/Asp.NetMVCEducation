using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Asp.NetMVCEducation.NETFramework.Controllers
{
    public class Mvc03PostBackControllerController : Controller
    {
        [HttpGet] // sayfada get işlemi olursa bu metot çalışsın
        public ActionResult Index(string kelime)
        {
            return View();
        }
        [HttpPost] // sayfada post işlemi olursa bu metot çalışsın
        public ActionResult Index()
        {
            // post işleminden sonra burada veritabanı işlemi yapabiliriz
            return View();
        }
    }
}