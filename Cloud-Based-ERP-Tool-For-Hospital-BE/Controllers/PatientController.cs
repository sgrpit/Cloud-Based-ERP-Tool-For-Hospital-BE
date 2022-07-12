using Cloud_Based_ERP_Tool_For_Hospital_BE.DTOs;
using Cloud_Based_ERP_Tool_For_Hospital_BE.Repo.Interface;
using Cloud_Based_ERP_Tool_For_Hospital_BE.Services.Interface;
using Cloud_Based_ERP_Tool_For_Hospital_BE.Utilites;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cloud_Based_ERP_Tool_For_Hospital_BE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly IPatientSerivce _patientService;
        private readonly IPatientRepo _patientRepo;
        public PatientController(IPatientSerivce patientSerivce, IPatientRepo patientRepo)
        {
            _patientRepo = patientRepo;
            _patientService = patientSerivce;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllPatientDetails()
        {
            var res = await _patientRepo.GetAllPatient();
            return Ok(new ApiResponse<IEnumerable<PatientResDto>>(res));
        }

        [HttpGet("MobileNo/{mobileNo}")]
        public async Task<IActionResult> GetPatientDetails(string mobileNo)
        {
            var res = await _patientRepo.GetPatientDetailsContactNo(mobileNo);
            return Ok(new ApiResponse<PatientResDto>(res));
        }

        [HttpGet("PatientUHID/{patientUHID}")]
        public async Task<IActionResult> GetPatientDetailsByUHID(string patientUHID)
        {
            var res = await _patientRepo.GetPatientDetailsByUHID(patientUHID);
            return Ok(new ApiResponse<PatientResDto>(res));
        }

        [HttpPost("ScheduleAppointment")]
        public async Task<IActionResult> ScheduleAppointment(PatientAppoinmentReqDto reqDto)
        {
            var resposne = await _patientService.SchedulePatientAppoinemtn(reqDto);
            return Ok(new ApiResponse<PatientAppoinmentResDto>(resposne));
        }

        [HttpPost("PatientRegistration")]
        public async Task<IActionResult> PatientRegistration(PatientReqDto reqDto)
        {
            var resposne = await _patientService.RegisterPatientDetails(reqDto);
            return Ok(new ApiResponse<PatientResDto>(resposne));
        }

        [HttpPut("UpdatePatientDetails")]
        public async Task<IActionResult> UpdatePatientDetails(PatientReqDto patientReqDto)
        {
            var response = await _patientRepo.UpdatePatientDetails(patientReqDto);
            return Ok(new ApiResponse<PatientResDto>(response));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePatientDetails(int id)
        {
            var response = await _patientRepo.DeletePatientDetails(id);
            return Ok(new ApiResponse<bool>(response));
        }

        [HttpGet("GetAppointmentByDoctor/id/{id}")]
        public async Task<IActionResult> GetAppointmentByDoctor(int id)
        {
            var appointments = await _patientRepo.GetPatientAppointmentsByStaffId(id);
            return Ok(new ApiResponse<IEnumerable<PatientAppoinmentResDto>>(appointments, true, "Success"));
        }

        [HttpGet("GetOPDHistoryByDoctor/id/{id}/{fromDate}/{toDate}")]
        public async Task<IActionResult> GetOPDHisotryByDoctor(int id, DateTime fromDate, DateTime toDate)
        {
            var appointments = await _patientRepo.GetOPDHistorysByStaffId(id, fromDate, toDate);
            return Ok(new ApiResponse<IEnumerable<PatientAppoinmentResDto>>(appointments, true, "Success"));
        }
        [HttpGet("GetAppointmentByPatientId/{patientId}")]
        public async Task<IActionResult> GetAppointmentByPatientId(int patientId)
        {
            var appointments = await _patientRepo.GetPatientAppointmentsBypatientId(patientId);
            return Ok(new ApiResponse<IEnumerable<PatientAppoinmentResDto>>(appointments, true, "Success"));
        }


        [HttpPost("AddPrescription")]
        public async Task<IActionResult> AddPatientPrescription(IEnumerable<PatientPresciptionReqDto> patientPresciptionReqDto)
        {
            var response = await _patientRepo.AddPatientPrescription(patientPresciptionReqDto);
            return Ok(new ApiResponse<IEnumerable<PatientPrescriptionResDto>>(response));
            //return Ok();
        }

        [HttpPost("PatientAdmission")]
        public async Task<IActionResult> PatientAdmission(PatientAdmissionReqDto patientPresciptionReqDto)
        {
            var response = await _patientRepo.PatientAdmission(patientPresciptionReqDto);
            return Ok(new ApiResponse<PatientAdmissionResDto>(response));
           
        }
        [HttpGet("PrescriptionHistoryByPatientId/{patientId}")]
        public async Task<IActionResult> GetPrescriptionHistoryByPatientid(int patientId)
        {
            var response = await _patientRepo.GetPrescriptionByPatientId(patientId);
            return Ok(new ApiResponse<IEnumerable<PatientPrescriptionResDto>>(response));           
        }
        
        [HttpGet("GetIPDPatientDetails")]
        public async Task<IActionResult> GetIPDPatientDetails()
        {
            var response = await _patientRepo.GetIPDPatientDetails();
            return Ok(new ApiResponse<IEnumerable<PatientAdmissionResDto>>(response));
        }

        [HttpGet("GetIPDPatientDetailsByPatientUHID/{patientUHID}")]
        public async Task<IActionResult> GetIPDPatientDetails(string patientUHID)
        {
            var response = await _patientRepo.GetIPDPatientDetailsByHID(patientUHID);
            return Ok(new ApiResponse<PatientAdmissionResDto>(response));
        }

        [HttpGet("GetHospitalizationByPatientId/{patientId}")]
        public async Task<IActionResult> GetIPDPatientDetailsByPatientID(int patientId)
        {
            var response = await _patientRepo.GetHospitalizationDetailsByPatientId(patientId);
            return Ok(new ApiResponse<IEnumerable<PatientAdmissionResDto>>(response));
        }

    }
}
