using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cloud_Based_ERP_Tool_For_Hospital_BE.Domain
{
    public class Staffs
    {
        [Key]
        public int Id { get; set; }
        public string StaffId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LasName { get; set; }
        public string MobileNo { get; set; }
        public string EmailId { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string Gender { get; set; }
        public string DateOfBirth { get; set; }
        public string JoiningDate { get; set; }
        public bool IsPermananet { get; set; }        
        public string CreatedBy { get; set; }
        public string CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public string ModifiedOn { get; set; }

        [ForeignKey("FK_Department")]
        public int o { get; set; }

        [ForeignKey("FK_UserRole")]
        public int RoleId { get; set; }

        public Department Departments { get; set; }

        public UserRole UserRole { get; set; }

    }
}
