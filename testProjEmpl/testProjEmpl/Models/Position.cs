using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testProjEmpl.Models
{
    public class Position
    {

        public int idPosiotion { get; set; } 
        public string name { get; set; }

        public ICollection<EmployementHistory> employemntHistory { get; set; }
    }
}
