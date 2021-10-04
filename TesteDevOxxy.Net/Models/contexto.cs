using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TesteDevOxxy.Net.Models
{
    public class contexto: DbContext
    {
        public DbSet<veiculos> Veiculos { get; set; }
    }
}