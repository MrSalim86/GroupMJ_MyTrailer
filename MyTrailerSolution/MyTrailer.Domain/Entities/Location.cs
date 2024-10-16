using MyTrailer.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MyTrailer.Domain.Entities
{
    public class Location
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public Address Address { get; private set; }
        public List<Trailer> Trailers { get; private set; }

        public Location(Guid id, string name, Address address)
        {
            Id = id;
            Name = name;
            Address = address;
            Trailers = new List<Trailer>();
        }

        public void AddTrailer(Trailer trailer)
        {
            Trailers.Add(trailer);
        }
    }
}
