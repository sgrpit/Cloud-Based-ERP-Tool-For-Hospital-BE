using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cloud_Based_ERP_Tool_For_Hospital_BE.Domain
{
    public class LoginDetails
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }

        [ForeignKey("FK_Department")]
        public int StaffId { get; set; }
        public virtual Staffs Staff { get; set; }
        //public virtual Patients Patients { get; set; }
    }
}
