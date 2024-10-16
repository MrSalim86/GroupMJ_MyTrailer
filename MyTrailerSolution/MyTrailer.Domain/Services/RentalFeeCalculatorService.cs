using MyTrailer.Domain.Entities;

namespace MyTrailer.Domain.Services
{
    public class RentalFeeCalculatorService
    {
        private const decimal InsuranceFee = 50m;  // Example insurance fee per rental

        // Calculate the total rental fee without a daily rate
        public decimal CalculateTotalRentalFee(Rental rental)
        {
            var totalFee = 0m;  // Base rental fee is now 0, can be customized based on fixed rates, etc.

            // Apply the insurance fee if insurance is purchased
            if (rental.InsuranceDetails.IsInsurancePurchased)
            {
                totalFee += InsuranceFee;
            }

            return totalFee;
        }

        // Calculate the late fee based on a flat penalty for each late day
        public decimal CalculateLateFee(DateTime returnDate, DateTime expectedReturnDate, decimal flatLateFee)
        {
            if (returnDate > expectedReturnDate)
            {
                var lateDays = (returnDate - expectedReturnDate).Days;
                return lateDays * flatLateFee;  // Apply the flat late fee per day
            }
            return 0;
        }
    }
}
