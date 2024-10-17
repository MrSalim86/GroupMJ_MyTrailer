using MyTrailer.Domain.Entities;


namespace MyTrailer.Domain.Ports
{
    public interface ICustomerRepository
    {
        Customer GetById(Guid customerId);
        void Add(Customer customer);
        void Update(Customer customer);
    }
}
