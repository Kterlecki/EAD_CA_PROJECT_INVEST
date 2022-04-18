using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EAD_CA_PROJECT_INVEST.Model;

namespace EAD_CA_PROJECT_INVEST.Data
{
    public class INVESTContext : DbContext
    {
        public INVESTContext (DbContextOptions<INVESTContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>()
                .HasOne(u => u.User)
                .WithMany(o=> o.Order)
                .HasForeignKey(u => u.UserID);

            modelBuilder.Entity<Order>()
                .HasOne(s => s.Stock)
                .WithMany(o => o.Order)
                .HasForeignKey(s => s.StockID);

        }

        public DbSet<EAD_CA_PROJECT_INVEST.Model.User> User { get; set; }

        public DbSet<EAD_CA_PROJECT_INVEST.Model.Stock> Stock { get; set; }

        public DbSet<EAD_CA_PROJECT_INVEST.Model.Order> Order { get; set; }
    }
}
