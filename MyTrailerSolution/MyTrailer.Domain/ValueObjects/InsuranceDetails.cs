using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTrailer.Domain.ValueObjects
{
    public class InsuranceDetails
    {
        public string InsuranceType { get; private set; }
        public decimal Price { get; private set; }
        public bool IsInsurancePurchased { get; private set; }

        public InsuranceDetails(string insuranceType, decimal price, bool isInsurancePurchased)
        {
            InsuranceType = insuranceType;
            Price = price;
            IsInsurancePurchased = isInsurancePurchased;
        }
    }
}

