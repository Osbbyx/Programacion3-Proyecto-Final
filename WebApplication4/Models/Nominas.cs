using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models
{
    public class Nominas
    {
        [Key]
        public int? Id { get; set; }
        [Required(ErrorMessage = "Se debe colocar el año")]
        [MaxLength(4, ErrorMessage = "Este año no es valido")]
        public string año { get; set; }
        [Required(ErrorMessage = "Debe seleccionar el mes")]
        public MESD mes { get; set; }
        public enum MESD
        {
            Enero,Febrero,Marzo,Abril,Mayo,Junio,Julio,Agosto,Septiembre,Octubre,Noviembre,Diciembre
        }
        public int MontoTotal { get; set; }
    }
}