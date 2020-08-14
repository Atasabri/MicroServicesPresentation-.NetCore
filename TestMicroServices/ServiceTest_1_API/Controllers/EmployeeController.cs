using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonsService_Domain.IUnitOfWork;
using PersonsService_Domain.Models;

namespace PersonsService_API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;

        public EmployeeController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        [HttpGet]
        public ActionResult Index()
        {
            return Ok(unitOfWork.Employees.AllData());
        }

        [HttpGet]
        public ActionResult FindByID(int ID)
        {
            return Ok(unitOfWork.Employees.Find(ID));
        }

        [HttpGet]
        public ActionResult FindBy(string Key, string Value)
        {
            return Ok(unitOfWork.Employees.GetEntities(entity =>
            (string)entity.GetType().GetProperty(Key).GetValue(entity, null)
            == Value));
        }
        [HttpGet]
        public ActionResult FindSingle(string Key, string Value)
        {
            return Ok(unitOfWork.Employees.FindElement(entity =>
            (string)entity.GetType().GetProperty(Key).GetValue(entity, null)
            == Value));
        }

        [HttpPost]
        public ActionResult CreateOrUpdate([FromBody] Employee employee)
        {
            unitOfWork.Employees.CreateOrUpdate(employee);
            unitOfWork.Save();

            return Ok();
        }
        [HttpDelete]
        public ActionResult Delete([FromBody] Employee employee)
        {
            unitOfWork.Employees.Delete(employee);
            unitOfWork.Save();

            return Ok();
        }
    }
}