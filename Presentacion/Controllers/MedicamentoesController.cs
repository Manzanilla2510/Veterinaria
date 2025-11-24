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
    public class MedicamentoesController : ControllerBase
    {
        private readonly IMedicamentoRepositorio _context;

        public MedicamentoesController(IMedicamentoRepositorio context)
        {
            _context = context;
        }

        // GET: api/Medicamentoes
        [HttpGet("GetMedicamentos")]
        public async Task<ActionResult<IEnumerable<Medicamento>>> GetMedicamentos()
        {
            return Ok(await _context.GetMedicamentos());
        }

        //// GET: api/Medicamentoes/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<Medicamento>> GetMedicamento(int id)
        //{
        //    var medicamento = await _context.Medicamentos.FindAsync(id);

        //    if (medicamento == null)
        //    {
        //        return NotFound();
        //    }

        //    return medicamento;
        //}

        //// PUT: api/Medicamentoes/5
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutMedicamento(int id, Medicamento medicamento)
        //{
        //    if (id != medicamento.IdMedicamento)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(medicamento).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!MedicamentoExists(id))
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

        //// POST: api/Medicamentoes
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<Medicamento>> PostMedicamento(Medicamento medicamento)
        //{
        //    _context.Medicamentos.Add(medicamento);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetMedicamento", new { id = medicamento.IdMedicamento }, medicamento);
        //}

        //// DELETE: api/Medicamentoes/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteMedicamento(int id)
        //{
        //    var medicamento = await _context.Medicamentos.FindAsync(id);
        //    if (medicamento == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Medicamentos.Remove(medicamento);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        //private bool MedicamentoExists(int id)
        //{
        //    return _context.Medicamentos.Any(e => e.IdMedicamento == id);
        //}
    }
}
