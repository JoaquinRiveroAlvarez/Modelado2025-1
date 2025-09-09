using Modelado2025_1BD.Datos.Entity;

namespace Modelado2025_1Repositorio.Repositorios
{
    public interface IPedidoRepositorio : IRepositorio<Pedido>
    {
        Task<Pedido?> SelectByCod(string cod);
    }
}