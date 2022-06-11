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
        [Required]
        [Key]
        public int Id { get; set; }
        [Required]
        public string StaffId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string MiddleName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string MobileNo { get; set; }
        public string EmailId { get; set; }
        public string Address { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string ZipCode { get; set; }
        [Required]
        public string Gender { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        [DataType(DataType.Date)]
        public DateTime JoiningDate { get; set; }
        public bool IsPermanent { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        //[ForeignKey("FK_Department")]
        //public int DepartmentId { get; set; }

        //[ForeignKey("FK_UserRole")]
        //public int RoleId { get; set; }

        [Required]
        [ForeignKey("FK_Department")]
        public int DepartmentsId { get; set; }

        public virtual Department Departments { get; set; }

        [ForeignKey("FK_UserRole")]
        public int UserRoleId { get; set; } = 1;
        public virtual UserRole UserRole { get; set; }

        public virtual ICollection<PatientAppointment> PatientAppointments { get; set; }
        public virtual ICollection<InPatientDirectory> InPatientDirectories { get; set; }
    }
}
