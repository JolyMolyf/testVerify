using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testProjEmpl.Models;

namespace testProjEmpl.Services
{
    public class DbService : IDbService
    {

        private readonly DataBaseContext dbContext;
        public DbService(DataBaseContext dbContext)
        {
            this.dbContext = dbContext;
        }


        public void getEmployeeById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EmployeeView> getEmployees()
        {

            var res2 = (from a in dbContext.employementHistory join b in dbContext.Employees on a.Employee_id equals b.idEmp select new EmployeeView {
                id = b.idEmp,
                name = b.name,
                payment = b.payment,
                position = a.position.name,
                until = a.until,
                start = a.From
            }).ToList();



            return res2.ToList();
        }

        public IEnumerable<Position> getPositions()
        {
            var res = dbContext.Positions.ToList();

            return res;
        }

        public Position getPositionsById(int id)
        {
            var position = dbContext.Positions.Where(p => p.idPosiotion == id);

            return (Position)position;
        }



        public void addEmployee(Employee employee) {
            dbContext.Add(employee);
            dbContext.SaveChanges();
        }

        public void addPosition(string name) {
            Position newPos = new Position
            {

                name = name

            };

            dbContext.Add(newPos);
            dbContext.SaveChanges();

        }

        public Position getPosByName(String name) {


            Console.WriteLine(name);
            var query = dbContext.Positions.Where(s => s.name == name).FirstOrDefault<Position>();


            Console.WriteLine(query.idPosiotion + " here is my query");

            if (query == null) {
                Position pos = new Position
                {
                    name = name
                };
                dbContext.Add(pos);
                dbContext.SaveChanges(); 

                query = dbContext.Positions.Where(s => s.name == name).FirstOrDefault<Position>();

            }
            return query; 

        }

        public int getLastEmp()
        {
            var emp = dbContext.Employees.Max(x => x.idEmp);


            return emp;

        }

        public object getPosByName()
        {
            throw new NotImplementedException();
        }


        public void addEmpHistory(EmployementHistory empH) {

            dbContext.Add(empH);
            dbContext.SaveChanges();

            Console.WriteLine("added history"); 

        }
    }
}
