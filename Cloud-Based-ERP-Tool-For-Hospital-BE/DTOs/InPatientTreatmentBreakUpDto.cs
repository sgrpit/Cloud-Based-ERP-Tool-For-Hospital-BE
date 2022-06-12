using Cloud_Based_ERP_Tool_For_Hospital_BE.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cloud_Based_ERP_Tool_For_Hospital_BE.DTOs
{
    public class InPatientTreatmentBreakUpDto
    {
        public int Id { get; set; }
        public int InPatientDirectoryId { get; set; }
        public string TreatmentName { get; set; }
        public string TreatmentType { get; set; }
        public DateTime TreatmentDate { get; set; }
        public int Quantity { get; set; }
        public double TreatmentAmount { get; set; }
        public virtual PatientAdmissionResDto PatientAdmission { get; set; }

        //public virtual InPa InPatientDirectory { get; set; }
    }
}
