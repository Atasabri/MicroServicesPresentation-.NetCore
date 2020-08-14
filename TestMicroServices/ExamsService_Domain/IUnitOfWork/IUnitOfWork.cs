using ExamsService_Domain.IServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamsService_Domain.IUnitOfWork
{
    public interface IUnitOfWork
    {
        IExamService Exams { get; }
        IQuestionService Questions { get; }
        IAnswerService Answers { get; }

        void Save();
    }
}
