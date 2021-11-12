using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebElReyCan.Admin;
using WebElReyCan.Data;
using WebElReyCan.Models;

namespace WebElReyCan.Controllers
{
    public class TurnoController : Controller
    {
        private static TurnoDbContext context = new TurnoDbContext();

        public ActionResult Index()
        {
            return View("Index", AdminTurno.Listar());
        }

        [HttpGet]
        public ActionResult Create()
        {
            Turno turno = new Turno();
            return View("Create", turno);
        }

        [HttpPost]
        public ActionResult Create(Turno turno)
        {
            if (ModelState.IsValid)
            {
                AdminTurno.Crear(turno);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("Create", turno);
        }

        [HttpGet]
        public ActionResult Detail(int id)
        {
            Turno turno = AdminTurno.TraerId(id);
            if (turno != null)
            {
                return View("Detail", turno);
            }
            else
            {
                return HttpNotFound();
            }
        }

        public ActionResult Delete(int id)
        {
            Turno turno = AdminTurno.TraerId(id);
            if (turno != null)
            {
                return View("Delete", turno);
            }
            else
            {
                return HttpNotFound();
            }
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Turno turno = AdminTurno.TraerId(id);
            if (turno != null)
            {
                AdminTurno.Eliminar(turno);
                return RedirectToAction("Index");
            }
            else
            {
                return HttpNotFound();
            }
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            Turno turno = AdminTurno.TraerId(id);

            if (turno != null)
            {
                return View("Edit", turno);
            }
            else
            {
                return HttpNotFound();
            }
        }


        [HttpPost]
        [ActionName("Edit")]
        public ActionResult EditConfirmed(Turno turno)
        {
            if (ModelState.IsValid)
            {
                context.Entry(turno).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View("Edit", turno);
        }

        [HttpGet]
        public ActionResult SearchByDate()
        {
                return View("Index", AdminTurno.FiltrarFechaActual());
        }

        public ActionResult SearchByName(string NombreMascota)
        {
            if (NombreMascota == null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View("Index", AdminTurno.BuscarPorNombre(NombreMascota));
            }
        }

        public ActionResult SearchByPhone(string Celular)
        {
            if (Celular == null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View("Index", AdminTurno.BuscarPorCelular(Celular));
            }
        }
    }
}