using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models
{
    public class Cargos
    {
        [Key]
        public int? Id { get; set; }
        public string cargo { get; set; }
    }
}