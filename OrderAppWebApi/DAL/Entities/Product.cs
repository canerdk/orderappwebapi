﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderAppWebApi.DAL.Entities
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? Stock { get; set; }
        public decimal Price { get; set; }
        public Guid CategoryId { get; set; }

    }
}
