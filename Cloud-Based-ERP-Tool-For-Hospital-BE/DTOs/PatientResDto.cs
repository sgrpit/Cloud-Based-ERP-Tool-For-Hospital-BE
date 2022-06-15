using Cloud_Based_ERP_Tool_For_Hospital_BE.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cloud_Based_ERP_Tool_For_Hospital_BE.DTOs
{
    public class PatientResDto
    {
        public int Id { get; set; }
        public string PatientUHID { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string MobileNo { get; set; }
        public string EmailID { get; set; }
        public string BloodGroup { get; set; }
        public string Gender { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
    }

    public class PatientReqDto
    {
        public string PatientUHID { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string MobileNo { get; set; }
        public string EmailID { get; set; }
        public string BloodGroup { get; set; }
        public string Gender { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
    }

    public class PatientAppoinmentResDto
    {
        public int Id { get; set; }
        public string PatientId { get; set; }
        public string PatientName { get; set; }
        public string MobileNo { get; set; }
        public string EmailID { get; set; }
        public int DepartmentId { get; set; }
        public int StaffId { get; set; }
        [DataType(DataType.Date)]
        public DateTime AppointmentDate { get; set; }
        public string AppointmentTimeLSlot { get; set; }
        public PatientResDto Patient { get; set; }
        public StaffDetailsResDto Staff { get; set; }
        public ICollection<PatientPrescriptionResDto> PatientPrescriptionsHistory { get; set; }
    }

    public class PatientAppoinmentReqDto
    {
        public int PatientId { get; set; }
        public string PatientName { get; set; }
        public string MobileNo { get; set; }
        public string EmailID { get; set; }
        public int DepartmentId { get; set; }
        public int StaffId { get; set; }
        [DataType(DataType.Date)]
        public DateTime AppointmentDate { get; set; }
        public string AppointmentTimeLSlot { get; set; }
    }

    public class PatientPresciptionReqDto
    {
        public int PatientId { get; set; }
        public int PatientAppointmentId { get; set; }
        public string DrugType { get; set; }
        public string DrugName { get; set; }
        //public string DrugConsumtionScehdule { get; set; }
        public bool IsBeforeFood { get; set; }
        public bool IsMorning { get; set; }
        public bool IsAfternoon { get; set; }
        public bool IsEvening { get; set; }
        public int StaffId { get; set; }
        public DateTime PrescribedOn { get; set; } = DateTime.Now;

    }

    public class PatientPrescriptionResDto
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public int PatientAppointmentId { get; set; }
        public string DrugType { get; set; }
        public string DrugName { get; set; }
        public bool IsBeforeFood { get; set; }
        public bool IsMorning { get; set; }
        public bool IsAfternoon { get; set; }
        public bool IsEvening { get; set; }
        public int StaffId { get; set; }
        public DateTime PrescribedOn { get; set; }
        public PatientAppoinmentResDto PatientAppointment { get; set; }
    }
}
