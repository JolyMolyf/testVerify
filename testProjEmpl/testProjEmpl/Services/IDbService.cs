using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testProjEmpl.Models;

namespace testProjEmpl.Services
{
    public interface IDbService
    {

        public IEnumerable<EmployeeView> getEmployees();
        public void getEmployeeById(int id);
        public IEnumerable<Position> getPositions();
        public Position getPositionsById(int id);

        public void addPosition(string name);

        public void addEmployee(Employee emp);

        public int getLastEmp();
        public Position getPosByName(string name);
        object getPosByName();
        void addEmpHistory(EmployementHistory empH);
    }
}
