using MyTrailer.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTrailer.Domain.Entities
{
    public class Rental
    {
        public Guid Id { get; private set; }
        public Guid TrailerId { get; private set; }
        public Guid CustomerId { get; private set; }
        public RentalPeriod RentalPeriod { get; private set; }
        public RentalFees RentalFees { get; private set; }
        public InsuranceDetails InsuranceDetails { get; private set; }
        public string Status { get; private set; }

        public Rental(Guid id, Guid trailerId, Guid customerId, RentalPeriod rentalPeriod, InsuranceDetails insuranceDetails)
        {
            Id = id;
            TrailerId = trailerId;
            CustomerId = customerId;
            RentalPeriod = rentalPeriod;
            InsuranceDetails = insuranceDetails;
            RentalFees = new RentalFees();
            Status = "Active";
        }

        public void CalculateFees(decimal dailyRate, decimal insuranceFee)
        {
            var daysRented = RentalPeriod.GetDaysRented();
            RentalFees.CalculateTotalFees(daysRented, dailyRate, insuranceFee, InsuranceDetails.IsInsurancePurchased);
        }

        public void MarkCompleted()
        {
            Status = "Completed";
        }
    }
}
