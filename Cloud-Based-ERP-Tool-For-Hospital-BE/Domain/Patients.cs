using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cloud_Based_ERP_Tool_For_Hospital_BE.Domain
{
    public class Patients
    {
        [Key]
        public int Id { get; set; }
        public string PatientUHID { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string MobileNo { get; set; }
        [Required]
        public string EmailID { get; set; }
        public string BloodGroup { get; set; }
        
        public string Gender { get; set; }
        [DataType(DataType.Date)]
        
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public string ModifiedOn { get; set; }
        public virtual ICollection<PatientAppointment> PatientAppointments { get; set; }
        public virtual ICollection<InPatientDirectory> InPatientDirectories { get; set; }
        //public virtual ICollection<PatientPrescriptionHistory> PatientPrescriptionHistories  { get; set; }
        

    }
}
