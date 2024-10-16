using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTrailer.Domain.ValueObjects
{
    public class PaymentInformation
    {
        public decimal Amount { get; private set; }
        public string PaymentMethod { get; private set; }
        public DateTime PaymentDate { get; private set; }

        public PaymentInformation(decimal amount, string paymentMethod, DateTime paymentDate)
        {
            Amount = amount;
            PaymentMethod = paymentMethod;
            PaymentDate = paymentDate;
        }
    }
}

