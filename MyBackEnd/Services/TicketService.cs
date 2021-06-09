using MyBackEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBackEnd.Services
{
    public interface TicketService
    {
        public List<Ticket> FindAll();
        public List<Ticket> Search(double min, double max);
        public List<Ticket> SearchByCustomerId(int customerId);
        public  bool  Create(CreateTicketRequest request);
        public CountAndTotalAmountResponse CountAndTotalAmount(int customerId);
        public List<Ticket> SearchByMonth(string year, string month);
    }
}
