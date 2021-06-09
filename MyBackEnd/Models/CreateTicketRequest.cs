using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBackEnd.Models
{
    public class CreateTicketRequest
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int CustomerId { get; set; }
        public int FlightId { get; set; }
    }
}
