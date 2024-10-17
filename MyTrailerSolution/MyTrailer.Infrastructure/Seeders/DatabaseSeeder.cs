using MyTrailer.Domain.Entities;
using MyTrailer.Infrastructure.Persistence;
using MyTrailer.Domain.ValueObjects;

namespace MyTrailer.Infrastructure.Seeders
{
    public static class DatabaseSeeder 
    {
        public static void Seed(MyTrailerDbContext context)
        {
            // Add dummy customer data
            var customer1 = new Customer(Guid.NewGuid(), "John Doe", "john@example.com", new Address("123 Main St", "Sample City", "12345"));
            var customer2 = new Customer(Guid.NewGuid(), "Jane Doe", "jane@example.com", new Address("456 Oak St", "Example City", "67890"));

            context.Customers.Add(customer1);
            context.Customers.Add(customer2);

            // Save the data into the in-memory database
            context.SaveChanges();
        }
    }
}
