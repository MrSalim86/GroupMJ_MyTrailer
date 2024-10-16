using MyTrailer.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTrailer.Domain.Aggregates
{
    public class TrailerAggregate
    {
        public Trailer Trailer { get; private set; }

        public TrailerAggregate(Trailer trailer)
        {
            Trailer = trailer;
        }

        // Assign trailer to a new location
        public void AssignTrailerToLocation(Location newLocation)
        {
            Trailer.UpdateLocation(newLocation);
        }

        // Update trailer status (e.g., available, rented, maintenance)
        public void UpdateTrailerStatus(string status)
        {
            Trailer.UpdateStatus(status);
        }
    }
}

