using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindNetEF.Models
{
    public class Address
    {
        public int AddressId { get; set; }
        public string Street { get; set; }
        public string StreetNumber { get; set; }

        //one to one relation
        //cam tras de par dar sa zicem ca o firma are o singura adresa
        //Company este PRINCIPAL
        //Address este DEPENDENT
        public Company Company { get; set; }
    }
}
