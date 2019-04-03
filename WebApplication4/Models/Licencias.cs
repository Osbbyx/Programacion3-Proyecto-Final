using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models
{
    public class Licencias
    {
        [Key]
        public int? Id { get; set; }
        [Required(ErrorMessage = "Debe de colocar el empleado")]
        public string Empleado { get; set; }
        [Required(ErrorMessage = "Debe de seleccionar desde")]
        public DateTime Desde { get; set; }
        [Required(ErrorMessage = "Debe de seleccionar hasta")]
        public DateTime Hasta { get; set; }
        [Required(ErrorMessage = "Debe de colocar el motivo")]
        public string Motivo { get; set; }
        public string Comentarios { get; set; }
    }
}