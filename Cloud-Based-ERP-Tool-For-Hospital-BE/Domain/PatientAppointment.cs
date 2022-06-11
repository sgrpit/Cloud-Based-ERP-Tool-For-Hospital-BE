using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cloud_Based_ERP_Tool_For_Hospital_BE.Domain
{
    public class PatientAppointment
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("FK_Patients")]
        public int PatientId { get; set; }
        [ForeignKey("FK_Staffs")]
        public int StaffId { get; set; }
        [Required]
        public string PatientName { get; set; }
        [Required]
        public string MobileNo { get; set; }
        public string EmailID { get; set; }
        public int DepartmentId { get; set; }
        [DataType(DataType.Date)]
        public DateTime AppointmentDate { get; set; }
        public string AppointmentTimeLSlot { get; set; }
        public bool IsCompleted { get; set; } = false;
        public bool IsCancelled { get; set; } = false;
        public string CreatedBy { get; set; }
        public string CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public string ModifiedOn { get; set; }

        public virtual Patients Patient { get; set; }
        public virtual Staffs Staff { get; set; }

        public virtual ICollection<PatientPrescriptionHistory> PatientPrescriptionHistories { get; set; }
    }
}
