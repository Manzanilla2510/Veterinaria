using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PVeterianaria.Core.DTOs;
using PVeterianaria.Core.Entidades;
using PVeterianaria.Core.Interfaces;
using PVeterianaria.Infraestructura.Data;
using PVeterianaria.Infraestructura.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PVeterianaria.Presentacion.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RevisionsController : ControllerBase
    {
        private readonly IRevisionRepositorio _context;

        public RevisionsController(IRevisionRepositorio context)
        {
            _context = context;
        }

        // GET: api/Revisions
        [HttpGet("GETRevisiones")]
        public async Task<ActionResult<List<RevisionDTO>>> GetRevisiones()
        {
          
            return Ok(await _context.GetRevisiones());
        }

        // GET: api/Revisions/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<Revision>> GetRevision(int id)
        //{
        //    var revision = await _context.Revisiones.FindAsync(id);

        //    if (revision == null)
        //    {
        //        return NotFound();
        //    }

        //    return revision;
        //}

        // PUT: api/Revisions/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutRevision(int id, Revision revision)
        //{
        //    if (id != revision.IdRevision)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(revision).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!RevisionExists(id))
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

        // POST: api/Revisions
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost("PostRevision")]
        public async Task<ActionResult<Revision>> PostRevision(RevisionDTO dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var creado = await _context.PostRevision(dto);

            return Ok("Revision Creada Correctamente");
        }

        // DELETE: api/Revisions/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteRevision(int id)
        //{
        //    var revision = await _context.Revisiones.FindAsync(id);
        //    if (revision == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Revisiones.Remove(revision);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        //private bool RevisionExists(int id)
        //{
        //    return _context.Revisiones.Any(e => e.IdRevision == id);
        //}
    }
}
