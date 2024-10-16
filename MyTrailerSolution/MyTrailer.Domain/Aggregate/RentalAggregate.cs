using MyTrailer.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTrailer.Domain.Aggregates
{
    public class RentalAggregate
    {
        public Rental Rental { get; private set; }
        public Customer Customer { get; private set; }
        public Trailer Trailer { get; private set; }

        public RentalAggregate(Customer customer, Trailer trailer, Rental rental)
        {
            Customer = customer;
            Trailer = trailer;
            Rental = rental;
        }

        // Confirm rental and calculate fees
        public void ConfirmRental(decimal dailyRate, decimal insuranceFee)
        {
            Rental.CalculateFees(dailyRate, insuranceFee);
        }

        // Mark the rental as completed
        public void CompleteRental()
        {
            Rental.MarkCompleted();
            Trailer.UpdateStatus("Available");
        }
    }
}

