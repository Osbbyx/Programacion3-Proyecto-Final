using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models
{
    public class Salidas
    {
        [Key]
        public int? Id { get; set; }
        [Required(ErrorMessage = "Debe de colocar el empleado")]
        public string Empleado { get; set; }
        [Required(ErrorMessage = "Debe seleccionar el tipo de salida")]
        public TIPO TipoSalida { get; set; }
        public enum TIPO
        {
            Renuncia,Despido,Desahucio
        }
        [Required(ErrorMessage = "Debe colocar cual fue el motivo")]
        public string Motivo { get; set; }
        public DateTime FechaSalida { get; set; }
    }
}