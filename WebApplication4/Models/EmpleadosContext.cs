using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication4.Models
{
    public class EmpleadosContext:DbContext
    {
        public DbSet<Empleados> Empleado { get; set; }
        public DbSet<Departamentos> Departamento { get; set; }
        public DbSet<Cargos> Cargo { get; set; }
        public DbSet<Nominas> Nomina { get; set; }
        public DbSet<Salidas> Salida { get; set; }
        public DbSet<Vacaciones> Vacacione { get; set; }
        public DbSet<Permisos> Permiso{ get; set; }
        public DbSet<Licencias> Licencia { get; set; }
    }
}