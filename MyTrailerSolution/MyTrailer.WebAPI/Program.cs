using Microsoft.EntityFrameworkCore;
using MyTrailer.Infrastructure.Persistence;  // Your DbContext
using MyTrailer.Application.Services;       // Your services
using MyTrailer.Infrastructure.Adapters; // Your repositories
using MyTrailer.Domain.Ports;               // Your repository interfaces
using MyTrailer.Infrastructure.Seeders;     // Your seeder class

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add In-Memory Database for Entity Framework Core
builder.Services.AddDbContext<MyTrailerDbContext>(options =>
    options.UseInMemoryDatabase("MyTrailerInMemoryDb"));

// Register application services and repositories
builder.Services.AddScoped<ICustomerRepository, SqlCustomerRepository>();
builder.Services.AddScoped<CustomerService>();

// Add controllers
builder.Services.AddControllers();

var app = builder.Build();

// Seed the database
using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<MyTrailerDbContext>();
    //DatabaseSeeder.Seed(dbContext);  // Pass the DbContext to the seeder
}

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
