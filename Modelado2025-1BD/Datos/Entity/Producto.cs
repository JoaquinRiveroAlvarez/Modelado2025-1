using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelado2025_1BD.Datos.Entity
{
    [Index(nameof(CodProducto), Name = "Producto_UQ", IsUnique = true)]
    public class Producto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo Tipo Producto es obligatorio")]
        public int TipoProductoId { get; set; }
        public TipoProducto? TipoProducto { get; set; }

        [Required(ErrorMessage = "El campo CodProducto es obligatorio")]
        [MaxLength(4, ErrorMessage = "El código del producto no puede exceder los 4 caracteres")]
        public required string CodProducto { get; set; }

        [Required(ErrorMessage = "El producto es obligatorio")]
        [MaxLength(30, ErrorMessage = "El producto no puede exceder los 30 caracteres")]
        public required string Nombre { get; set; }

        public decimal Precio { get; set; } = 0;
        
        [Required(ErrorMessage = "El producto es obligatorio")]
        [MaxLength(30, ErrorMessage = "El producto no puede exceder los 30 caracteres")]
        public int Stock { get; set; } = 0;

    }
}
