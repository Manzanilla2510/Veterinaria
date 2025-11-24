using Humanizer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PVeterianaria.Core.DTOs;
using PVeterianaria.Core.Entidades;
using PVeterianaria.Core.Interfaces;
using PVeterianaria.Core.Mapeadores;
using PVeterianaria.Infraestructura.Data;
using PVeterianaria.Infraestructura.Repositorio;
using PVeterinaria.Infraestructura.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PVeterianaria.Presentacion.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VeterinariosController : ControllerBase
    {
        private readonly IVeterinarioRepositorio _context;

        public VeterinariosController(IVeterinarioRepositorio context)
        {
            this._context = context;
        }


        // GET: api/Veterinarios/5
        [HttpGet("GETVeterinario")]
        public async Task<ActionResult<List<Veterinario>>> GetVeterinarioActivos()
        {
            var veterinarios = await _context.GetVeterinariosActivos();
            return Ok(veterinarios);
        }
        //[HttpGet("Deshabilitados")]
        //public async Task<ActionResult<List<Veterinario>>> GetVeterinarioDeshabilitados()
        //{

        //    return await (from v in _context.Veterinario
        //                  where v.Estado == "Deshabilitado"
        //                  select v).ToListAsync();
        //}
        // PUT: api/Veterinarios/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("PUTparacambiarlosdatosdelveterinario")]
        public async Task<IActionResult> PutVeterinario(string nombre, string apellido, string telefono, string ci, string especilaidad, string correo, decimal sueldo,string nuevoci)
        {

            return Ok(await _context.PutAnimal(nombre, apellido, telefono, ci, especilaidad, correo, sueldo, nuevoci));
        }

        // POST: api/Veterinarios
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost("PostVeterinario")]
        public async Task<ActionResult<Veterinario>> PostVeterinario(VeterinarioDTO modelo)
        {

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var creado = await _context.PostVeterinario(modelo);

            return Ok("Usuario creado correctamente");
        }

        // DELETE: api/Veterinarios/5
        [HttpDelete("DeleteVeterinario")]
        public async Task<IActionResult> DeleteVeterinario(DeleteVeterinarioDTO dto)
        {
            var resultado = await _context.DeleteVeterinario(dto);

            if (resultado == null)
                return NotFound(new { mensaje = "No existe registro con ese ci." });

            return Ok(new { mensaje = "Veterinario deshabilitada", data = resultado });
        }

        //private bool VeterinarioExists(int id)
        //{
        //    return _context.Veterinario.Any(e => e.IdVeterinario == id);
        //}
    }
}
