using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSwaggerGen(c => { c.SwaggerDoc("v1", new() { Title = "Komoot Fitbit Thing API", Version = "v1" }); });
builder.Services.AddControllers();

builder.Logging.ClearProviders();
builder.Logging.AddConsole();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Komoot Fitbit Thing API v1"));

app.UseHttpsRedirection();
app.UseAuthorization();

app.MapGet("/", () => "Alright");
app.MapGet("/auth/redirect", () => "Authy");

app.Run();
