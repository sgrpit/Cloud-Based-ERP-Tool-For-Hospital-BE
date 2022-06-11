using Cloud_Based_ERP_Tool_For_Hospital_BE.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cloud_Based_ERP_Tool_For_Hospital_BE.Services.Interface
{
    public interface IStaffService
    {
        Task<IEnumerable<StaffDetailsResDto>> GetAllStaffDetails();
        Task<IEnumerable<StaffDetailsResDto>> GetAllStaffDetailsByRoles(int roleId);
        Task<IEnumerable<StaffDetailsResDto>> GetAllStaffDetailsByFilter(string staffId, string contactNo, int deptId = 0);
        Task<StaffDetailsResDto> CreateStaffDetails(CreateStaffReqDto createStaffReqDto);
        Task<StaffDetailsResDto> UpdateStaffDetails(UpdateStaffReqDto updateStaffReqDto);
        Task<StaffDetailsResDto> GetStaffDetailsById(int id);
        Task<bool> DeleteStaff(int id);

    }
}
