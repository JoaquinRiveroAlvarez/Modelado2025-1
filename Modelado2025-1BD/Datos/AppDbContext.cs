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
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<DetallePedido> DetallePedidos { get; set; }

        //public DbSet<ProductoDetallePedido> ProductoDetallePedidos { get; set; }

        public AppDbContext(DbContextOptions options) : base(options)
        {      
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Aquí puedes configurar tus entidades y relaciones

            //modelBuilder.Entity<ProductoDetallePedido>()
            //    .HasKey(pp => new { pp.ProductoId, pp.DetallePedidoId });

            var cascadeFKs = modelBuilder.Model
                .G­etEntityTypes()
                .SelectMany(t => t.GetForeignKeys())
                .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Casca­de);
            foreach (var fk in cascadeFKs)
            {
                fk.DeleteBehavior = DeleteBehavior.Restr­ict;
            }
        }
    }
}
