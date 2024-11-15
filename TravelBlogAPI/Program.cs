using Microsoft.EntityFrameworkCore;
using TravelBlogAPI.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add DbContext with InMemoryDatabase for testing
builder.Services.AddDbContext<TravelBlogContext>(options =>
    options.UseInMemoryDatabase("TravelBlogDB")); // Replace with UseSqlServer for production

var app = builder.Build();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
