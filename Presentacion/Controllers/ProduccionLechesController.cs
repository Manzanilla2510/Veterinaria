using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PVeterianaria.Core.Entidades;
using PVeterianaria.Core.Interfaces;
using PVeterianaria.Infraestructura.Data;

namespace PVeterianaria.Presentacion.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProduccionLechesController : ControllerBase
    {
        private readonly IProduccionRepositorio _context;

        public ProduccionLechesController(IProduccionRepositorio context)
        {
            _context = context;
        }

        // GET: api/ProduccionLeches
        [HttpGet("Getparasacaruninformedelacantidaddelecheproducidadelasvacas")]
        public async Task<ActionResult<IEnumerable<ProduccionLeche>>> GetProducciones()
        {
            return Ok(await _context.GetProducciones());
        }

        // GET: api/ProduccionLeches/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<ProduccionLeche>> GetProduccionLeche(int id)
        //{
        //    var produccionLeche = await _context.Producciones.FindAsync(id);

        //    if (produccionLeche == null)
        //    {
        //        return NotFound();
        //    }

        //    return produccionLeche;
        //}

        // PUT: api/ProduccionLeches/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutProduccionLeche(int id, ProduccionLeche produccionLeche)
        //{
        //    if (id != produccionLeche.IdProduccionLeche)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(produccionLeche).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!ProduccionLecheExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        // POST: api/ProduccionLeches
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<ProduccionLeche>> PostProduccionLeche(DateOnly fechaProduccion,decimal CantidadLeche)
        //{
        //    ProduccionLeche produccion = new ProduccionLeche
        //    {
        //        Fecha_produccion = fechaProduccion,
        //        Cantidad_Leche = CantidadLeche
        //    };
        //    _context.Producciones.Add(produccion);
        //    await _context.SaveChangesAsync();

        //    return Ok(new { mensaje="Se creo correctamente"});
        //}

        // DELETE: api/ProduccionLeches/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteProduccionLeche(int id)
        //{
        //    var produccionLeche = await _context.Producciones.FindAsync(id);
        //    if (produccionLeche == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Producciones.Remove(produccionLeche);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        //private bool ProduccionLecheExists(int id)
        //{
        //    return _context.Producciones.Any(e => e.IdProduccionLeche == id);
        //}
    }
}
