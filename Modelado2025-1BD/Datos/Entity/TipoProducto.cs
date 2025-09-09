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
    [Index(nameof(CodTipoProducto), Name = "TipoProducto_UQ", IsUnique =true)]
    public class TipoProducto : EntityBase
    {

        [Required(ErrorMessage = "El campo CodTipoProducto es obligatorio")]
        [MaxLength(2, ErrorMessage = "El código del tipo producto no puede exceder los 2 caracteres")]
        public required string CodTipoProducto { get; set; }

        [Required(ErrorMessage = "El campo Tipo es obligatorio")]
        [MaxLength(30, ErrorMessage = "El tipo de producto no puede exceder los 30 caracteres")]
        public required string Tipo { get; set; }
        //public List<Producto> Productos { get; set; } = new();
    }
}
