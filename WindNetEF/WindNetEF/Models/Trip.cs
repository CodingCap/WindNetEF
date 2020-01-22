using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindNetEF.Models
{
    public class Trip
    {
        public int TripId { get; set; }
        public string TripReference { get; set; }
        public decimal Price { get; set; }
        public Currency Currency { get; set; }

        //many to many relation
        public ICollection<Order> Orders { get; set; }

        //FK pt carier
        public int CarrierId { get; set; }
        //one to many relation
        public Company Carrier { get; set; }
    }
}
