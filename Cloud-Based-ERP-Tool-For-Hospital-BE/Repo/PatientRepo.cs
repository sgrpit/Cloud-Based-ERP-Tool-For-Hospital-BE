using AutoMapper;
using Cloud_Based_ERP_Tool_For_Hospital_BE.Domain;
using Cloud_Based_ERP_Tool_For_Hospital_BE.DTOs;
using Cloud_Based_ERP_Tool_For_Hospital_BE.Repo.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cloud_Based_ERP_Tool_For_Hospital_BE.Repo
{
    public class PatientRepo : IPatientRepo
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;

        public PatientRepo(ApplicationDbContext dbContext, IMapper mapper)
        {
            _mapper = mapper;
            _dbContext = dbContext;
        }

        public async Task<PatientPrescriptionResDto> AddPatientPrescription(IEnumerable<PatientPresciptionReqDto> patientPresciptionReqs)
        {
            var patientPrescription = _mapper.Map<IEnumerable<PatientPrescriptionHistory>>(patientPresciptionReqs);
            _dbContext.PatientPrescriptionHistories.AddRange(patientPrescription);
            await _dbContext.SaveChangesAsync();
            //int appintmentId = patientPresciptionReqs.FirstOrDefault().PatientAppointmentId;
            //var patientAppointment = await _dbContext.PatientAppointments.FirstOrDefaultAsync(p => p.Id == patientPrescription.FirstOrDefault().PatientAppointmentId);
            //patientAppointment.IsCompleted = true;
            //_dbContext.PatientAppointments.Update(patientAppointment);
            //await _dbContext.SaveChangesAsync();
            return _mapper.Map<PatientPrescriptionResDto>(patientPrescription);
            //throw new NotImplementedException();
        }

        public Task<PatientAppointment> CancelScheduledPatientAppointment(string contactNo, string action)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeletePatientDetails(string patientUHID)
        {
            var patient = await _dbContext.Patients.FirstOrDefaultAsync(p => p.PatientUHID == patientUHID);
            _dbContext.Patients.Remove(patient);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<PatientResDto>> GetAllPatient()
        {
            var patients = await _dbContext.Patients.ToListAsync();
            return _mapper.Map<IEnumerable<PatientResDto>>(patients);
        }

        public async Task<string> GetLatestPatientUHID()
        {
            return await _dbContext.Patients.OrderByDescending(p => p.PatientUHID).Select(p => p.PatientUHID).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<PatientAppoinmentResDto>> GetPatientAppointmentsByStaffId(int staffId)
        {
            var patientAppointment = await _dbContext.PatientAppointments.Where(p => p.StaffId == staffId && p.IsCompleted == false).ToListAsync();
            return _mapper.Map<IEnumerable<PatientAppoinmentResDto>>(patientAppointment);
            //throw new NotImplementedException();
        }

        public Task<PatientAppoinmentResDto> GetPatientAppointmentScheduleDetails(string PatientUHID, string contactNo)
        {
            throw new NotImplementedException();
        }

        public Task<Patients> GetPatientDetailsByFilter(string UHID, string contactNo, string emailId = "")
        {
            throw new NotImplementedException();
        }

        public async Task<PatientResDto> GetPatientDetailsByUHID(string patientUHID)
        {
            var patients = await _dbContext.Patients.FirstOrDefaultAsync(a => a.PatientUHID == patientUHID);
            return _mapper.Map<PatientResDto>(patients);
        }

        public Task<PatientResDto> GetPatientDetailsContactNo(string contactNo)
        {
            throw new NotImplementedException();
        }

        public async Task<PatientResDto> PatientRegistration(PatientReqDto patientReqDto)
        {
            Patients patientsDetails = _mapper.Map<Patients>(patientReqDto);
            _dbContext.Patients.Add(patientsDetails);
            await _dbContext.SaveChangesAsync();
            return _mapper.Map<PatientResDto>(patientsDetails);
        }

        public async Task<PatientAppointment> SchedulePatientAppointment(PatientAppoinmentReqDto appointmentReqDto)
        {
            var appointmentDetils = _mapper.Map<PatientAppointment>(appointmentReqDto);
            //appointmentDetils.PatientId = GetPatientUHIDbyContactNo(appointmentDetils.MobileNo);
            _dbContext.PatientAppointments.Add(appointmentDetils);
            await _dbContext.SaveChangesAsync();
            return appointmentDetils;
            //throw new NotImplementedException();
        }

        public async Task<PatientResDto> UpdatePatientDetails(PatientReqDto patientReqDto)
        {
            var patient = await _dbContext.Patients.FirstOrDefaultAsync(p => p.PatientUHID == patientReqDto.PatientUHID);
            patient.FirstName = patientReqDto.FirstName;
            patient.MiddleName = patientReqDto.MiddleName;
            patient.LastName = patientReqDto.LastName;
            patient.Address = patientReqDto.Address;
            patient.City = patientReqDto.City;
            patient.MobileNo = patientReqDto.MobileNo;
            patient.EmailID = patientReqDto.EmailID;
            patient.Gender = patientReqDto.Gender;
            patient.BloodGroup = patientReqDto.BloodGroup;
            patient.DateOfBirth = patientReqDto.DateOfBirth;
            //patient.BloodGroup = patientReqDto.FirstName;

            _dbContext.Patients.Update(patient);
            await _dbContext.SaveChangesAsync();
            return _mapper.Map<PatientResDto>(patient);
        }

        public Task<PatientAppointment> UpdateScheduledPatientAppointment(string contactNo, string nextAppointmentDate, string appointmentSlot)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<PatientPrescriptionResDto>> GetPrescriptionByPatientId(int patientId)
        {
            var prescriptionHistory = await _dbContext.PatientPrescriptionHistories.Where(p => p.PatientAppointment.Patient.Id == patientId).ToListAsync();
            return _mapper.Map<IEnumerable<PatientPrescriptionResDto>>(prescriptionHistory);
            //throw new NotImplementedException();
        }

        private string GetPatientUHIDbyContactNo(string contactNo)
        {
            return _dbContext.Patients.FirstOrDefault(p => p.MobileNo == contactNo).MobileNo;
        }

        public async Task<PatientAdmissionResDto> PatientAdmission(PatientAdmissionReqDto patientAdmissionReq)
        {
            try
            {
                var ipdDetails = _dbContext.InPatientDirectory.FirstOrDefault(i => i.PatientId == patientAdmissionReq.PatientId && i.IsDischarged);
                if(ipdDetails == null)
                {
                    _dbContext.InPatientDirectory.Add(_mapper.Map<InPatientDirectory>(patientAdmissionReq));
                }
                else
                {
                    ipdDetails.RoomType = patientAdmissionReq.RoomType;
                    ipdDetails.BedNo = patientAdmissionReq.BedNo;
                    _dbContext.InPatientDirectory.Update(ipdDetails);
                }
                
                await _dbContext.SaveChangesAsync();
                return _mapper.Map<PatientAdmissionResDto>(_mapper.Map<InPatientDirectory>(patientAdmissionReq));
            }
            catch (Exception ex)
            {

                throw new Exception(ex.InnerException.Message);
            }
        }

        public async Task<IEnumerable<PatientAdmissionResDto>> GetIPDPatientDetails()
        {
            var ipdDetails = await _dbContext.InPatientDirectory.Where(p => !p.IsDischarged).ToListAsync();
            return _mapper.Map<IEnumerable<PatientAdmissionResDto>>(ipdDetails);
        }
        public async Task<PatientAdmissionResDto> GetIPDPatientDetailsByHID(string patientUHID)
        {
            var ipdDetails = await _dbContext.InPatientDirectory.FirstOrDefaultAsync(p => p.PatientUHID == patientUHID && !p.IsDischarged);
            return _mapper.Map<PatientAdmissionResDto>(ipdDetails);
        }

        public async Task<IEnumerable<PatientAppoinmentResDto>> GetPatientAppointmentsBypatientId(int patientId)
        {
            var patientAppointment = await _dbContext.PatientAppointments.Where(p => p.PatientId == patientId).ToListAsync();
            return _mapper.Map<IEnumerable<PatientAppoinmentResDto>>(patientAppointment);
        }

        public async Task<IEnumerable<PatientAdmissionResDto>> GetHospitalizationDetailsByPatientId(int patientId)
        {
            var patientAdmissionDetails = await _dbContext.InPatientDirectory.Where(p => p.PatientId == patientId).ToListAsync();
            return _mapper.Map<IEnumerable<PatientAdmissionResDto>>(patientAdmissionDetails);
        }
    }
}
