using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTrailer.Domain.ValueObjects
{
    public class RentalPeriod
    {
        public DateTime StartTime { get; private set; }
        public DateTime EndTime { get; private set; }

        public RentalPeriod(DateTime startTime, DateTime endTime)
        {
            if (endTime <= startTime)
                throw new ArgumentException("End time must be after start time");
            StartTime = startTime;
            EndTime = endTime;
        }

        public int GetDaysRented()
        {
            return (EndTime - StartTime).Days;
        }
    }
}

