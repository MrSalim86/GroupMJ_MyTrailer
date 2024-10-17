using MyTrailer.Domain.Entities;
using MyTrailer.Domain.Ports;
using MyTrailer.Domain.ValueObjects;


namespace MyTrailer.Domain.Services
{
    internal class CustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public void RegisterCustomer(string name, string email, Address address)
        {
            var customer = new Customer(Guid.NewGuid(), name, email, address);
            _customerRepository.Add(customer);
        }

        public Customer GetCustomerById(Guid customerId)
        {
            return _customerRepository.GetById(customerId);
        }
    }
}
