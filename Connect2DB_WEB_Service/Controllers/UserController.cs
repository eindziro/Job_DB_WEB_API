using System;
using Connect2DB_WEB_Service.Models;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Connect2DB_WEB_Service.Controllers
{

    public class UserController : ApiController
    {
        private DataPeople data = new DataPeople();

        [Route("getemployeelist")]
        public List<Employee> GetEmployeeList() => data.GetEmployeeList();

        [Route("getemployeelist/{id}")]
        public Employee GetEmployee(int Id) => data.GetEMployeeById(Id);

        [Route("addemployee")]
        public HttpResponseMessage AddEmployee([FromBody]Employee value)
        {
            if (data.AddEmployee(value)) return Request.CreateResponse(HttpStatusCode.Created);
            else return Request.CreateResponse(HttpStatusCode.BadRequest);

        }

        [Route("removeemployee")]
        public void RemoveEmployee([FromBody]int value)
        {
            var a = data.RemoveEmployee(value);

        }

        [Route("editemployee")]
        public HttpResponseMessage EditEmployee([FromBody]Employee value)
        {
            if (data.EditEmployee(value)) return Request.CreateResponse(HttpStatusCode.OK);
            else return Request.CreateResponse(HttpStatusCode.NotModified);
        }

        [Route("getdepartmentlist")]
        public List<Department> GetDepartmentList() => data.GetDepartmentList();

        [Route("adddepartment")]
        public HttpResponseMessage AddDepartment([FromBody]Department department)
        {
            if (data.AddDepartament(department)) return Request.CreateResponse(HttpStatusCode.Created);
            else return Request.CreateResponse(HttpStatusCode.BadRequest);

        }

        [Route("removedepartment")]
        public void RemoveDepartment([FromBody]int value) => data.RemoveDepartment(value);

        [Route("editdepartment")]
        public HttpResponseMessage EditDepartment(Department department)
        {
            if (data.EditDepartment(department)) return Request.CreateResponse(HttpStatusCode.OK);
            else return Request.CreateResponse(HttpStatusCode.BadRequest);


        }


    }



}

