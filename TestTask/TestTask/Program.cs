
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using TestTask;
using TestTask.Interfaces;
using TestTask.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
string connection = "Server=.;Database=TestDB;Trusted_Connection=True;";
builder.Services.AddDbContext<Context>(options => options.UseSqlServer(connection));
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

//app.UseAuthorization();

app.UseRouting();


app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();
