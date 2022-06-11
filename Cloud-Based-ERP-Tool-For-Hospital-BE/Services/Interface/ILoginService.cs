using Cloud_Based_ERP_Tool_For_Hospital_BE.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cloud_Based_ERP_Tool_For_Hospital_BE.Services.Interface
{
    public interface ILoginService
    {
        Task<StaffDetailsResDto> ValidateUser(string userName, string userPassword);
        Task<PatientResDto> ValidatePatient(string userName, string userPassword);
    }
}
