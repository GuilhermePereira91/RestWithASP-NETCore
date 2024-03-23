using EvolveDb;
using Microsoft.EntityFrameworkCore;
using Microsoft.Net.Http.Headers;
using MySqlConnector;
using RestWithASPNETUdemy.Business;
using RestWithASPNETUdemy.Business.Implemetations;
using RestWithASPNETUdemy.Model.Context;
using RestWithASPNETUdemy.Repository;
using RestWithASPNETUdemy.Repository.Generic;
using RestWithASPNETUdemy.Repository.Implemetations;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

var connection = builder.Configuration["MySQLConnection:MySQLConnectionString"];
builder.Services.AddDbContext<MySQLContext>(options => options.UseMySql(connection, new MySqlServerVersion(new Version(8, 0, 29))));

if (builder.Environment.IsDevelopment())
{
    MigratedDatabase(connection);
}

builder.Services.AddMvc(options =>
{
    options.RespectBrowserAcceptHeader = true;
    options.FormatterMappings.SetMediaTypeMappingForFormat("xml", MediaTypeHeaderValue.Parse("application/xml"));
    options.FormatterMappings.SetMediaTypeMappingForFormat("xml", MediaTypeHeaderValue.Parse("application/json"));
})
    .AddXmlSerializerFormatters();

builder.Services.AddApiVersioning();

//Injeção de Dependencia
builder.Services.AddScoped<IPersonBusiness, PersonBusinessImplemetation>();
builder.Services.AddScoped<IBookBusiness, BookBusinessImplemetation>();
builder.Services.AddScoped(typeof(IRepository<>), typeof(GenericRepository<>));

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

void MigratedDatabase(string connection)
{
	try
	{
        var evolveConnection = new MySqlConnection(connection);
        var evolve = new Evolve(evolveConnection, Log.Information)
        {
            Locations = new List<string> { "db/migrations", "db/dataset" },
            IsEraseDisabled = true,
        };
        evolve.Migrate();
    }
	catch (Exception ex)
	{
        Log.Error("Database migration failed", ex);
        throw;
	}
}
