using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentEF02.Entites
{
    public class Instructor
    {

        public int  Id { get; set; }

        public string Name { get; set; }


        public double Bouns { get; set; }

        public double Salary { get; set; }

        public string?Address{ get; set; }

        public DateTime HourRate { get; set; }

        public int Dept_ID { get; set; }

        [InverseProperty("Instructor")]
        [ForeignKey("Dept_ID")]
        [DeleteBehavior(DeleteBehavior.Restrict)]
        public Department? Dep { get; set; }

        [InverseProperty("Instructors")]
        public Department? Departments { get; set; }

    }
}
