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
    public class DetallePedidoRepositorio : Repositorio<DetallePedido>, IDetallePedidoRepositorio
    {
        private readonly AppDbContext context;

        public DetallePedidoRepositorio(AppDbContext context) : base(context)
        {
            this.context = context;
        }
        //public async Task<List<DetallePedidoListadoDTO>> SelectListaDetallePedido()
        //{
        //    var lista = await context.DetallePedidos
        //                            .Select(p => new DetallePedidoListadoDTO
        //                            {
        //                                Id = p.Id,
        //                                DetallePedido = $"Nro Pedido: {p.PedidoId} - Producto: {p.ProductoId} - Precio Unitario: {p.precioUnitario} - Cantidad: {p.cantidad}"
        //                            })
        //                            .ToListAsync();
        //    return lista;
        //}
        //public async Task<List<DetallePedidoListadoDTO>> SelectPedidoPorId(int pedidoId)
        //{
        //    var lista = await context.DetallePedidos
        //                            .Where(d => d.PedidoId == pedidoId)
        //                            .Select(p => new DetallePedidoListadoDTO
        //                            {
        //                                Id = p.Id,
        //                                DetallePedido = $"Nro Pedido: {p.PedidoId} - Producto: {p.ProductoId} - Precio Unitario: {p.precioUnitario} - Cantidad: {p.cantidad}"
        //                            })
        //                            .ToListAsync();
        //    return lista;
        //}
        //public async Task<List<PedidoResumenDTO>> SelectPedidoConDetalles(int pedidoId)
        //{
        //    var detalles = await context.DetallePedidos
        //        .Where(d => d.PedidoId == pedidoId)
        //        .Select(d => new PedidoResumenDTO
        //        {
        //            Id = d.Id,
        //            CodigoPedido = d.Pedido.Id.ToString(), 
        //            CodigoProducto = d.Productos.Codigo,   
        //            NombreProducto = d.Productos.Nombre,   
        //            PrecioUnitario = d.precioUnitario.ToString(), 
        //            Cantidad = d.cantidad.ToString()
        //        })
        //        .ToListAsync();

        //    return detalles;
        //}

    }
}
