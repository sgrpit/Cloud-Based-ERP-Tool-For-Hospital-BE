using AutoMapper;
using Cloud_Based_ERP_Tool_For_Hospital_BE.Domain;
using Cloud_Based_ERP_Tool_For_Hospital_BE.DTOs;
using Cloud_Based_ERP_Tool_For_Hospital_BE.Repo.Interface;
using Cloud_Based_ERP_Tool_For_Hospital_BE.Services.Interface;
using System;
using System.Threading.Tasks;

namespace Cloud_Based_ERP_Tool_For_Hospital_BE.Services
{
    public class PatientService : IPatientSerivce
    {
        private readonly IPatientRepo _patientRepo;
        private readonly IMapper _mapper;

        public PatientService(IPatientRepo patientRepo, IMapper mapper)
        {
            _patientRepo = patientRepo;
            _mapper = mapper;
        }

        public async Task<PatientAppoinmentResDto> CancelScheduledAppointment(string contactNo, string action)
        {
            var appointmentResponse = await _patientRepo.CancelScheduledPatientAppointment(contactNo, action);
            return _mapper.Map<PatientAppoinmentResDto>(appointmentResponse);
        }

        public async Task<PatientResDto> RegisterPatientDetails(PatientReqDto patientReqDto)
        {
            if (string.IsNullOrEmpty(patientReqDto.PatientUHID))
                patientReqDto.PatientUHID = await GetNewPatientUHID();
            return await _patientRepo.PatientRegistration(patientReqDto);
        }

        public async Task<PatientAppoinmentResDto> SchedulePatientAppoinemtn(PatientAppoinmentReqDto appoinmentReqDto)
        {
            var appoinemt = await _patientRepo.SchedulePatientAppointment(appoinmentReqDto);            
            return  _mapper.Map<PatientAppoinmentResDto>(appoinemt);
        }

        public async Task<PatientAppoinmentResDto> UpdateScheduledPatientAppointment(string contactNo, string nextAppointmentDate, string appointmentSlot)
        {
            PatientAppointment appointment = await _patientRepo.UpdateScheduledPatientAppointment(contactNo, nextAppointmentDate, appointmentSlot);
            return _mapper.Map<PatientAppoinmentResDto>(appointment);
        }

        private async Task<string> GetNewPatientUHID()
        {
            string newUHID = "UHID";
            string existingUHID = await _patientRepo.GetLatestPatientUHID();
            if (string.IsNullOrEmpty(existingUHID))
                newUHID = newUHID + "00001";
            else
            {
                int numericValue = Convert.ToInt32(existingUHID.Replace("UHID", string.Empty)) + 1;
                if (Math.Floor(Math.Log10(numericValue) + 1) == 1)
                    newUHID = newUHID + "0000" + Convert.ToString(numericValue);
                else if (Math.Floor(Math.Log10(numericValue) + 1) == 2)
                    newUHID = newUHID + "000" + Convert.ToString(numericValue);
                else if (Math.Floor(Math.Log10(numericValue) + 1) == 3)
                    newUHID = newUHID + "00" + Convert.ToString(numericValue);
                else if (Math.Floor(Math.Log10(numericValue) + 1) == 3)
                    newUHID = newUHID + "0" + Convert.ToString(numericValue);
                else
                    newUHID = newUHID + Convert.ToString(numericValue);
            }
            return newUHID;
        }
    }
}
