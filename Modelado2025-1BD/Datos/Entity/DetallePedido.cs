using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelado2025_1BD.Datos.Entity
{
    public class DetallePedido
    {
        public int Id { get; set; }
        public int cantidad { get; set; } = 0;
        public decimal precioUnitario { get; set; } = 0;
        public List<Pedido> Pedidos { get; set; } = new List<Pedido>();
    }
}
