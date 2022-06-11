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
    public class AdminController : ControllerBase
    {
        private readonly IAdminRepo _adminRepo;

        public AdminController(IAdminRepo adminRepo)
        {
            _adminRepo = adminRepo;
        }

        [HttpGet("GetUserRoles")]
        public async Task<IActionResult> GetRole()
        {
            var response = await _adminRepo.GetUserRolesList();
            return Ok(new ApiResponse<IEnumerable<UserRoleResDto>>(response));
        }

        //[HttpPost]
        //public async Task<IActionResult> AssignRoles(int staffId, int roleId)
        //{
        //    var result = _adminRepo.AssignUserRoles(staffId, roleId);
        //    return Ok(result);
        //}
    }
}
