using MyTrailer.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTrailer.Domain.Aggregates
{
    public class LocationAggregate
    {
        public Location Location { get; private set; }

        public LocationAggregate(Location location)
        {
            Location = location;
        }

        // Add trailer to the location
        public void AddTrailerToLocation(Trailer trailer)
        {
            Location.AddTrailer(trailer);
            trailer.UpdateLocation(Location);
        }

        // Remove trailer from the location
        public void RemoveTrailerFromLocation(Trailer trailer)
        {
            Location.Trailers.Remove(trailer);
        }
    }
}

