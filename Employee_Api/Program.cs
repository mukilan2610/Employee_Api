using Employee_Api.Controllers;
using Employee_Api.Services;
using Employee_Api.Models;
using Employee_Api.Repositores;
using FluentAssertions.Common;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using System.Configuration;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IEmployeeRepositores, EmployeeRepositores>();
// Add services to the container.
//builder.Services.AddTransient<IEmployeeServices, EmployeeService>();
builder.Services.AddControllers();
//builder.Services.AddScoped<IEmployeeRepositores>();


//builder.Services.AddScoped<IEmployeeRepositores, EmployeeRepositores>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<EmployeeDBContext>(Options => Options.UseMySQL(builder.Configuration.GetConnectionString("mukilan")));
//builder.Services.AddTransient<IEmployeeServices, EmployeeService>();
//builder.Services.AddScoped<IEmployeeRepositores, EmployeeRepositores>();
//builder.Services.AddSingleton<IEmployeeServices, EmployeeService>();
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
