using MyTrailer.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTrailer.Domain.Services
{
    public class TrailerAvailabilityService
    {
        public bool IsTrailerAvailable(Trailer trailer, DateTime startDate, DateTime endDate)
        {
            // Assuming that the Trailer class has a list of current rentals or a status flag
            if (trailer.Status != "Available")
            {
                return false;  // If the trailer is marked unavailable (rented or maintenance)
            }

            // Further logic can be added to check if the trailer is booked during the given period
            // For example, checking the trailer's rental history
            return true;
        }
    }
}
