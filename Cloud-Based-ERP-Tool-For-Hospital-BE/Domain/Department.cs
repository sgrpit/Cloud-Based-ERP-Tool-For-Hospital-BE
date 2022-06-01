using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cloud_Based_ERP_Tool_For_Hospital_BE.Domain
{
    public class Department
    {
        [Key]
        public int Id { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentDesc { get; set; }

        //public ICollection<Staffs> Staffs { get; set; }
    }
}
