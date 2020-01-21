using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindNetEF.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string ReferenceNumber { get; set; }
        public decimal Price { get; set; }
        public Currency Currency { get; set; }

        //many to many relation
        public ICollection<Trip> Trips { get; set; }

        //one to many relation
        public Company Client { get; set; }
    }
}
