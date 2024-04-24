using Microsoft.EntityFrameworkCore;
using Weatherstation.CoreServer.Context;
using Weatherstation.CoreServer.Interfaces;
using Weatherstation.CoreServer.Repositories.Mocking;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();

builder.Services.AddDbContext<WeatherDataContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("WeatherDataDB"));
});
builder.Services.AddTransient<IEntryRepo, EntryRepo>();
builder.Services.AddTransient<IStationRepo, StationRepo>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.MapControllers();
app.UseHttpsRedirection();

app.Run();