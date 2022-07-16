using Pay.API.Data;
using Pay.API.Interfaces;
using Pay.API.ServiceExtensions;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
builder.Services.CorsPolices();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<IDataSrc, DataSrc>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseCors(ServiceExtensions.corsDev);
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();