using System;
using BanqueRepositoryClass.Models;
using Microsoft.EntityFrameworkCore;

namespace BanqueRepositoryClass.Tools
{
    public class DataContext : DbContext
    {
        private string connectionString = @"Data Source=(LocalDB)\EntityBDD;Integrated Security=True";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

        public DbSet<Account> Accounts { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Operation> Operations { get; set; }
    }
}
