using AutoMapper;
using Cloud_Based_ERP_Tool_For_Hospital_BE.DTOs;
using Cloud_Based_ERP_Tool_For_Hospital_BE.Middleware;
using Cloud_Based_ERP_Tool_For_Hospital_BE.Repo.Interface;
using Cloud_Based_ERP_Tool_For_Hospital_BE.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cloud_Based_ERP_Tool_For_Hospital_BE.Services
{
    public class LoginService: ILoginService
    {
        private readonly ILoginRepo _loginRepo;
        private readonly IStaffRepo _staffRepo;
        private readonly IMapper _mapper;

        public LoginService(ILoginRepo loginRepo, IMapper mapper, IStaffRepo staffRepo)
        {
            _loginRepo = loginRepo;
            _mapper = mapper;
            _staffRepo = staffRepo;
        }

        public async Task<StaffDetailsResDto> ValidateUser(string userName, string userPassword)
        {
            var validUserId = await _loginRepo.ValidateUser(userName, userPassword);
            if(validUserId != 0)
            {
                var staff = await _staffRepo.GetStaffsDetailsById(validUserId);
                return _mapper.Map<StaffDetailsResDto>(staff);
            }
            else
            {
                return null;
                //throw new Exception("No User Found", new KeyNotFoundException());
            }
            
        }

        public async Task<PatientResDto> ValidatePatient(string userName, string userPassword)
        {
            var validUserId = await _loginRepo.ValidatePatient(userName, userPassword);
            return _mapper.Map<PatientResDto>(validUserId);
            
        }
    }
}
