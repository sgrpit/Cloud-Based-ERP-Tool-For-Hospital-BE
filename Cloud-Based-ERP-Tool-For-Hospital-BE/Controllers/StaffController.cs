using Cloud_Based_ERP_Tool_For_Hospital_BE.DTOs;
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
    public class StaffController : ControllerBase
    {
        private readonly IStaffService _staffService;
        public StaffController(IStaffService staffService)
        {
            _staffService = staffService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllStaffDetails()
        {
            var staffDetailsResDto = await _staffService.GetAllStaffDetails();
            //AppException()
            return Ok(new ApiResponse<IEnumerable<StaffDetailsResDto>>(staffDetailsResDto, true, "Success"));
            //return Ok(StaffDetailsResDto);
        }

        [HttpGet("GetStaffDetailsByRoleId/{roleId}")]
        public async Task<IActionResult> GetStaffDetailsByRoleId(int roleId)
        {
            var staffDetailsResDto = await _staffService.GetAllStaffDetailsByRoles(roleId);
            //AppException()
            return Ok(new ApiResponse<IEnumerable<StaffDetailsResDto>>(staffDetailsResDto, true, "Success"));
            //return Ok(StaffDetailsResDto);
        }
        [HttpGet("GetStaffDetailsById/{id}")]
        public async Task<IActionResult> GetStaffDetailsById(int id)
        {
            var staffDetailsResDto = await _staffService.GetStaffDetailsById(id);
            //AppException()
            return Ok(new ApiResponse<StaffDetailsResDto>(staffDetailsResDto, true, "Success"));
            //return Ok(StaffDetailsResDto);
        }

        [HttpGet("deptId/{deptId}", Name = "GetAllStaffDetailsByDepartment")]
        public async Task<IActionResult> GetAllStaffDetailsByDepartment(int deptId)
        {
            var staffDetailsResDto = await _staffService.GetAllStaffDetailsByFilter("", "", deptId);
            //AppException()
            return Ok(new ApiResponse<IEnumerable<StaffDetailsResDto>>(staffDetailsResDto, true, "Success"));
            //return Ok(StaffDetailsResDto);
        }


        [HttpPost]
        public async Task<IActionResult> CreateStaffDetails(CreateStaffReqDto createStaffReqDto)
        {
            var staffDetailsResDto = await _staffService.CreateStaffDetails(createStaffReqDto);
            //return Ok()
            return Ok(new ApiResponse<StaffDetailsResDto>(staffDetailsResDto, true, "Success"));

        }

        [HttpPut]
        public async Task<IActionResult> UpdateStaffDetails(UpdateStaffReqDto updateStaffReqDto)
        {
            var staffDetailsResDto = await _staffService.UpdateStaffDetails(updateStaffReqDto);
            //return Ok()
            return Ok(new ApiResponse<StaffDetailsResDto>(staffDetailsResDto, true, "Success"));

        }

    }


}
