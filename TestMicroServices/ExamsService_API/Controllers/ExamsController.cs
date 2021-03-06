﻿using System;
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
    public class ExamsController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;

        public ExamsController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        [HttpGet]
        public ActionResult Index()
        {
            return Ok(unitOfWork.Exams.AllData());
        }

        [HttpGet]
        public ActionResult FindByID(int ID)
        {
            return Ok(unitOfWork.Exams.Find(ID));
        }

        [HttpGet]
        public ActionResult FindBy(string Key, string Value)
        {
            return Ok(unitOfWork.Exams.GetEntities(entity =>
            (string)entity.GetType().GetProperty(Key).GetValue(entity, null)
            == Value));
        }
        [HttpGet]
        public ActionResult FindSingle(string Key, string Value)
        {
            return Ok(unitOfWork.Exams.FindElement(entity =>
            (string)entity.GetType().GetProperty(Key).GetValue(entity, null)
            == Value));
        }

        [HttpPost]
        public ActionResult CreateOrUpdate([FromBody] Exam exam)
        {
            unitOfWork.Exams.CreateOrUpdate(exam);
            unitOfWork.Save();

            return Ok();
        }
        [HttpDelete]
        public ActionResult Delete([FromBody] Exam exam)
        {
            unitOfWork.Exams.Delete(exam);
            unitOfWork.Save();

            return Ok();
        }
    }
}