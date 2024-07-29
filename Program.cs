using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using TeledocWebApplication.Core;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<TeledocDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("localhostConnection"));
});

builder.Services.AddMediatR(Assembly.GetExecutingAssembly());

builder.Services.AddValidatorsFromAssemblies(new[] { Assembly.GetExecutingAssembly() });
//builder.Services.AddTransient(typeof(IPipelineBehavior<,>), typeof(IPipelineBehavior<,>));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(options =>
{
    options.AllowAnyHeader();
    options.AllowAnyMethod();
    options.AllowAnyOrigin();
});

app.UseRouting();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseCors("AllowAll");

app.Run();
