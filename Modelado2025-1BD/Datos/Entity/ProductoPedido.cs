using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelado2025_1BD.Datos.Entity
{
    public class ProductoPedido
    {
        public int ProductoId { get; set; }
        public required Producto Productos { get; set; }

        public int PedidoId { get; set; }
        public required Pedido Pedidos { get; set;}
    }
}
