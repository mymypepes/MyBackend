using System;
using System.Collections.Generic;

#nullable disable

namespace MyBackEnd.Models
{
    public partial class Ticket
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double? Price { get; set; }
        public int? CustomerId { get; set; }
        public int? FlightId { get; set; }
        public DateTime? DateBooking { get; set; }
    }
}
