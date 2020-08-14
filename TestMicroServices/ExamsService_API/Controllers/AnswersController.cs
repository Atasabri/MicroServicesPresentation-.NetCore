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
    public class AnswersController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;

        public AnswersController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        [HttpGet]
        public ActionResult Index()
        {
            return Ok(unitOfWork.Answers.AllData());
        }

        [HttpGet]
        public ActionResult FindByID(int ID)
        {
            return Ok(unitOfWork.Answers.Find(ID));
        }

        [HttpGet]
        public ActionResult FindBy(string Key, string Value)
        {
            return Ok(unitOfWork.Answers.GetEntities(entity =>
            (string)entity.GetType().GetProperty(Key).GetValue(entity, null)
            == Value));
        }
        [HttpGet]
        public ActionResult FindSingle(string Key, string Value)
        {
            return Ok(unitOfWork.Answers.FindElement(entity =>
            (string)entity.GetType().GetProperty(Key).GetValue(entity, null)
            == Value));
        }

        [HttpPost]
        public ActionResult CreateOrUpdate([FromBody] Answer answer)
        {
            unitOfWork.Answers.CreateOrUpdate(answer);
            unitOfWork.Save();

            return Ok();
        }
        [HttpDelete]
        public ActionResult Delete([FromBody] Answer answer)
        {
            unitOfWork.Answers.Delete(answer);
            unitOfWork.Save();

            return Ok();
        }
    }
}