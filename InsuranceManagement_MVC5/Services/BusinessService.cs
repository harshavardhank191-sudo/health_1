using System;
using System.Linq;
using InsuranceManagement_MVC5.Data;
using InsuranceManagement_MVC5.Models;

namespace InsuranceManagement_MVC5.Services
{
    public class BusinessService
    {
        public object GetDashboard()
        {
            using (var db = new AppDbContext())
            {
                return new {
                    Total = db.Customers.Count(),
                    Active = db.Customers.Count(x => x.Status == "Active"),
                    Transactions = db.InsuranceClaims.Count()
                };
            }
        }

        public Customer Create(string reference)
        {
            using (var db = new AppDbContext())
            {
                var item = new Customer {
                    ReferenceNumber = reference,
                    Status = "Active",
                    CreatedDate = DateTime.UtcNow
                };
                db.Customers.Add(item);
                db.SaveChanges();
                return item;
            }
        }
    }
}
