﻿using Microsoft.EntityFrameworkCore;

namespace Lab13C.Model
{
    public class InvoiceContext: DbContext
    {

        public InvoiceContext(DbContextOptions<InvoiceContext> options)
        : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Detail> Details { get; set; }
        public DbSet<Customer> Customers { get; set; }

    }
}
