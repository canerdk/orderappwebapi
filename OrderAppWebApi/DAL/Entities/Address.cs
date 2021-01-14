using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace OrderAppWebApi.DAL.Entities
{
    public class Address
    {
        public Address()
        {
            Members = new Collection<Member>();
            Orders = new Collection<Order>();
        }
        public int Id { get; set; }
        public string Street { get; set; }
        public string Avenue { get; set; }
        public string Neighborhood { get; set; }
        public string No { get; set; }
        public string City { get; set; }
        public string District { get; set; }

        public virtual ICollection<Member> Members { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
