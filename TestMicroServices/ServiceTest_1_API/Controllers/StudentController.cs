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
    public class StudentController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;

        public StudentController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        [HttpGet]
        public ActionResult Index()
        {
            return Ok(unitOfWork.Students.AllData());
        }

        [HttpGet]
        public ActionResult FindByID(int ID)
        {
            return Ok(unitOfWork.Students.Find(ID));
        }

        [HttpGet]
        public ActionResult FindBy(string Key,string Value)
        {
            return Ok(unitOfWork.Students.GetEntities(entity => 
            (string)entity.GetType().GetProperty(Key).GetValue(entity, null) 
            == Value));
        }
        [HttpGet]
        public ActionResult FindSingle(string Key, string Value)
        {
            return Ok(unitOfWork.Students.FindElement(entity =>
            (string)entity.GetType().GetProperty(Key).GetValue(entity, null)
            == Value));
        }

        [HttpPost]
        public ActionResult CreateOrUpdate([FromBody] Student student)
        {
            unitOfWork.Students.CreateOrUpdate(student);
            unitOfWork.Save();

            return Ok();
        }
        [HttpDelete]
        public ActionResult Delete([FromBody] Student student)
        {
            unitOfWork.Students.Delete(student);
            unitOfWork.Save();

            return Ok();
        }
    }
}