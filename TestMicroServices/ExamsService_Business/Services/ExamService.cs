using ExamsService_Business.Repositories;
using ExamsService_Domain.DBContext;
using ExamsService_Domain.IServices;
using ExamsService_Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamsService_Business.Services
{
    public class ExamService : GeneralRepository<Exam>, IExamService
    {
        public ExamService(DBExams db) : base(db)
        {
        }
    }
}
