using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProjet.Data.Entities
{
    public class DepartmentSubject
    {
        [Key]
        public int DeptSubID { get; set; }
        public int DeptID { get; set; }
        public int SubID { get; set; }

        [ForeignKey("DeptID")]
        public virtual Department Departments { get; set; }
        [ForeignKey("SubID")]
        public virtual Subject Subjects { get; set; }
    }
}
