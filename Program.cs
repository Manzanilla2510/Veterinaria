using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PVeterianaria.Core.Interfaces;
using PVeterianaria.Infraestructura.Data;
using PVeterianaria.Infraestructura.Repositorio;
using PVeterinaria.Infraestructura.Repositorio;

var url = Environment.GetEnvironmentVariable("DATABASE");
Console.Write($"La coneccion es esta {url}");

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<PVeterianariaContext>(options =>
    options.UseNpgsql(url));

// Add services to the container.

builder.WebHost.UseUrls("http://0.0.0.0:8080");

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
