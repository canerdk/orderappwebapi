﻿using Microsoft.EntityFrameworkCore;
using OrderAppWebApi.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderAppWebApi.DAL.Context
{
    public class OrderAppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .; Database = OrderApp; Trusted_Connection=True;");
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

    }
}
