using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindNetEF.Models
{
    public class Company
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }

        //one to one relation
        //cam tras de par dar sa zicem ca o firma are o singura adresa
        //Company este PRINCIPAL
        //Address este DEPENDENT
        public Address Address { get; set; }

        //one to many relation
        //poate fi exclus daca nu se doreste ca fiecare firma sa stie de comenzi
        public ICollection<Order> Orders { get; set; }

        //many to many relation
        public ICollection<Trip> Trips { get; set; }
    }
}
