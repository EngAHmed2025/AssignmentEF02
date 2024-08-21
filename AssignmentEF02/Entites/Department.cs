using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentEF02.Entites
{
    public class Department
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Students> Students { get; set; } = new HashSet<Students>();
        public int Ins_ID { get; set; }

        public DateTime HiringDate { get; set; }

        [InverseProperty("Departments")]
        [ForeignKey("Ins_ID")]
      
        public ICollection<Instructor> Instructors { get; set; } = new HashSet<Instructor>();

        [InverseProperty("Dep")]
        public Instructor? Instructor { get; set; }

    }
}
