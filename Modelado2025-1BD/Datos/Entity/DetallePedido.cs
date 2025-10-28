using Microsoft.EntityFrameworkCore;
using Modelado2025_1Shared.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelado2025_1BD.Datos.Entity
{
    public class DetallePedido : EntityBase
    {
        public int cantidad { get; set; } = 0;
        public decimal precioUnitario { get; set; } = 0;
        public int ProductoId { get; set; }
        public Producto? Productos { get; set; }
        public int PedidoId { get; set; }
        public Pedido? Pedido { get; set; }
    }
}
