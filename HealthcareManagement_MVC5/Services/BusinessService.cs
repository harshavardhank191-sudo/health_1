using System;
using System.Linq;
using HealthcareManagement_MVC5.Data;
using HealthcareManagement_MVC5.Models;

namespace HealthcareManagement_MVC5.Services
{
    public class BusinessService
    {
        public object GetDashboard()
        {
            using (var db = new AppDbContext())
            {
                return new {
                    Total = db.Patients.Count(),
                    Active = db.Patients.Count(x => x.Status == "Active"),
                    Transactions = db.MedicalClaims.Count()
                };
            }
        }

        public Patient Create(string reference)
        {
            using (var db = new AppDbContext())
            {
                var item = new Patient {
                    ReferenceNumber = reference,
                    Status = "Active",
                    CreatedDate = DateTime.UtcNow
                };
                db.Patients.Add(item);
                db.SaveChanges();
                return item;
            }
        }
    }
}
