using System;
using System.ComponentModel.DataAnnotations;

namespace HealthcareManagement_MVC5.Models
{
    public class Patient
    {
        [Key] public int Id { get; set; }
        public string ReferenceNumber { get; set; }
        public string Status { get; set; }
        public DateTime CreatedDate { get; set; }
    }

    public class MedicalClaim
    {
        [Key] public int Id { get; set; }
        public int PatientId { get; set; }
        public decimal Amount { get; set; }
        public string Status { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
