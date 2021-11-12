using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebElReyCan.Data;
using WebElReyCan.Models;

namespace WebElReyCan.Admin
{
    public class AdminTurno
    {
        private static TurnoDbContext context = new TurnoDbContext();

        public static List<Turno> Listar()
        {
            var turnos = context.Turnos.ToList();
            return turnos;
        }

        public static void Crear(Turno turno)
        {
            context.Turnos.Add(turno);
            context.SaveChanges();
        }

        public static Turno TraerId(int id)
        {
            Turno turno = context.Turnos.Find(id);
            context.Entry(turno).State = System.Data.Entity.EntityState.Detached;
            return turno;
        }

        public static void Eliminar(Turno turno)
        {
            context.Turnos.Attach(turno);
            context.Turnos.Remove(turno);
            context.SaveChanges();
        }

        public static List<Turno> FiltrarFechaActual()
        {
            var fechaActual = DateTime.Now.ToShortDateString();
            List<Turno> turnosFiltrados = (from t in context.Turnos
                                        where t.Fecha == fechaActual
                                        select t).ToList();
            return turnosFiltrados;
        }

        public static void Modificar(Turno turno)
        {
            context.Turnos.Attach(turno);
            context.SaveChanges();
        }

        public static List<Turno> BuscarPorNombre(string NombreMascota)
        {
            List<Turno> turnosNombres = (from t in context.Turnos
                                           where t.NombreMascota == NombreMascota
                                           select t).ToList();
            return turnosNombres;
        }

        public static List<Turno> BuscarPorCelular(string Celular)
        {
            List<Turno> turnosCelular = (from t in context.Turnos
                                         where t.Celular == Celular
                                         select t).ToList();
            return turnosCelular;
        }

    }
}