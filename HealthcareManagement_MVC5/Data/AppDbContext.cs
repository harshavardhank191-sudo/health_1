using System.Data.Entity;
using HealthcareManagement_MVC5.Models;

namespace HealthcareManagement_MVC5.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("name=AppDbContext") { }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<MedicalClaim> MedicalClaims { get; set; }
    }
}
