using System.Data.Entity;
using InsuranceManagement_MVC5.Models;

namespace InsuranceManagement_MVC5.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("name=AppDbContext") { }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<InsuranceClaim> InsuranceClaims { get; set; }
    }
}
