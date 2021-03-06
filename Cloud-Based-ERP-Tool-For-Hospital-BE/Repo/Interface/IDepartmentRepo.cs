using Cloud_Based_ERP_Tool_For_Hospital_BE.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cloud_Based_ERP_Tool_For_Hospital_BE.Repo.Interface
{
    public interface IDepartmentRepo
    {
        Task<IEnumerable<DepartmentResDto>> GetAllDepartments();
        Task<IEnumerable<DepartmentResDto>> GetNonAdminDepartments();
        Task<DepartmentResDto> UpsertDepartment(DepartmentReqDto departmentReq);
        Task<bool> DeleteDepartment(int depatId);
    }
}
