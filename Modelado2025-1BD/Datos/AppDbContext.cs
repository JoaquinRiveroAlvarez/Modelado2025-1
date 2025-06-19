using Microsoft.EntityFrameworkCore;
using Modelado2025_1BD.Datos.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelado2025_1BD.Datos
{
    public class AppDbContext : DbContext
    {
        public DbSet <TipoProducto> TipoProductos { get; set; }
        public DbSet<Producto> Productos { get; set; }

        public AppDbContext(DbContextOptions options) : base(options)
        {      
        }
    }
}
