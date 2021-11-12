using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebElReyCan.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Fecha = DateTime.Now.ToShortDateString();
            ViewBag.Saludo = "BIENVENIDOS AL SISTEMA DE PELUQUERIA CANINA DEL REY CAN";
            return View();
        }
    }
}