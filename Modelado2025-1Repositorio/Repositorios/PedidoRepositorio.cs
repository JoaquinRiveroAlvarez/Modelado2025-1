using Microsoft.EntityFrameworkCore;
using Modelado2025_1BD.Datos;
using Modelado2025_1BD.Datos.Entity;
using Modelado2025_1Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelado2025_1Repositorio.Repositorios
{
    public class PedidoRepositorio : Repositorio<Pedido>, IPedidoRepositorio
    {
        private readonly AppDbContext context;

        public PedidoRepositorio(AppDbContext context) : base(context)
        {
            this.context = context;
        }
        public async Task<Pedido?> SelectByCod(string cod)
        {
            return await context.Set<Pedido>().FirstOrDefaultAsync(x => x.Codigo == cod);
        }
        public async Task<List<PedidoListadoDTO>> SelectListaPedido()
        {
            var lista = await context.Pedidos
                .Include(p => p.DetallePedidos)
                    .ThenInclude(d => d.Productos)
                .Select(p => new PedidoListadoDTO
                {
                    Id = p.Id,
                    FechaPedido = p.FechaPedido,
                    Cliente = p.Cliente,
                    MetodoDePago = p.MetodoDePago,
                    Detalles = p.DetallePedidos.Select(d => new DetallePedidoListadoDTO
                    {
                        IdDetalle = d.Id,
                        ProductoId = d.ProductoId,
                        ProductoNombre = d.Productos!.Nombre,
                        PrecioUnitario = d.precioUnitario,
                        Cantidad = d.cantidad
                    }).ToList()
                })
                .ToListAsync();

            return lista;
        }
        //public async Task<PedidoListadoDTO?> SelectPedidoPorId(int pedidoId)
        //{
        //    var pedido = await context.Pedidos
        //        .Include(p => p.DetallePedidos)
        //        .ThenInclude(d => d.Productos)
        //        .Where(p => p.Id == pedidoId)
        //        .Select(p => new PedidoListadoDTO
        //        {
        //            Id = p.Id,
        //            Pedido = $"Nro Pedido: {p.Id}",
        //            FechaPedido = p.FechaPedido,
        //            Cliente = p.Cliente,
        //            MetodoDePago = p.MetodoDePago,
        //            Total = p.DetallePedidos.Sum(dp => dp.cantidad * dp.precioUnitario),




        //            // Lista de detalles
        //            DetallesCadaPedido = p.DetallePedidos
        //                .Select(d => $"Producto: {d.Pedido!.Codigo} | Precio Unitario: {d.precioUnitario} | Cantidad: {d.cantidad} ")
        //                .ToList()
        //        })
        //        .FirstOrDefaultAsync();
        //    return pedido;
        //}
    }
}
