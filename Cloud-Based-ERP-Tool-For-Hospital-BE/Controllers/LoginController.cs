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
    public class LoginController : ControllerBase
    {
        private readonly ILoginService _loginService;

        public LoginController(ILoginService loginService)
        {
            _loginService = loginService;
        }

        [HttpGet("ValidateUser/{userName}/{password}")]
        public async Task<IActionResult> ValidateUser(string userName, string password)
        {
            var staff = await _loginService.ValidateUser(userName, password);
            //return Ok(new ApiResponse<StaffDetailsResDto>(staff));
            if (staff != null)
                return Ok(new ApiResponse<StaffDetailsResDto>(staff));
            else
                return Ok(new ApiResponse<PatientResDto>(null, false, "Invalid username or password"));
        }
        [HttpGet("ValidatePatient/{userName}/{password}")]
        public async Task<IActionResult> ValidatePatient(string userName, string password)
        {
            var validPatient = await _loginService.ValidatePatient(userName, password);
            if(validPatient != null)
                return Ok(new ApiResponse<PatientResDto>(validPatient));
            else
                return Ok(new ApiResponse<PatientResDto>(null, false, "Invalid username or password"));
        }
    }
}
