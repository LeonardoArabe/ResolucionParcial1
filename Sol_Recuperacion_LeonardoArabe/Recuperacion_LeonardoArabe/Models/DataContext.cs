using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Recuperacion_LeonardoArabe.Models
{
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {
        }

        public System.Data.Entity.DbSet<Recuperacion_LeonardoArabe.Models.Product> Products { get; set; }
    }
}