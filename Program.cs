using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PVeterianaria.Core.Interfaces;
using PVeterianaria.Infraestructura.Data;
using PVeterianaria.Infraestructura.Repositorio;
using PVeterinaria.Infraestructura.Repositorio;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<PVeterianariaContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("PVeterianariaContext") ?? throw new InvalidOperationException("Connection string 'PVeterianariaContext' not found.")));


// Add services to the container.

builder.Services.AddCors(options =>
{
    options.AddPolicy("Veterinaria",
        builder =>
        {
            builder.AllowAnyOrigin()
                   .AllowAnyMethod()
                   .AllowAnyHeader();
        });
});


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IAnimalRepositorio, AnimalRepositorio>();
builder.Services.AddScoped<IVeterinarioRepositorio, VeterinarioRepositorio>();
builder.Services.AddScoped<IRevisionRepositorio, RevisionRepositorio>();
builder.Services.AddScoped<IProduccionRepositorio, ProduccionLecheRepositorio>();
builder.Services.AddScoped<IMedicamentoRepositorio,MedicamentoRepositorio>();
builder.Services.AddScoped<IAlimentacionRepositorio, AlimentoRepositorio>();
builder.Services.AddScoped<IHerramientaRepositorio, HerramientaRepositorio>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("Veterinaria");

app.UseAuthorization();

app.MapControllers();

app.Run();
