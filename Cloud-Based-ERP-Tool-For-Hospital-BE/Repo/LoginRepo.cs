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
    public class LoginRepo : ILoginRepo
    {
        private readonly ApplicationDbContext _dbContext;

        public LoginRepo(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<int> ValidateUser(string userName, string userPassword)
        {
            var validatedUser = await _dbContext.LoginDetails.FirstOrDefaultAsync(s => s.UserName == userName && s.UserPassword == userPassword);
            if (validatedUser != null)
                return validatedUser.StaffId;
            else
                return 0;            
        }

        public async Task<Patients> ValidatePatient(string userName, string userPassword)
        {
            var validatedUser = await _dbContext.Patients.FirstOrDefaultAsync(p => p.MobileNo == userName);
            return validatedUser;
        }
    }
}
