using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cloud_Based_ERP_Tool_For_Hospital_BE.DTOs
{
    public class DepartmentReqDto
    {
        public int Id { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentDesc { get; set; }
        public bool IsAdminDepartment { get; set; }
    }

    public class DepartmentResDto
    {
        public int Id { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentDesc { get; set; }
        public bool IsAdminDepartment { get; set; }
    }
}
