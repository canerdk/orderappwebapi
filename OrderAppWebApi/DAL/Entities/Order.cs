﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace OrderAppWebApi.DAL.Entities
{
    public class Order
    {
        public Order()
        {
            OrderDetails = new Collection<OrderDetail>();
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public DateTime CreatedDate { get; set; }
        public string IPAddress { get; set; }
        public int? Status { get; set; }
        public string Note { get; set; }
        public string Address { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
