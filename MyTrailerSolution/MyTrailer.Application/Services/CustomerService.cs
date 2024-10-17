using MyTrailer.Domain.Entities;
using MyTrailer.Domain.Ports;
using MyTrailer.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTrailer.Application.Services
{
    public class CustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        // Use case: Register a new customer
        public void RegisterCustomer(string name, string email, Address address)
        {
            // Domain logic: create a new customer entity
            var customer = new Customer(Guid.NewGuid(), name, email, address);

            // Use the repository (port) to save the customer
            _customerRepository.Add(customer);
        }

        // Use case: Retrieve a customer by ID
        public Customer GetCustomerById(Guid customerId)
        {
            return _customerRepository.GetById(customerId);
        }

        // Use case: Update customer information
        public void UpdateCustomer(Guid customerId, string name, Address newAddress)
        {
            var customer = _customerRepository.GetById(customerId);
            customer.UpdateAddress(newAddress);
            customer.UpdateName(name); // Assuming there's logic to update the name
            _customerRepository.Update(customer);
        }
    }
}
