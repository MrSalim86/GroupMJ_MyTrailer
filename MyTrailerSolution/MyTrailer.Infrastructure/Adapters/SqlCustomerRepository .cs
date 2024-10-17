using MyTrailer.Domain.Entities;
using MyTrailer.Domain.Ports;
using MyTrailer.Infrastructure.Persistence;

namespace MyTrailer.Infrastructure.Adapters
{
    public class SqlCustomerRepository : ICustomerRepository
    {
        private readonly MyTrailerDbContext _context;

        public SqlCustomerRepository(MyTrailerDbContext context)
        {
            _context = context;
        }

        public Customer GetById(Guid customerId)
        {
            return _context.Customers.Find(customerId);
        }

        public void Add(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
        }

        public void Update(Customer customer)
        {
            _context.Customers.Update(customer);
            _context.SaveChanges();
        }
    }
}
