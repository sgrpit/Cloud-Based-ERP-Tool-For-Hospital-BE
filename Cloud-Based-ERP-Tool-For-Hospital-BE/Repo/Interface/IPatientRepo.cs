using Cloud_Based_ERP_Tool_For_Hospital_BE.Domain;
using Cloud_Based_ERP_Tool_For_Hospital_BE.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cloud_Based_ERP_Tool_For_Hospital_BE.Repo.Interface
{
    public interface IPatientRepo
    {
        Task<IEnumerable<PatientResDto>> GetAllPatient();
        Task<PatientResDto> GetPatientDetailsByUHID(string patientUHID);
        Task<PatientResDto> GetPatientDetailsContactNo(string contactNo);
        Task<PatientResDto> PatientRegistration(PatientReqDto patientReqDto);
        Task<PatientResDto> UpdatePatientDetails(PatientReqDto patientReqDto);
        Task<bool> DeletePatientDetails(int id);
        Task<string> GetLatestPatientUHID();
        Task<Patients> GetPatientDetailsByFilter(string UHID, string contactNo, string emailId = "");
        Task<PatientAppointment> SchedulePatientAppointment(PatientAppoinmentReqDto appointmentDetails);
        Task<PatientAppoinmentResDto> GetPatientAppointmentScheduleDetails(string PatientUHID, string contactNo);
        Task<PatientAppointment> CancelScheduledPatientAppointment(string contactNo, string action);
        Task<PatientAppointment> UpdateScheduledPatientAppointment(string contactNo, string nextAppointmentDate, string appointmentSlot);
        Task<IEnumerable<PatientAppoinmentResDto>> GetPatientAppointmentsByStaffId(int staffId);
        Task<IEnumerable<PatientPrescriptionResDto>> GetPrescriptionByPatientId(int patientId);
        Task<IEnumerable<PatientPrescriptionResDto>> AddPatientPrescription(IEnumerable<PatientPresciptionReqDto> patientAppoinmentReqDto);
        Task<PatientAdmissionResDto> PatientAdmission(PatientAdmissionReqDto patientAdmissionReq);
        Task<IEnumerable<PatientAdmissionResDto>> GetIPDPatientDetails();
        //Task<IEnumerable<PatientAdmissionResDto>> GetIPDPatientDetailsByStaffId(int staffId);
        Task<PatientAdmissionResDto> GetIPDPatientDetailsByHID(string patientUHID);
        Task<IEnumerable<PatientAppoinmentResDto>> GetPatientAppointmentsBypatientId(int patientId);
        Task<IEnumerable<PatientAdmissionResDto>> GetHospitalizationDetailsByPatientId(int patientId);
    }
}
