using AutoMapper;
using Cloud_Based_ERP_Tool_For_Hospital_BE.DTOs;
using Cloud_Based_ERP_Tool_For_Hospital_BE.Repo.Interface;
using Cloud_Based_ERP_Tool_For_Hospital_BE.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cloud_Based_ERP_Tool_For_Hospital_BE.Services
{
    public class StaffService: IStaffService
    {
       
        private readonly IStaffRepo _staffRespo;
        public StaffService(IStaffRepo staffRespo)
        {
            _staffRespo = staffRespo;
        }
        public async Task<StaffDetailsResDto> CreateStaffDetails(CreateStaffReqDto createStaffReqDto)
        {
            string staffId = await GenerateEmployeeId();
            return await _staffRespo.CreateStaff(createStaffReqDto, staffId);
        }

        public Task<bool> DeleteStaff(int id)
        {
            return _staffRespo.DeleteStaffDetails(id);
        }

        public async Task<IEnumerable<StaffDetailsResDto>> GetAllStaffDetails()
        {
            return await _staffRespo.GetAllStaffDetails();
        }

        public async Task<StaffDetailsResDto> GetStaffDetailsById(int id)
        {
            return await _staffRespo.GetStaffsDetailsById(id);
        }

        public Task<IEnumerable<StaffDetailsResDto>> GetAllStaffDetailsByFilter(string staffId, string contactNo, int deptId)
        {
            return _staffRespo.GetStaffDetailsByFilter("", "", deptId);
        }

        public async Task<IEnumerable<StaffDetailsResDto>> GetAllStaffDetailsByRoles(int roleId)
        {
            return await _staffRespo.GetStaffDetailsByRole(roleId);
        }

        public async Task<StaffDetailsResDto> UpdateStaffDetails(UpdateStaffReqDto updateStaffReqDto)
        {
            return await _staffRespo.UpdateStaffDetails(updateStaffReqDto);
        }

        private async Task<string> GenerateEmployeeId()
        {
            string latestStaffId = await _staffRespo.GetLatestStaffId();
            string newStaffId = "S";
            if (string.IsNullOrEmpty(latestStaffId))
            {
                newStaffId = "S-00001";
            }
            else
            {
                string staffIdNo = latestStaffId.Split("-")[1];
                int numericValue = Convert.ToInt32(staffIdNo) + 1;
                if (Math.Floor(Math.Log10(numericValue) + 1) == 1)
                    newStaffId = newStaffId + "-0000" + Convert.ToString(numericValue);
                else if (Math.Floor(Math.Log10(numericValue) + 1) == 2)
                    newStaffId = newStaffId + "-000" + Convert.ToString(numericValue);
                else if (Math.Floor(Math.Log10(numericValue) + 1) == 3)
                    newStaffId = newStaffId + "-00" + Convert.ToString(numericValue);
                else if (Math.Floor(Math.Log10(numericValue) + 1) == 3)
                    newStaffId = newStaffId + "-0" + Convert.ToString(numericValue);
                else
                    newStaffId = newStaffId + Convert.ToString(numericValue);

            }
            return newStaffId;
        }

    }
}
