using Modelado2025_1Shared.Enum;

namespace Modelado2025_1BD.Datos
{
    public interface IEntityBase
    {
        int Id { get; set; }
        string Observacion { get; set; }
        EnumEstadoRegistro EstadoRegistro { get; set; }
    }
}