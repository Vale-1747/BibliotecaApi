//comandos para bajar del repositorio remoto:
//git remote -v -- Para ver los repositorios remotos
//git pull --para unir lo de el profe con mi verxion
//git fetch -- revisar su subio algn cambia antes de unirlo con el mio

using BibliotecaApi.Services;
using BibliotecaApi.Interfaces;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
//agrego controllers
builder.Services.AddControllers();

builder.Services.AddScoped<ILibroService, LibroService>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();


app.MapGet("/hello", () => "Hello World!")
    .WithName("HelloWorld");

app.MapGet("/echo/{message}", (string message) => $"Echo: {message}")
    .WithName("EchoMessage");
    
app.MapControllers();
app.Run();


