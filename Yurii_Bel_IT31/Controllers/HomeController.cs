using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Yurii_Bel_IT31.Models;

namespace Yurii_Bel_IT31.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            ViewBag.Message = "Здравствуйте! Меня зовут Белявский Юрий и я хочу познакомить Вас с моей курсовой работой";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Моё приложение позволяет модифицировать и отображать данные БД \"Теплосети\" ";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

    }
}
