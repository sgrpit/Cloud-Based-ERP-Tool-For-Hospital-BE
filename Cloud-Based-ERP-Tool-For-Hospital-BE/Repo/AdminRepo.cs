using AutoMapper;
using Cloud_Based_ERP_Tool_For_Hospital_BE.DTOs;
using Cloud_Based_ERP_Tool_For_Hospital_BE.Repo.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cloud_Based_ERP_Tool_For_Hospital_BE.Repo
{
    public class AdminRepo : IAdminRepo
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;
        public AdminRepo(ApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public async  Task<IEnumerable<UserRoleResDto>> GetUserRolesList()
        {
            var userRoles = await _dbContext.UserRoles.ToListAsync();
            return _mapper.Map<IEnumerable<UserRoleResDto>>(userRoles);
        }
    }
}
