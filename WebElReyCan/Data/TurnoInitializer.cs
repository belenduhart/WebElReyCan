using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebElReyCan.Models;

namespace WebElReyCan.Data
{
    public class TurnoInitializer : DropCreateDatabaseAlways<TurnoDbContext>
    {
        protected override void Seed(TurnoDbContext context)
        {
            var turnos = new List<Turno>
            {
               new Turno {
                  Fecha= "10/10/2021",
                  Hora = "12.15",
                  NombreMascota = "Firulais",
                  Raza= "Puddle",
                  Edad = 2,
                  NombreDuenio = "Juan Carlos",
                  Celular = "0351435968"
               },
               new Turno {
                  Fecha= "09/07/2021",
                  Hora = "13.30",
                  NombreMascota = "Copito",
                  Raza= "Caniche",
                  Edad = 6,
                  NombreDuenio = "Roberta",
                  Celular = "01145789643"
               },
               new Turno {
                  Fecha= "12/11/2021",
                  Hora = "14.30",
                  NombreMascota = "Paco",
                  Raza= "Golden",
                  Edad = 4,
                  NombreDuenio = "Agustin",
                  Celular = "0351655435"
               },
            };
            turnos.ForEach(s =>
            context.Turnos.Add(s));
            context.SaveChanges();
        }
    }
}