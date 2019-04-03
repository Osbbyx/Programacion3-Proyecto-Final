using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models
{
    public class Departamentos
    {
        [Key]
        public int? Id { get; set; }
        public int? Codigo { get; set; }
        public string Departamento { get; set; }
        [Required(ErrorMessage = "Debe de colocar un nombre")]
        public string Nombre { get; set; }
    }
}