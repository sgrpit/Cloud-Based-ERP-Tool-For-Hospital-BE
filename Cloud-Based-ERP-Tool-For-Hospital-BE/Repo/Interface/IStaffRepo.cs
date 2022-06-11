using Cloud_Based_ERP_Tool_For_Hospital_BE.Domain;
using Cloud_Based_ERP_Tool_For_Hospital_BE.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cloud_Based_ERP_Tool_For_Hospital_BE.Repo.Interface
{
    public interface IStaffRepo
    {
        //Task<StaffDetailsResDto> GetStaffDetailsById(int id);
        Task<IEnumerable<StaffDetailsResDto>> GetStaffDetailsByFilter(string staffId, string ContactNo, int departmentId = 0);
        Task<IEnumerable<StaffDetailsResDto>> GetAllStaffDetails();
        Task<StaffDetailsResDto> CreateStaff(CreateStaffReqDto createStaffReqDto, string staffId);
        Task<StaffDetailsResDto> UpdateStaffDetails(UpdateStaffReqDto updateStaffReqDto);
        Task<bool> DeleteStaffDetails(int id);
        Task<IEnumerable<StaffDetailsResDto>> GetStaffDetailsByRole(int roleId);
        Task<IEnumerable<StaffDetailsResDto>> GetStaffDetailsByPatientUHID(string staffId, string ContactNo);
        Task<string> GetLatestStaffId();
        Task<StaffDetailsResDto> GetStaffsDetailsById(int id);

    }
}
