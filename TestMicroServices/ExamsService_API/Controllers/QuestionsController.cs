using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExamsService_Domain.IUnitOfWork;
using ExamsService_Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExamsService_API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class QuestionsController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;

        public QuestionsController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        [HttpGet]
        public ActionResult Index()
        {
            return Ok(unitOfWork.Questions.AllData());
        }

        [HttpGet]
        public ActionResult FindByID(int ID)
        {
            return Ok(unitOfWork.Questions.Find(ID));
        }

        [HttpGet]
        public ActionResult FindBy(string Key, string Value)
        {
            return Ok(unitOfWork.Questions.GetEntities(entity =>
            (string)entity.GetType().GetProperty(Key).GetValue(entity, null)
            == Value));
        }
        [HttpGet]
        public ActionResult FindSingle(string Key, string Value)
        {
            return Ok(unitOfWork.Questions.FindElement(entity =>
            (string)entity.GetType().GetProperty(Key).GetValue(entity, null)
            == Value));
        }

        [HttpPost]
        public ActionResult CreateOrUpdate([FromBody] Question question)
        {
            unitOfWork.Questions.CreateOrUpdate(question);
            unitOfWork.Save();

            return Ok();
        }
        [HttpDelete]
        public ActionResult Delete([FromBody] Question question)
        {
            unitOfWork.Questions.Delete(question);
            unitOfWork.Save();

            return Ok();
        }
    }
}