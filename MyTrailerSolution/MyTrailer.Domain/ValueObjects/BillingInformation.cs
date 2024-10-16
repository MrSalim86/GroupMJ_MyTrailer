using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTrailer.Domain.ValueObjects
{
    public class BillingInformation
    {
        public Address BillingAddress { get; private set; }
        public string PaymentTerms { get; private set; }
        public string AccountNumber { get; private set; }
        public string VATNumber { get; private set; }

        public BillingInformation(Address billingAddress, string paymentTerms, string accountNumber, string vatNumber)
        {
            BillingAddress = billingAddress;
            PaymentTerms = paymentTerms;
            AccountNumber = accountNumber;
            VATNumber = vatNumber;
        }

        // Override Equals and GetHashCode to ensure equality is based on values
        public override bool Equals(object obj)
        {
            if (obj is not BillingInformation other) return false;
            return BillingAddress.Equals(other.BillingAddress) &&
                   PaymentTerms == other.PaymentTerms &&
                   AccountNumber == other.AccountNumber &&
                   VATNumber == other.VATNumber;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(BillingAddress, PaymentTerms, AccountNumber, VATNumber);
        }
    }
}
