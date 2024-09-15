using Microsoft.EntityFrameworkCore;
using TaskHive_ProjectService.Repositories;
using TaskHive_ProjectService.Repositories.Interface;
using TaskHive_ProjectService.Services;
using TaskHive_ProjectService.Services.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var configuration = builder.Configuration;

// ----- Azure Production -----
//var azureConnectionString = Environment.GetEnvironmentVariable("AzureSQLConnection");

//builder.Services.AddDbContext<TaskHive_ProjectService.AppDbContext>( options =>
//    options.UseSqlServer(azureConnectionString));

// ----- Local Development -----
builder.Services.AddDbContext<TaskHive_ProjectService.AppDbContext>(options =>
    options.UseSqlServer(configuration.GetConnectionString("DockerSQLConnection")));

builder.Services.AddScoped<IProjectService, ProjectService>();
builder.Services.AddScoped<IProjectRepository, ProjectRepository>();


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
