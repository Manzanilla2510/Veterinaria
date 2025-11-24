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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PVeterianaria.Presentacion.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalsController : ControllerBase
    {
        private readonly IAnimalRepositorio _context;

        public AnimalsController(IAnimalRepositorio context)
        {
            this._context = context;
        }

        // GET: api/Animals
        //Endpoint para obtener los animales que estan en tratmiento
        [HttpGet("GetAnimalesEnTratamiento")]
        public async Task<ActionResult<IEnumerable<Animal>>> GetAnimalesEnTratamiento()
        {
           return Ok(await _context.GetAnimalesEnTratamientos());
        }
        //[HttpGet("Deshabilitdos")]
        //public async Task<ActionResult<IEnumerable<Animal>>> GetAnimalesDeshabilitados()
        //{
        //    return await (from a in _context.Animal
        //                  where a.Estado == "Deshabilitado"
        //                  select a).ToListAsync();
        //}

        // GET: api/Animals/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<Animal>> GetAnimal(int id)
        //{
        //    var animal = await _context.Animal.FindAsync(id);

        //    if (animal == null)
        //    {
        //        return NotFound();
        //    }

        //    return animal;
        //}

        // PUT: api/Animals/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("PutAnimal")]
        public async Task<IActionResult> CambiarEstado([FromBody] PutAnimalDTO dto)
        {
            var result = await _context.PutAnimal(dto);

            if (result == null)
                return NotFound(new { mensaje = "No existe animal con ese código." });

            return Ok(new { mensaje = "Estado actualizado correctamente", data = result });
        }


        // POST: api/Animals
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<Animal>> PostAnimal(string codigoAnimal, decimal peso, int edad, string raza, DateOnly fechaIngreso)
        //{
        //    Animal animales = new Animal
        //    {
        //        CodigoAnimal = codigoAnimal,
        //        Peso = peso,
        //        Edad = edad,
        //        Raza = raza,
        //        Fecha_Ingreso = fechaIngreso,

        //    };
        //    _context.Animal.Add(animales);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetAnimal", new { id = animales.IdAnimal }, animales);
        //}

        // DELETE: api/Animals/5
        //[HttpDelete("{codigoAnimal}")]
        //public async Task<IActionResult> DeleteAnimales(string codigoAnimal)
        //{
        //    var animales = await (from c in _context.Animal
        //                          where c.CodigoAnimal == codigoAnimal
        //                          select c).FirstOrDefaultAsync();
        //    if (animales == null)
        //    {
        //        return NotFound();
        //    }
        //    animales.Estado = "Deshabilitado";
        //    await _context.SaveChangesAsync();
        //    return NoContent();
        //}

        //private bool AnimalExists(int id)
        //{
        //    return _context.Animal.Any(e => e.IdAnimal == id);
        //}
    }
}
