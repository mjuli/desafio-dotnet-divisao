using Microsoft.AspNetCore.Mvc;
using Calc_api;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/dividir", ([FromQuery(Name = "dividendo")] int dividendo, [FromQuery(Name = "divisor")] int divisor) =>
{
    var result = (double)dividendo / (double)divisor;

    return new Response(result, "");
});

app.Run();

