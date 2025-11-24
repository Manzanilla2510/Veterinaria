using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace PVeterianaria.Migrations
{
    /// <inheritdoc />
    public partial class m1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Alimentacion",
                columns: table => new
                {
                    IdAlimentacion = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CodigoAnimal = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false),
                    NombreAlimento = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false),
                    Tipo = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false),
                    Descripcion = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false),
                    Fecha = table.Column<DateOnly>(type: "date", nullable: false),
                    Cantidad = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    Estado = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alimentacion", x => x.IdAlimentacion);
                });

            migrationBuilder.CreateTable(
                name: "Animal",
                columns: table => new
                {
                    IdAnimal = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CodigoAnimal = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false),
                    Peso = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    Edad = table.Column<int>(type: "integer", nullable: false),
                    Raza = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Fecha_Ingreso = table.Column<DateOnly>(type: "date", nullable: false),
                    Estado = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animal", x => x.IdAnimal);
                });

            migrationBuilder.CreateTable(
                name: "Herramientas",
                columns: table => new
                {
                    IdHerramienta = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    codigoHerramienta = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false),
                    Nombre = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false),
                    Descripcion = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Estado = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Herramientas", x => x.IdHerramienta);
                });

            migrationBuilder.CreateTable(
                name: "Medicamentos",
                columns: table => new
                {
                    IdMedicamento = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CodigoMedicamento = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false),
                    Nombre = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false),
                    FechaVencimiento = table.Column<DateOnly>(type: "date", nullable: false),
                    Cantidad = table.Column<int>(type: "integer", nullable: false),
                    Descripcion = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false),
                    Estado = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicamentos", x => x.IdMedicamento);
                });

            migrationBuilder.CreateTable(
                name: "Producciones",
                columns: table => new
                {
                    IdProduccionLeche = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Fecha_produccion = table.Column<DateOnly>(type: "date", nullable: false),
                    Cantidad_Leche = table.Column<decimal>(type: "numeric(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producciones", x => x.IdProduccionLeche);
                });

            migrationBuilder.CreateTable(
                name: "Revisiones",
                columns: table => new
                {
                    IdRevision = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Fecha_Revision = table.Column<DateOnly>(type: "date", nullable: false),
                    Condicion = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    FechaRecuperacion = table.Column<DateOnly>(type: "date", nullable: false),
                    Diagnostico = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Temperatura = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    PesoActual = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    Tratamiento = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Observaciones = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Revisiones", x => x.IdRevision);
                });

            migrationBuilder.CreateTable(
                name: "RevisionHerramientas",
                columns: table => new
                {
                    IdRevisionHeramienta = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Utilidad = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RevisionHerramientas", x => x.IdRevisionHeramienta);
                });

            migrationBuilder.CreateTable(
                name: "RevisionMedicamentos",
                columns: table => new
                {
                    IdRevisionMedicamento = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DosisMedicada = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RevisionMedicamentos", x => x.IdRevisionMedicamento);
                });

            migrationBuilder.CreateTable(
                name: "TiposHerramienta",
                columns: table => new
                {
                    IdTipoHerramienta = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nombre = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposHerramienta", x => x.IdTipoHerramienta);
                });

            migrationBuilder.CreateTable(
                name: "TiposMedicamento",
                columns: table => new
                {
                    IDTipoMedicamento = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NombreTipo = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposMedicamento", x => x.IDTipoMedicamento);
                });

            migrationBuilder.CreateTable(
                name: "Veterinario",
                columns: table => new
                {
                    IdVeterinario = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nombre = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Apellido = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Telefono = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Ci = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Especialidad = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Correo = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Sueldo = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    Estado = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veterinario", x => x.IdVeterinario);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alimentacion");

            migrationBuilder.DropTable(
                name: "Animal");

            migrationBuilder.DropTable(
                name: "Herramientas");

            migrationBuilder.DropTable(
                name: "Medicamentos");

            migrationBuilder.DropTable(
                name: "Producciones");

            migrationBuilder.DropTable(
                name: "Revisiones");

            migrationBuilder.DropTable(
                name: "RevisionHerramientas");

            migrationBuilder.DropTable(
                name: "RevisionMedicamentos");

            migrationBuilder.DropTable(
                name: "TiposHerramienta");

            migrationBuilder.DropTable(
                name: "TiposMedicamento");

            migrationBuilder.DropTable(
                name: "Veterinario");
        }
    }
}
