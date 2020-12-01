using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testProjEmpl.Models
{
    public class EmployementHistory
    {

    

        public int Employee_id { get; set; }

        public int position_id { get; set; }

        public Employee employee { get; set; }

        public Position position { get; set; }

        public string From { get; set; }

        public string until { get; set; }


    }
}
