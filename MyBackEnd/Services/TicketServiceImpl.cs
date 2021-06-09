using MyBackEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBackEnd.Services
{
    public class TicketServiceImpl : TicketService
    {
        private DatabaseContext db;
        public TicketServiceImpl(DatabaseContext _db)
        {
            db = _db;
        }

        public CountAndTotalAmountResponse CountAndTotalAmount(int customerId)
        {
            double totalAmount = 0;
            List<Ticket> listTicket = db.Tickets.Where(p => p.CustomerId == customerId).ToList();
            foreach (Ticket ticket in listTicket)
            {
                totalAmount += (double)ticket.Price;
            }
            int count = listTicket.Count;
            return new CountAndTotalAmountResponse(totalAmount, count);
        }

        public bool Create(CreateTicketRequest request)
        {
            try
            {
                Ticket ticket = new Ticket();
                ticket.Name = request.Name;
                ticket.Price = request.Price;
                ticket.CustomerId = request.CustomerId;
                ticket.FlightId = request.FlightId;
                ticket.DateBooking = DateTime.Now;
                db.Tickets.Add(ticket);
                db.SaveChanges();
                return true;
            } catch (Exception e)
            {
                return false;
            }
        }

        public List<Ticket> FindAll()
        {
            return db.Tickets.ToList();
        }

        public List<Ticket> Search(double min, double max)
        {
            return db.Tickets.Where(p => p.Price >= min && p.Price <= max).ToList();
        }

        public List<Ticket> SearchByCustomerId(int customerId)
        {
            return db.Tickets.Where(p => p.CustomerId == customerId).ToList();
        }

        public List<Ticket> SearchByMonth(string year, string month)
        {
            DateTime startDate = new DateTime(Int32.Parse(year), Int32.Parse(month), 1);
            DateTime endDate = new DateTime(Int32.Parse(year), Int32.Parse(month), 30);
            return db.Tickets.Where(p => p.DateBooking >= startDate && p.DateBooking <= endDate).ToList();
        }
        
    }
}
