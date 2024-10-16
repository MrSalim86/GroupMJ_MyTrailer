using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTrailer.Domain.ValueObjects
{
    public class TrailerSpecifications
    {
        public decimal WeightCapacity { get; private set; }
        public string Size { get; private set; }
        public string Type { get; private set; }

        public TrailerSpecifications(decimal weightCapacity, string size, string type)
        {
            WeightCapacity = weightCapacity;
            Size = size;
            Type = type;
        }
    }
}

