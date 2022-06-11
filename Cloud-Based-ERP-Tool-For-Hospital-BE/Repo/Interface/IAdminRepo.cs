using Cloud_Based_ERP_Tool_For_Hospital_BE.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cloud_Based_ERP_Tool_For_Hospital_BE.Repo.Interface
{
    public interface IAdminRepo
    {
        Task<IEnumerable<UserRoleResDto>> GetUserRolesList();
    }
}
