using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using TravelBlogAPI.Data;
using TravelBlogAPI.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

// Correct the DbContext registration
builder.Services.AddDbContext<TravelBlogContext>(opt =>
    opt.UseInMemoryDatabase("TravelBlog"));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
