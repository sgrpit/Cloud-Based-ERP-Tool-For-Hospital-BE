using Cloud_Based_ERP_Tool_For_Hospital_BE.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cloud_Based_ERP_Tool_For_Hospital_BE.DTOs
{
    public class PatientAdmissionReqDto
    {
        public int PatientId { get; set; }
        public string PatientUHID { get; set; }
        public int StaffId { get; set; }
        public string RoomType { get; set; }
        public string BedNo { get; set; }
        public bool IsInsured { get; set; }
        public string InsuranceCompany { get; set; }
        public DateTime AdminssionDate { get; set; } = DateTime.Now;
        public DateTime DischargeDate { get; set; }
        public string DiagnosisDetails { get; set; }
        public string DischargeSummary { get; set; }
    }

    public class PatientAdmissionResDto
    {
        public int Id { get; set; }
        public string PatientUHID { get; set; }
        public int StaffId { get; set; }
        public int PatientId { get; set; }
        public string RoomType { get; set; }
        public string BedNo { get; set; }
        public string IsInsured { get; set; }
        public string InsuranceCompany { get; set; }
        public string AdminssionDate { get; set; }
        public bool IsDischarged { get; set; }
        public string DischargeDate { get; set; }
        public string DignosisDetails { get; set; }
        public string DischargeSummary { get; set; }
        public PatientResDto Patient { get; set; }
        public StaffDetailsResDto Staff { get; set; }
        public ICollection<InPatientTreatmentBreakUpDto> IPDPatientTreatmentSummaries { get; set; }
    }
}
