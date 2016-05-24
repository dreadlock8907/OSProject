using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace modeling_SearchBanners.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Проект студентки группы 15ВЭМ1 Ольги Стреляной";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Наши контактные данные: ";

            return View();
        }
    }
}