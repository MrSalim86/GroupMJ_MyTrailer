using MyTrailer.Domain.Entities;
using MyTrailer.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTrailer.Domain.Aggregates
{
    public class CustomerAggregate
    {
        public Customer Customer { get; private set; }

        public CustomerAggregate(Customer customer)
        {
            Customer = customer;
        }

        // Customer starts a new rental
        public Rental CreateRental(Guid trailerId, RentalPeriod rentalPeriod, InsuranceDetails insuranceDetails)
        {
            var rental = new Rental(Guid.NewGuid(), trailerId, Customer.Id, rentalPeriod, insuranceDetails);
            Customer.AddRentalToHistory(rental);
            return rental;
        }

        // Update customer address
        public void UpdateCustomerAddress(Address newAddress)
        {
            Customer.UpdateAddress(newAddress);
        }

       
    }
}

