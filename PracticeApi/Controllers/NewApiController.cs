using PracticeApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PracticeApi.Controllers
{
    public class NewApiController : ApiController
    {
        employeeEntities db = new employeeEntities();

        [System.Web.Http.HttpGet]
        public IHttpActionResult GetEmployee()
        {
            List<employee> list = db.employees.ToList();
            return Ok(list);
        }

        [System.Web.Http.HttpPost]
        public IHttpActionResult EmpInsert(employee e)
        {
            if(ModelState.IsValid)
            {
                db.employees.Add(e);
                db.SaveChanges();

            }

            return Ok();
        }

        [System.Web.Http.HttpGet]
        public IHttpActionResult GetEmployeeById(int id)
        {
            var emp = db.employees.Where(model => model.employee_id == id).FirstOrDefault();
            return Ok(emp);
        }


        [System.Web.Http.HttpPut]
        public IHttpActionResult EmpUpdate(employee e)
        {
            db.Entry(e).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return Ok();
        }

        [System.Web.Http.HttpDelete]
        public IHttpActionResult EmpDelete(int id)
        {

            var emp = db.employees.Where(model => model.employee_id == id).FirstOrDefault();
            db.Entry(emp).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();

            return Ok();
        }
    }
}
