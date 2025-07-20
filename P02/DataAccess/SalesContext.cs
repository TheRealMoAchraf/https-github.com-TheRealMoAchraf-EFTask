using Microsoft.EntityFrameworkCore;
using P02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02.DataAccess
{
    internal class SalesContext:DbContext
    {
        DbSet<Product> products {  get; set; }
        DbSet<Customer>customers { get; set; }
        DbSet<Store> stores { get; set; }
        DbSet<Sale> sales { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=EFTaskTwo;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;");
        }
    }
}
