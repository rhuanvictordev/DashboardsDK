using DashboardsDK.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DashboardsDK.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Graficos()
        {
            return View();
        }

        public ActionResult Dashboard()
        {
            DashboardModel model = new DashboardModel();
            model.SetorNome = "Teste";
            return View(model);
        }
    }
}