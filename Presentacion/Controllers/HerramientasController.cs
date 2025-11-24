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
    public class HerramientasController : ControllerBase
    {
        private readonly IHerramientaRepositorio _context;

        public HerramientasController(IHerramientaRepositorio context)
        {
            _context = context;
        }

        // GET: api/Herramientas
        [HttpGet("GetHerramientas")]
        public async Task<ActionResult<IEnumerable<Herramienta>>> GetHerramientas()
        {
            var listan = await _context.GetHerramienta();
            return Ok(listan);
        }

        //// GET: api/Herramientas/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<Herramienta>> GetHerramienta(int id)
        //{
        //    var herramienta = await _context.Herramientas.FindAsync(id);

        //    if (herramienta == null)
        //    {
        //        return NotFound();
        //    }

        //    return herramienta;
        //}

        //// PUT: api/Herramientas/5
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutHerramienta(int id, Herramienta herramienta)
        //{
        //    if (id != herramienta.IdHerramienta)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(herramienta).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!HerramientaExists(id))
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

        //// POST: api/Herramientas
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<Herramienta>> PostHerramienta(Herramienta herramienta)
        //{
        //    _context.Herramientas.Add(herramienta);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetHerramienta", new { id = herramienta.IdHerramienta }, herramienta);
        //}

        //// DELETE: api/Herramientas/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteHerramienta(int id)
        //{
        //    var herramienta = await _context.Herramientas.FindAsync(id);
        //    if (herramienta == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Herramientas.Remove(herramienta);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        //private bool HerramientaExists(int id)
        //{
        //    return _context.Herramientas.Any(e => e.IdHerramienta == id);
        //}
    }
}
