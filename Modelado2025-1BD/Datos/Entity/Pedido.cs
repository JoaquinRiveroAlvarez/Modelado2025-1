using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelado2025_1BD.Datos.Entity
{
    public class Pedido
    {
        public int Id { get; set; }
        public int DetallePedidoId { get; set; }
        public DetallePedido? DetallePedidos { get; set; }
        public DateTime FechaPedido { get; set; } = DateTime.Now;
        public string Cliente { get; set; } = string.Empty;
        //public List<Producto> Productos { get; set; } = new List<Producto>();
        public decimal Total { get; set; } = 0;
        public Pedido()
        {
            FechaPedido = DateTime.Now;
        }
        public List<ProductoPedido> ProductoPedidos { get; set; } = new();
    }
}
