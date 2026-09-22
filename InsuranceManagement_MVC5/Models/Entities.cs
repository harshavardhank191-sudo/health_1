using System;
using System.ComponentModel.DataAnnotations;

namespace InsuranceManagement_MVC5.Models
{
    public class Customer
    {
        [Key] public int Id { get; set; }
        public string ReferenceNumber { get; set; }
        public string Status { get; set; }
        public DateTime CreatedDate { get; set; }
    }

    public class InsuranceClaim
    {
        [Key] public int Id { get; set; }
        public int CustomerId { get; set; }
        public decimal Amount { get; set; }
        public string Status { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
