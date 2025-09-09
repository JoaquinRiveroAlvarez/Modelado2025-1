using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Modelado2025_1BD.Datos;
using Modelado2025_1BD.Datos.Entity;

namespace Proyecto2025.Server.Controllers
{
    //[ApiController]
    //[Route("api/Producto")]
    //public class ProductoController : ControllerBase
    //{
    //    private readonly AppDbContext context;

    //    public ProductoController(AppDbContext context)
    //    {
    //        this.context = context;
    //    }

    //    [HttpGet] //api/TipoProvincia
    //    public async Task<ActionResult<List<Producto>>> GetList()
    //    {
    //        var lista = await context.Productos.ToListAsync();
    //        if (lista == null)
    //        {
    //            return NotFound("No se encontraron los productos, VERIFICAR.");
    //        }
    //        if (lista.Count == 0)
    //        {
    //            return Ok("No existen los productos en este momento.");
    //        }

    //        return Ok(lista);
    //    }

    //    [HttpGet("Id/{id:int}")]  //api/TipoProvincia/5
    //    public async Task<ActionResult<Producto>> GetById(int id)
    //    {
    //        var tipoProvincia = await context.Productos.FirstOrDefaultAsync(x => x.Id == id);
    //        if (tipoProvincia is null)
    //        {
    //            return NotFound($"No existe el tipo de provincia con el id: {id}.");
    //        }

    //        return Ok(tipoProvincia);
    //    }

    //    [HttpGet("Codigo/{cod}")]  //api/TipoProvincia/PRU
    //    public async Task<ActionResult<Producto>> GetByCod(string cod)
    //    {
    //        var tipoProvincia = await context.Productos.FirstOrDefaultAsync(x => x.Codigo == cod);
    //        if (tipoProvincia is null)
    //        {
    //            return NotFound($"No existe el tipo de provincia con el codigo: {cod}.");
    //        }

    //        return Ok(tipoProvincia);
    //    }

    //    [HttpPost]
    //    public async Task<ActionResult<int>> Post(Producto DTO)
    //    {
    //        try
    //        {                
    //            await context.Productos.AddAsync(DTO);
    //            await context.SaveChangesAsync();
    //            return Ok(DTO.Id);
    //        }
    //        catch (Exception e)
    //        {
    //            return BadRequest($"Error al crear el tipo de provincia: {e.Message}");
    //        }
    //    }

    //    [HttpPut("{id:int}")]  // api/TipoProvincia/6
    //    public async Task<ActionResult> Put(int id, Producto DTO)
    //    {
    //        if (id != DTO.Id)
    //        {
    //            return BadRequest("Datos no validos.");
    //        }
    //        var existe = await context.Productos.AnyAsync(x => x.Id == id);
    //        if (!existe)
    //        {
    //            return NotFound($"No existe el tipo de provincia con el id: {id}.");
    //        }
    //        context.Update(DTO);
    //        await context.SaveChangesAsync();
    //        return Ok($"Tipo de provincia con el id: {id} actualizado correctamente.");
    //    }

    //    [HttpDelete("{id:int}")]  // api/TipoProvincia/6
    //    public async Task<ActionResult> Delete(int id)
    //    {
    //        var tipoProvincia = await context.Productos.FirstOrDefaultAsync(x => x.Id == id);
    //        if (tipoProvincia is null)
    //        {
    //            return NotFound($"No existe el tipo de provincia con el id: {id}.");
    //        }
    //        context.Productos.Remove(tipoProvincia);
    //        await context.SaveChangesAsync();
    //        return Ok($"Tipo de provincia con el id: {id} eliminado correctamente.");
    //    }

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
    //}
}
