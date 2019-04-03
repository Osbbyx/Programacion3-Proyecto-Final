using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models
{
    public class Empleados
    {
        [Key]
        public int? Id { get; set; }
        public int? CodigoEmpleado { get; set; }
        [Required(ErrorMessage = "Debe de colocar un nombre")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Debe de colocar un apellido")]
        public string Apellido { get; set; }
        [Required(ErrorMessage = "Debe de colocar un telefono")]
        [MaxLength(10, ErrorMessage = "Poner un telefono valido")]
        public string Telefono { get; set; }
        public string Departamento { get; set; }
        [Required(ErrorMessage = "Debe de colocar el cargo")]
        public string Cargo { get; set; }
        [Required(ErrorMessage = "Seleccione la fecha en la que ingreso")]
        public DateTime FechaIngreso { get; set; }
        [Required(ErrorMessage = "Colocar el salario actual")]
        public int Salario { get; set; }
        public ESTADO Estatus { get; set; }
        public enum ESTADO
        {
            Activos, Inactivo
        }
    }
}