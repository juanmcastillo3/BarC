using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BarC.Models;


namespace BarC.Context
{
    public class BarDatabaseContext : DbContext
    {
        public BarDatabaseContext(DbContextOptions<BarDatabaseContext> options) : base(options)
        {
        }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Pedido> Pedido { get; set; }
        public DbSet<Producto> Producto { get; set; }
        public DbSet<Prod> Prod { get; set; }
        public DbSet<Historial> Historial { get; set; }

    }

}
