using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testProjEmpl.Models
{
    public class Employee
    {
        public int idEmp { get; set; }
        public string name { get; set; }
        public string payment { get; set;  }
    


        public ICollection<EmployementHistory> employemntHistory { get; set; }

    }
}
