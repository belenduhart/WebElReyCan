using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebElReyCan.Models;

namespace WebElReyCan.Data
{
    public class TurnoDbContext:DbContext
    {
        public TurnoDbContext() : base("KeyDB") { }
        public DbSet<Turno> Turnos { get; set; }
    }
}