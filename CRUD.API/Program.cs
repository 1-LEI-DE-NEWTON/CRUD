using CRUD.Infra.Context;
using CRUD.Infra.Interfaces;
using CRUD.Infra.Repositories;
using CRUD.Services.Interfaces;
using CRUD.Services.Services;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//AutoMapper
builder.Services.AddAutoMapper(typeof(Program).Assembly);

//user dbcontext mysql
var connectionString = "server=localhost;database=CRUDteste;uid=root;";
builder.Services.AddDbContext<DataContext>(options =>
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//AddScoped for AlunoServices
builder.Services.AddScoped<IAlunoServices, AlunoServices>();
builder.Services.AddScoped<IAlunoRepository, AlunoRepository>();

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
