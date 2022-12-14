using System.Configuration;
using Microsoft.EntityFrameworkCore;
using SpiekBriefServer.models;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);
ConfigurationManager configuration = builder.Configuration;
// Add services to the container.
// builder.Services.AddDbContext<SchoolContext>(options =>
    // options.UseSqlServer(configuration.GetConnectionString("mainDB")));
builder.Services.AddDbContext<SchoolContext>(
    options => options.UseSqlServer(configuration.GetConnectionString("mainDB")));

builder.Services.AddControllers();
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

app.UseAuthorization();

app.MapControllers();

app.Run();
