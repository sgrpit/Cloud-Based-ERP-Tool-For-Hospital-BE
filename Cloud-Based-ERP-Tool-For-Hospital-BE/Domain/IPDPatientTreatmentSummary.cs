using Cloud_Based_ERP_Tool_For_Hospital_BE.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cloud_Based_ERP_Tool_For_Hospital_BE.Domain
{
    public class IPDPatientTreatmentBreakup
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("FK_InPatientDirectory")]
        public int InPatientDirectoryId { get; set; }
        public string TreatmentName { get; set; }
        public string TreatmentType { get; set; }
        public DateTime TreatmentDate { get; set; }
        public int Quantity { get; set; }
        public double TreatmentAmount { get; set; }
        public string CreatedBy { get; set; }

        public virtual InPatientDirectory InPatientDirectory { get; set; }
    }

    //public class IPDPatientVitalCheckHistory
    //{
    //    [Key]
    //    public int Id { get; set; }
    //    [ForeignKey("FK_InPatientDirectory")]
    //    public int InPateintDirectoryId { get; set; }
    //    public string VitalName { get; set; }
    //    public string Reading { get; set; }
        
    //    public virtual InPatientDirectory InPatientDirectory { get; set; }
    //}
}
