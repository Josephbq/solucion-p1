using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace solucion_p1.Models
{
    public class DBEntities : DbContext
    {
        public DbSet<Movie> Movies { get; set; }

    }
}