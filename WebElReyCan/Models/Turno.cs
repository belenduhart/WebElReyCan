using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebElReyCan.Models
{
    [Table("Turno")]
    public class Turno
    {
        [Key]
        public int Id { get; set; }

        public string Fecha { get; set; }
        public string Hora { get; set; }

        [Required(ErrorMessage = "El nombre del can es obligatorio")]
        [StringLength(50)]
        public string NombreMascota { get; set; }

        [StringLength(50)]
        public string Raza { get; set; }

        public int Edad { get; set; }

        [Required(ErrorMessage = "El nombre del dueño es obligatorio")]
        [StringLength(50)]
        public string NombreDuenio { get; set; }

        [Required(ErrorMessage = "El nro de telefono es obligatorio")]
        public string Celular { get; set; }
    }
}