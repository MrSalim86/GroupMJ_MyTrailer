using MyTrailer.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTrailer.Domain.Entities
{
    public class Trailer
    {
        public Guid Id { get; private set; }
        public TrailerSpecifications Specifications { get; private set; }
        public string Status { get; private set; }
        public Location Location { get; private set; }

        public Trailer(Guid id, TrailerSpecifications specifications, Location location)
        {
            Id = id;
            Specifications = specifications;
            Status = "Available"; // Default status
            Location = location;
        }

        public void UpdateLocation(Location newLocation)
        {
            Location = newLocation;
        }

        public void UpdateStatus(string status)
        {
            Status = status;
        }
    }
}

