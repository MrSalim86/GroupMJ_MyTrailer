using MyTrailer.Domain.Entities;
using MyTrailer.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTrailer.Domain.Aggregates
{
    public class PartnerCompanyAggregate
    {
        public PartnerCompany PartnerCompany { get; private set; }

        public PartnerCompanyAggregate(PartnerCompany partnerCompany)
        {
            PartnerCompany = partnerCompany;
        }

        // Update billing information
        //public void UpdateBillingInformation(BillingInformation billingInformation)
        //{
        //    PartnerCompany.BillingInformation = billingInformation;
        //}

        // Other PartnerCompany behavior (e.g., add locations)
    }
}


