using RestWithASPNETUdemy.Services.Implemetations;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//Inje��o de Dependencia
builder.Services.AddScoped<IPersonService, PersonServiceImplemetation>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
