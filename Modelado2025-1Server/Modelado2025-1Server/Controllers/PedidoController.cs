using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Modelado2025_1BD.Datos;
using Modelado2025_1BD.Datos.Entity;
using Modelado2025_1Repositorio.Repositorios;

namespace Proyecto2025.Server.Controllers
{
    [ApiController]
    [Route("api/Pedido")]
    public class PedidoController : ControllerBase
    {
        private readonly IPedidoRepositorio repositorio;
        public PedidoController(IPedidoRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }

        [HttpGet] //api/Pedido
        public async Task<ActionResult<List<Pedido>>> GetList()
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

        [HttpGet("Id/{id:int}")]  //api/Pedido/5
        public async Task<ActionResult<Pedido>> GetById(int id)
        {
            var pedido = await repositorio.SelectById(id);
            if (pedido is null)
            {
                return NotFound($"No existe el registro con el id: {id}.");
            }

            return Ok(pedido);
        }

        [HttpGet("Codigo/{cod}")]  //api/Pedido/01
        public async Task<ActionResult<Pedido>> GetByCod(string cod)
        {
            var pedido = await repositorio.SelectByCod(cod);
            if (pedido is null)
            {
                return NotFound($"No existe el registro con el código: {cod}.");
            }

            return Ok(pedido);
        }

        //[HttpPost]
        //public async Task<ActionResult<int>> Post(Pedido DTO)
        //{
        //    try
        //    {                
        //        await context.Pedidos.AddAsync(DTO);
        //        await context.SaveChangesAsync();
        //        return Ok(DTO.Id);
        //    }
        //    catch (Exception e)
        //    {
        //        return BadRequest($"Error al crear el tipo de provincia: {e.Message}");
        //    }
        //}

        //[HttpPut("{id:int}")]  // api/TipoProvincia/6
        //public async Task<ActionResult> Put(int id, Pedido DTO)
        //{
        //    if (id != DTO.Id)
        //    {
        //        return BadRequest("Datos no validos.");
        //    }
        //    var existe = await context.Pedidos.AnyAsync(x => x.Id == id);
        //    if (!existe)
        //    {
        //        return NotFound($"No existe el tipo de provincia con el id: {id}.");
        //    }
        //    context.Update(DTO);
        //    await context.SaveChangesAsync();
        //    return Ok($"Tipo de provincia con el id: {id} actualizado correctamente.");
        //}

        //[HttpDelete("{id:int}")]  // api/TipoProvincia/6
        //public async Task<ActionResult> Delete(int id)
        //{
        //    var tipoProvincia = await context.Pedidos.FirstOrDefaultAsync(x => x.Id == id);
        //    if (tipoProvincia is null)
        //    {
        //        return NotFound($"No existe el tipo de provincia con el id: {id}.");
        //    }
        //    context.Pedidos.Remove(tipoProvincia);
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
