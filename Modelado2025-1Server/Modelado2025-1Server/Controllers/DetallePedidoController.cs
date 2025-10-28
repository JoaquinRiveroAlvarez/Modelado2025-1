using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Modelado2025_1BD.Datos;
using Modelado2025_1BD.Datos.Entity;
using Modelado2025_1Repositorio.Repositorios;
using Modelado2025_1Shared.DTO;

namespace Proyecto2025.Server.Controllers
{
    [ApiController]
    [Route("api/DetallePedido")]
    public class DetallePedidoController : ControllerBase
    {
        private readonly IDetallePedidoRepositorio repositorio;
        public DetallePedidoController(IDetallePedidoRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }

        [HttpGet] //api/DetallePedido
        public async Task<ActionResult<List<DetallePedido>>> GetList()
        {
            var lista = await repositorio.Select();
            if (lista == null)
            {
                return NotFound("No se encontro la lista, VERIFICAR.");
            }
            if (lista.Count == 0)
            {
                return Ok("No existen items en la lista en este momento");
            }

            return Ok(lista);
        }

        [HttpGet("Id/{id:int}")]  //api/DetallePedido/5
        public async Task<ActionResult<DetallePedido>> GetById(int id)
        {
            var detallePedido = await repositorio.SelectById(id);
            if (detallePedido is null)
            {
                return NotFound($"No existe el registro con el id: {id}.");
            }

            return Ok(detallePedido);
        }

        //[HttpGet("ListaDetallePedido")] //api/ListaDetallePedido
        //public async Task<ActionResult<List<DetallePedidoListadoDTO>>> ListaDetallePedido()
        //{
        //    var lista = await repositorio.SelectListaDetallePedido();
        //    if (lista == null)
        //    {
        //        return NotFound("No se encontro elementos de la lista, VERIFICAR.");
        //    }
        //    if (lista.Count == 0)
        //    {
        //        return Ok("Lista sin registros.");
        //    }

        //    return Ok(lista);
        //}

        //[HttpGet("{id}/ListaPorNroPedido")]  //api/Pedido/3
        //public async Task<ActionResult<List<DetallePedidoListadoDTO>>> ListaDetallePedidoPorId(int id)
        //{
        //    var lista = await repositorio.SelectPedidoPorId(id);
        //    if (lista == null)
        //    {
        //        return NotFound($"No se encontro elementos en la lista con el código: {id}.");
        //    }
        //    if (lista.Count == 0)
        //    {
        //        return Ok("Lista sin registros.");
        //    }
        //    return Ok(lista);
        //    //if (resumen == null || resumen.Count == 0)
        //    //    return NotFound();
        //}
        //[HttpGet("Codigo/{cod}")]  //api/TipoProvincia/PRU
        //public async Task<ActionResult<DetallePedido>> GetByCod(string cod)
        //{
        //    var tipoProvincia = await context.DetallePedidos.FirstOrDefaultAsync(x => x.Codigo == cod);
        //    if (tipoProvincia is null)
        //    {
        //        return NotFound($"No existe el tipo de provincia con el codigo: {cod}.");
        //    }

        //    return Ok(tipoProvincia);
        //}

        //[HttpPost]
        //public async Task<ActionResult<int>> Post(DetallePedido DTO)
        //{
        //    try
        //    {                
        //        await context.DetallePedidos.AddAsync(DTO);
        //        await context.SaveChangesAsync();
        //        return Ok(DTO.Id);
        //    }
        //    catch (Exception e)
        //    {
        //        return BadRequest($"Error al crear el tipo de provincia: {e.Message}");
        //    }
        //}

        //[HttpPut("{id:int}")]  // api/DetallePedido/6
        //public async Task<ActionResult> Put(int id, DetallePedido DTO)
        //{
        //    if (id != DTO.Id)
        //    {
        //        return BadRequest("Datos no validos.");
        //    }
        //    var existe = await context.DetallePedidos.AnyAsync(x => x.Id == id);
        //    if (!existe)
        //    {
        //        return NotFound($"No existe el tipo de provincia con el id: {id}.");
        //    }
        //    context.Update(DTO);
        //    await context.SaveChangesAsync();
        //    return Ok($"Tipo de provincia con el id: {id} actualizado correctamente.");
        //}

        //[HttpDelete("{id:int}")]  // api/DetallePedido/6
        //public async Task<ActionResult> Delete(int id)
        //{
        //    var tipoProvincia = await context.DetallePedidos.FirstOrDefaultAsync(x => x.Id == id);
        //    if (tipoProvincia is null)
        //    {
        //        return NotFound($"No existe el tipo de provincia con el id: {id}.");
        //    }
        //    context.DetallePedidos.Remove(tipoProvincia);
        //    await context.SaveChangesAsync();
        //    return Ok($"Tipo de provincia con el id: {id} eliminado correctamente.");
        //}

        //[HttpPut("{cod}")]  // api/TipoProvincia/6
        //public async Task<ActionResult> PutByCod(string cod, Producto DTO)
        //{
        //    if (cod != DTO.CodProducto)
        //    {
        //        return BadRequest("Datos no validos.");
        //    }
        //    var existe = await context.Productos.AnyAsync(x => x.CodProducto == cod);
        //    if (!existe)
        //    {
        //        return NotFound($"No existe el tipo de provincia con el id: {cod}.");
        //    }
        //    context.Update(DTO);
        //    await context.SaveChangesAsync();
        //    return Ok($"Tipo de provincia con el id: {cod} actualizado correctamente.");
        //}

        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteTipoProvincia(int id)
        //{
        //    var tipoProvincia = await context.TipoProvincias.FindAsync(id);

        //    if (tipoProvincia == null)
        //        return NotFound();

        //    tipoProvincia.EstadoRegistro = EnumEstadoRegistro.inactivo;

        //    context.TipoProvincias.Update(tipoProvincia);
        //    await context.SaveChangesAsync();

        //    return NoContent();
        //}
    }
}
