using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cloud_Based_ERP_Tool_For_Hospital_BE.Domain
{
    public class UserRole
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string RoleName { get; set; }
        public string RoleDescription { get; set; }
        //public virtual ICollection<Staffs> Staffs { get; set; }
    }
}
