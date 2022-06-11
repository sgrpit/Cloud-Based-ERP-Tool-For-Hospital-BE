using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cloud_Based_ERP_Tool_For_Hospital_BE.Domain
{
    public class PatientPrescriptionHistory
    {
        [Key]
        public int Id { get; set; }
        
        public int PatientId { get; set; }
        [ForeignKey("FK_PatientAppointment")]
        public int PatientAppointmentId { get; set; }
        //[ForeignKey("FK_Staffs")]
        public int StaffId { get; set; }
        public string DrugType { get; set; }
        public string DrugName { get; set; }
        public bool IsBeforeFood { get; set; }
        public bool IsMorning { get; set; }
        public bool IsAfternoon { get; set; }
        public bool IsEvening { get; set; }
        public DateTime PrescribedOn { get; set; } = DateTime.Now;

        //public virtual Patients Patient { get; set; }
        //public virtual Staffs Staff { get; set; }
        public virtual PatientAppointment PatientAppointment { get; set; }
    }
}
