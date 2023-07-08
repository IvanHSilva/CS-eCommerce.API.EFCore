global using eCommerce.Models;
using eCommerce.API.Database;
using eCommerce.API.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

#region ConfigureService()
// Add services to the container.

builder.Services.AddControllers().AddJsonOptions(op => 
op.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles );
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<eCommerceContext>(options => options.UseSqlServer(
    configuration.GetConnectionString("eCommerce")));
builder.Services.AddScoped<IUserRepository, UserRepository>();
#endregion

var app = builder.Build();

#region Configure()
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) {
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
#endregion