using Humanizer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PVeterianaria.Core.DTOs;
using PVeterianaria.Core.Entidades;
using PVeterianaria.Core.Interfaces;
using PVeterianaria.Infraestructura.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PVeterianaria.Presentacion.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlimentacionsController : ControllerBase
    {
        private readonly IAlimentacionRepositorio _context;

        public AlimentacionsController(IAlimentacionRepositorio context)
        {
            _context = context;
        }

        // GET: api/Alimentacions
        [HttpGet("GetAlimentacion")]
        public async Task<ActionResult<IEnumerable<Alimentacion>>> GetAlimentacion()
        {
            var alimentacion = await _context.GetLista();
            return Ok(alimentacion);
        }

        // GET: api/Alimentacions/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<Alimentacion>> GetAlimentacion(int id)
        //{
        //    var alimentacion = await _context.Alimentacion.FindAsync(id);

        //    if (alimentacion == null)
        //    {
        //        return NotFound();
        //    }

        //    return alimentacion;
        //}

        // PUT: api/Alimentacions/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutAlimentacion(int id, Alimentacion alimentacion)
        //{
        //    if (id != alimentacion.IdAlimentacion)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(alimentacion).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!AlimentacionExists(id))
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

        // POST: api/Alimentacions
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost("PostAlimentacion")]
        public async Task<ActionResult<Alimentacion>> PostAlimentacion(AlimentacionDTO alimentacion)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var creado = await _context.PostAlimentacion(alimentacion);

            return Ok("Usuario creado correctamente");
        }

        //DELETE: api/Alimentacions/5
        [HttpDelete("DeleteAlimentacion")]
        public async Task<IActionResult> DeleteAlimentacion(DeleteAlimentacionDTO dto)
        {
            var resultado = await _context.DeleteAlimentacion(dto);

            if (resultado == null)
                return NotFound(new { mensaje = "No existe registro con ese código." });

            return Ok(new { mensaje = "Alimentación deshabilitada", data = resultado });
        }

        //private bool AlimentacionExists(int id)
        //{
        //    return _context.Alimentacion.Any(e => e.IdAlimentacion == id);
        //}
    }
}
