using Shared.IdGenerator;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<ConsoleLogger>();
builder.Services.AddTransient<IdGenerator>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/lifetime", (IdGenerator idGenerator, ConsoleLogger consoleLogger) =>
    {
        var id = idGenerator.Guid;
        consoleLogger.Log($"Lifetime endpoint got ID {id}");
    })
    .WithName("Lifetime Example")
    .WithOpenApi();

app.Run();