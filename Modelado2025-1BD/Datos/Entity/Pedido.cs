using Microsoft.EntityFrameworkCore;
using Modelado2025_1BD.Datos.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelado2025_1BD.Datos.Entity
{
    [Index(nameof(Codigo), Name = "Pedido_UQ", IsUnique = true)]
    public class Pedido : EntityBase
    {
        [Required(ErrorMessage = "El código es obligatorio")]
        [MaxLength(4, ErrorMessage = "El código no puede exceder los 4 caracteres")]
        public required string Codigo { get; set; }
        public DateTime FechaPedido { get; set; } = DateTime.Now;
        public string Cliente { get; set; } = string.Empty;
        public MetodoDePago MetodoDePago { get; set; } 
        public decimal Total { get; set; } = 0;
        public Pedido()
        {
            FechaPedido = DateTime.Now;
        }
        public List<DetallePedido> DetallePedidos { get; set; } = new List<DetallePedido>();
    }
}
