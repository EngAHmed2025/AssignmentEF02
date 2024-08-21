using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentEF02.Entites
{
    public class Students
    {
        public int ID{ get; set; }
        public string FName { get; set; }
        public string?LName { get; set; }

        public string?Address { get; set; }

        public int Age { get; set; }

        public Department? Departments { get; set; }
    }
}
