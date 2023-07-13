using Microsoft.EntityFrameworkCore;
using ProyectoDinamyt.Repository;
using ProyectoDinamyt.Repository.Imp;
using ProyectoDinamyt.Repository.Acess;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<BuscadorDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("MyConnection")));

builder.Services.AddTransient<IUserValidationRepository, UserValidationRespository>();


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
