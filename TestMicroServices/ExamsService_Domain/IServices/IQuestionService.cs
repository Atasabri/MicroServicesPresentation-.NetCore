using ExamsService_Domain.IRepositories;
using ExamsService_Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamsService_Domain.IServices
{
    public interface IQuestionService : IGeneralRepository<Question>
    {
    }
}
