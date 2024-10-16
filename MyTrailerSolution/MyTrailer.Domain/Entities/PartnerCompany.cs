using MyTrailer.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTrailer.Domain.Entities
{
    public class PartnerCompany
    {
        public Guid Id { get; private set; }
        public string CompanyName { get; private set; }
        public BillingInformation BillingInformation { get; private set; }
        public List<Location> Locations { get; private set; }

        public PartnerCompany(Guid id, string companyName, BillingInformation billingInformation)
        {
            Id = id;
            CompanyName = companyName;
            BillingInformation = billingInformation;
            Locations = new List<Location>();
        }

        public void AddLocation(Location location)
        {
            Locations.Add(location);
        }

        public void UpdateBillingInformation(BillingInformation newBillingInformation)
        {
            BillingInformation = newBillingInformation;
        }
    }
}
