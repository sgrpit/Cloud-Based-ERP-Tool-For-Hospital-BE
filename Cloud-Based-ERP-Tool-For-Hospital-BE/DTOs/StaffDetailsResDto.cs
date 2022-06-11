using Cloud_Based_ERP_Tool_For_Hospital_BE.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cloud_Based_ERP_Tool_For_Hospital_BE.DTOs
{
    public class StaffDetailsResDto
    {
        public int Id { get; set; }
        public string StaffId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string MobileNo { get; set; }
        public string EmailId { get; set; }
        public int UserRoleId { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string Gender { get; set; }
        public bool Ispermanent { get; set; } = true;
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        [DataType(DataType.Date)]
        public DateTime JoiningDate { get; set; }
        public int DepartmentsId { get; set; }
        public DepartmentResDto Departments { get; set; }
        public UserRole UserRole { get; set; }
    }

    public class CreateStaffReqDto
    {        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string MobileNo { get; set; }
        public string EmailId { get; set; }
        //public int RoleId { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string Gender { get; set; }
        public bool Ispermanent { get; set; } = true;
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        [DataType(DataType.Date)]
        public DateTime JoiningDate { get; set; }
        public int DepartmentsId { get; set; }
    }

    public class UpdateStaffReqDto
    {
        public int Id { get; set; }
        public string StaffId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string MobileNo { get; set; }
        public string EmailId { get; set; }
        //public int RoleId { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string Gender { get; set; }
        public bool Ispermanent { get; set; } = true;
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        [DataType(DataType.Date)]
        public DateTime JoiningDate { get; set; }
        public int DepartmentsId { get; set; }
    }
}
