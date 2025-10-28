using Modelado2025_1Shared.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Modelado2025_1BD.Datos.EntityBase;

namespace Modelado2025_1BD.Datos
{
    public class EntityBase : IEntityBase
    {
        public int Id { get; set; }
        public string Observacion { get; set; } = string.Empty;
        public EnumEstadoRegistro EstadoRegistro { get; set; } = EnumEstadoRegistro.EnGrabacion;
    }
}
