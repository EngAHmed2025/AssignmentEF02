using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentEF02.Entites
{
    public class Topic
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("Top_ID")]
        public Course? Courses { get; set; }
        
    }
}
