using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testProjEmpl.Models;
using testProjEmpl.Services;

namespace testProjEmpl.Controllers
{
    [Route("api")]
    [ApiController]
    public class EmployerController : ControllerBase
    {

        private IDbService dbservice;

        public EmployerController(IDbService dbservice)
        {
            this.dbservice = dbservice;
        }

        [HttpGet]
        public IEnumerable<EmployeeView> Index()
        {
        
            return dbservice.getEmployees() ;
        }


        [HttpGet]
        [Route("positions")]
        public IEnumerable<Position> renderPositions() {

            return dbservice.getPositions(); 
        }

        [HttpPost]
        [Route("add")]
        public void AddPosition(Object data) {

            var obj = Newtonsoft.Json.JsonConvert.DeserializeObject<Position>(data.ToString());


            dbservice.addPosition(obj.name);    
            
        
        }

        [HttpPost]
        [Route("addEmp")]
        public void AddEmp(Object data) {

            var obj = Newtonsoft.Json.JsonConvert.DeserializeObject<RecievedEmp>(data.ToString());

            Employee emp = new Employee
            {
                name = obj.name, 
                payment = obj.payment
            };

            Position pos = new Position {
                name = obj.title, 


            };

            dbservice.addEmployee(emp);
            
            var idEmp = dbservice.getLastEmp();
            var posId = dbservice.getPosByName(pos.name);

            

            Console.WriteLine(posId + " hwejrhkewhrkjew");


            EmployementHistory empHis = new EmployementHistory
            {
                From = obj.employed,
                until = obj.fired,
                position = pos,
                employee = emp,
                Employee_id = idEmp,
                position_id = posId.idPosiotion

            };


            dbservice.addEmpHistory(empHis); 


        }

    }
}
