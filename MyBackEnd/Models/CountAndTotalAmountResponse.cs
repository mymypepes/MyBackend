using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBackEnd.Models
{
    public class CountAndTotalAmountResponse
    {
        public double TotalAmount { get; set; }
        public int Count { get; set; }

        public CountAndTotalAmountResponse(double totalAmount, int count)
        {
            this.TotalAmount = totalAmount;
            this.Count = count;
        }
    }
}
