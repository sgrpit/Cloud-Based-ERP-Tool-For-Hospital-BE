using AutoMapper;
using Cloud_Based_ERP_Tool_For_Hospital_BE.DTOs;
using Cloud_Based_ERP_Tool_For_Hospital_BE.Repo.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cloud_Based_ERP_Tool_For_Hospital_BE.Services.Interface
{
    public interface IPatientSerivce
    {
        Task<PatientAppoinmentResDto> SchedulePatientAppoinemtn(PatientAppoinmentReqDto appoinmentReqDto);
        Task<PatientResDto> RegisterPatientDetails(PatientReqDto patientReqDto);
        Task<PatientAppoinmentResDto> CancelScheduledAppointment(string contactNo, string action);
        Task<PatientAppoinmentResDto> UpdateScheduledPatientAppointment(string contactNo, string nextAppointmentDate, string appointmentSlot);



    }
}
