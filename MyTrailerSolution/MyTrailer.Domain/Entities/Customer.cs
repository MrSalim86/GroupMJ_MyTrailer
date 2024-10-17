using MyTrailer.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MyTrailer.Domain.Entities
{
    public class Customer
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public Address Address { get; private set; }
        public List<Rental> RentalHistory { get; private set; }
       

        public Customer(Guid id, string name, string email, Address address)
        {
            Id = id;
            Name = name;
            Email = email;
            Address = address;
            RentalHistory = new List<Rental>();
           
        }

        // Add the UpdateAddress method

        public void UpdateAddress(Address newAddress)
        {
            Address = newAddress ?? throw new ArgumentNullException(nameof(newAddress));
        }

        // Add method to update the name
        public void UpdateName(string newName)
        {
            if (string.IsNullOrWhiteSpace(newName))
            {
                throw new ArgumentException("Name cannot be empty", nameof(newName));
            }

            Name = newName;
        }
        public void AddRentalToHistory(Rental rental)
        {
            RentalHistory.Add(rental);
        }
    }
}
