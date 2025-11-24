using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PVeterianaria.Core.Entidades;

namespace PVeterianaria.Infraestructura.Data
{
    public class PVeterianariaContext : DbContext
    {
        public PVeterianariaContext (DbContextOptions<PVeterianariaContext> options)
            : base(options)
        {
        }
        public DbSet<Animal> Animal { get; set; }
        public DbSet<Veterinario> Veterinario { get; set; }
        public DbSet<Revision> Revisiones { get; set; }
        public DbSet<Medicamento> Medicamentos { get; set; }
        public DbSet<TipoMedicamento> TiposMedicamento { get; set; }
        public DbSet<Herramienta> Herramientas { get; set; }
        public DbSet<TipoHerramienta> TiposHerramienta { get; set; }
        public DbSet<RevisionMedicamento> RevisionMedicamentos { get; set; }
        public DbSet<RevisionHerramienta> RevisionHerramientas { get; set; }
        public DbSet<ProduccionLeche> Producciones { get; set; }

        internal async Task<object?> GetRevisiones()
        {
            throw new NotImplementedException();
        }
        public DbSet<Alimentacion> Alimentacion { get; set; } 
    }
}
