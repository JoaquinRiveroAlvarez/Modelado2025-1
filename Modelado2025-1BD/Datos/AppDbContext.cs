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

        public DbSet<ProductoPedido> ProductoPedidos { get; set; }

        public AppDbContext(DbContextOptions options) : base(options)
        {      
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //// Relación 1:1 entre Pedido y DetallePedido
            //modelBuilder.Entity<Pedido>()
            //    .HasOne(u => u.DetallePedidos)
            //    .WithOne(p => p.Pedidos)
            //    .HasForeignKey<Pedido>(u => u.DetallePedidoId)
            //    .OnDelete(DeleteBehavior.NoAction);

            // Relación 1:N entre TipoProducto y Producto

            modelBuilder.Entity<Producto>()
                .HasOne(u => u.TipoProductos)
                .WithMany(r => r.Productos)
                .HasForeignKey(u => u.TipoProductoId)
                .OnDelete(DeleteBehavior.NoAction);

            // Relación 1:N entre Pedido y DetallePedido
            modelBuilder.Entity<Pedido>()
                .HasOne(u => u.DetallePedidos)
                .WithMany(r => r.Pedidos)
                .HasForeignKey(u => u.DetallePedidoId)
                .OnDelete(DeleteBehavior.NoAction);
            // Relación N:M entre Pedido y Producto

            modelBuilder.Entity<ProductoPedido>()
                .HasKey(ec => new { ec.ProductoId, ec.PedidoId });

            modelBuilder.Entity<ProductoPedido>()
                .HasOne(ec => ec.Pedidos)
                .WithMany(e => e.ProductoPedidos)
                .HasForeignKey(ec => ec.PedidoId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<ProductoPedido>()
                .HasOne(ec => ec.Productos)
                .WithMany(c => c.ProductoPedidos)
                .HasForeignKey(ec => ec.ProductoId)
                .OnDelete(DeleteBehavior.NoAction);

        }
    }
}
