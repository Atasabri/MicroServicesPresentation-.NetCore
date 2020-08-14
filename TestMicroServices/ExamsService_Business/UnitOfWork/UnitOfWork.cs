using ExamsService_Business.Services;
using ExamsService_Domain.DBContext;
using ExamsService_Domain.IServices;
using ExamsService_Domain.IUnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamsService_Business.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DBExams db;
        public UnitOfWork(DBExams _db)
        {
            db = _db;
        }

        private IExamService exams;
        private IQuestionService questions;
        private IAnswerService answers;


        public IExamService Exams
        {
            get
            {
                if (exams == null)
                {
                    exams = new ExamService(db);
                }

                return exams;
            }
        }

        public IQuestionService Questions
        {
            get
            {
                if (questions == null)
                {
                    questions = new QuestionService(db);
                }

                return questions;
            }
        }
        public IAnswerService Answers
        {
            get
            {
                if (answers == null)
                {
                    answers = new AnswerService(db);
                }
                return answers;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
