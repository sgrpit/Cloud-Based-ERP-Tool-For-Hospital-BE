using AutoMapper;
using Cloud_Based_ERP_Tool_For_Hospital_BE.Domain;
using Cloud_Based_ERP_Tool_For_Hospital_BE.DTOs;
using Cloud_Based_ERP_Tool_For_Hospital_BE.Middleware;
using Cloud_Based_ERP_Tool_For_Hospital_BE.Repo.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cloud_Based_ERP_Tool_For_Hospital_BE.Repo
{
    public class DepartmentRepo : IDepartmentRepo
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;
        public DepartmentRepo(ApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public async Task<bool> DeleteDepartment(int depatId)
        {
            try
            {
                Department dept = await _dbContext.Departments.FirstOrDefaultAsync(d => d.Id == depatId);
                _dbContext.Departments.Remove(dept);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }

        public async Task<IEnumerable<DepartmentResDto>> GetAllDepartments()
        {
            
            IList<Department> departments = await _dbContext.Departments.ToListAsync();
            return _mapper.Map<IList<DepartmentResDto>>(departments);
        }

        public async Task<IEnumerable<DepartmentResDto>> GetNonAdminDepartments()
        {

            IList<Department> departments = await _dbContext.Departments.Where(d => !d.IsAdminDepartment).ToListAsync();
            return _mapper.Map<IList<DepartmentResDto>>(departments);
        }

        public async Task<DepartmentResDto> UpsertDepartment(DepartmentReqDto departmentReq)
        {
            var department = await _dbContext.Departments.FirstOrDefaultAsync(d => d.Id == departmentReq.Id);
            if(department == null)
            {
                department = _mapper.Map<Department>(departmentReq);
                _dbContext.Add(department);
            }
            else
            {
                department.DepartmentName = departmentReq.DepartmentName;
                department.DepartmentDesc = departmentReq.DepartmentDesc;
                department.IsAdminDepartment = departmentReq.IsAdminDepartment;
                _dbContext.Update(department);
            }            
            
            await _dbContext.SaveChangesAsync();
            return _mapper.Map<DepartmentResDto>(department);
        }



        
    }
}
