using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cloud_Based_ERP_Tool_For_Hospital_BE.Domain
{
    public class InPatientDirectory
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("FK_Patients")]
        public int PatientId { get; set; }
        [ForeignKey("FK_Staffs")]
        public int StaffId { get; set; }
        public string PatientUHID { get; set; }
        public string RoomType { get; set; }
        public string BedNo { get; set; }
        public bool IsInsured { get; set; }
        public string InsuranceCompany { get; set; }
        public DateTime AdminssionDate { get; set; } = DateTime.Now;
        public DateTime DischargeDate { get; set; }
        public string DiagnosisDetails { get; set; }
        public string DischargeSummary { get; set; }
        public bool IsDischarged { get; set; } = false;
        //public double AdvancePaytment { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public string ModifiedOn { get; set; }


        public virtual Patients Patient { get; set; }
        public virtual Staffs Staff { get; set; }

        public virtual ICollection<IPDPatientTreatmentBreakup> IPDPatientTreatmentSummaries { get; set; }

    }
}
