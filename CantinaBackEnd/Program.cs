using CantinaBackEnd.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle


builder.Services.AddCors(options => options.AddDefaultPolicy(builder =>
{
    builder
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader();
}
));



// Obtem a string de conexao corretamente
var connection = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<MySQLContext>(options =>
    options.UseMySql(connection, new MySqlServerVersion(new Version(8, 0, 29)),
        mysqlOptions => mysqlOptions.EnableRetryOnFailure(
            maxRetryCount: 5, // N�mero maximo de tentativas de reconex�o
            maxRetryDelay: TimeSpan.FromSeconds(10), // Tempo maximo de espera entre as tentativas
            errorNumbersToAdd: null)) // Numeros de erro adicionais para considerar como falhas transitorias
    .EnableSensitiveDataLogging() // Para logs detalhados
    .EnableDetailedErrors());


builder.Services.AddRouting();
builder.Services.AddControllers();

builder.Services.AddApiVersioning();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1",
        new OpenApiInfo
        {
            Title = "WebApiCadastro",
            Version = "v1",
            Description = "API para cadastro de pessoas e livros",
            Contact = new OpenApiContact
            {
                Name = "Danilo",
                Email = "danilo.h.araujo@gmail.com",
                Url = new Uri("https://github.com/Daniloha/WebAPIAspNetCore")
            }
        });
});

var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
