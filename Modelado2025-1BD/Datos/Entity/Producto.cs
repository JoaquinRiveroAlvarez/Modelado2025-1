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
    [Index(nameof(Codigo), Name = "Producto_UQ", IsUnique = true)]
    public class Producto : EntityBase
    {

        [Required(ErrorMessage = "El campo CodProducto es obligatorio")]
        [MaxLength(4, ErrorMessage = "El código del producto no puede exceder los 4 caracteres")]
        public required string Codigo { get; set; }

        [Required(ErrorMessage = "El producto es obligatorio")]
        [MaxLength(30, ErrorMessage = "El producto no puede exceder los 30 caracteres")]
        public required string Nombre { get; set; }

        public decimal Precio { get; set; } = 0;
        
        [Required(ErrorMessage = "El producto es obligatorio")]
        [MaxLength(30, ErrorMessage = "El producto no puede exceder los 30 caracteres")]
        public int Stock { get; set; } = 0;
        public int TipoProductoId { get; set; }
        public TipoProducto? TipoProductos { get; set; }
    }
}
