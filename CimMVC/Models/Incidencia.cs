using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CimMVC.Models
{
    public class Incidencia
    {
        public int Id;
        public string CodigoIncidencia;
        public string TipoIncidencia;
        public string Turno;
        public string Dni;
        public string Distrito;
        public string CodigoContacto;
    }

    public class IncidenciaDbContext : DbContext { 
    
        public DbSet<Incidencia> Incidencias { get; set; }
    
    }
}