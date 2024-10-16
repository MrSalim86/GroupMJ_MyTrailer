using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTrailer.Domain.ValueObjects
{
    public class RentalFees
    {
        public decimal BaseRentalFee { get; private set; }
        public decimal LateFee { get; private set; }
        public decimal TotalFee { get; private set; }

        public RentalFees() { }

        public void CalculateTotalFees(int daysRented, decimal dailyRate, decimal insuranceFee, bool isInsurancePurchased)
        {
            BaseRentalFee = daysRented * dailyRate;
            TotalFee = BaseRentalFee + (isInsurancePurchased ? insuranceFee : 0);
        }
    }
}

