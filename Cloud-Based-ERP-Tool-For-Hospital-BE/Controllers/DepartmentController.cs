using Cloud_Based_ERP_Tool_For_Hospital_BE.DTOs;
using Cloud_Based_ERP_Tool_For_Hospital_BE.Repo.Interface;
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
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentRepo _departmentRepo;
        public DepartmentController(IDepartmentRepo departmentRepo)
        {
            _departmentRepo = departmentRepo;
        }

        [HttpGet]        
        public async Task<IActionResult> GetDepartmentDetails()
        {
            var departmentRes = await _departmentRepo.GetAllDepartments();
            return Ok(new ApiResponse<IEnumerable<DepartmentResDto>>(departmentRes));
            //return Ok(departmentRes);
        }

        [HttpGet("GetNonAdminDepartmentDetails")]
        public async Task<IActionResult> GetNonAdminDepartmentDetails()
        {
            var departmentRes = await _departmentRepo.GetNonAdminDepartments();
            return Ok(new ApiResponse<IEnumerable<DepartmentResDto>>(departmentRes));
            //return Ok(departmentRes);
        }

        [HttpPost]
        public async Task<IActionResult> AddUpdateDepartment(DepartmentReqDto addDepartmentReqDto)
        {
            DepartmentResDto deptDetailsResDto = await _departmentRepo.UpsertDepartment(addDepartmentReqDto);
            return Ok(new ApiResponse<DepartmentResDto>(deptDetailsResDto));
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteDepartment(int deptId)
        {
            var result = await _departmentRepo.DeleteDepartment(deptId);
            return Ok(new ApiResponse<bool>(result));
        }
    }
}
