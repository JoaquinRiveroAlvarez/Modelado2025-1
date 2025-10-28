using Modelado2025_1BD.Datos.Entity;
using Modelado2025_1Shared.DTO;

namespace Modelado2025_1Repositorio.Repositorios
{
    public interface IPedidoRepositorio : IRepositorio<Pedido>
    {
        Task<Pedido?> SelectByCod(string cod);
        Task<List<PedidoListadoDTO>> SelectListaPedido();
        Task<PedidoListadoDTO?> SelectPedidoPorId(int pedidoId);
    }
}