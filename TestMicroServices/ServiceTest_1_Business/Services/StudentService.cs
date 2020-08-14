using PersonsService_Business.Repositories;
using PersonsService_Domain.DBContext;
using PersonsService_Domain.IServices;
using PersonsService_Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsService_Business.Services
{
    class StudentService : GeneralRepository<Student>, IStudentService
    {
        public StudentService(DB db) : base(db)
        {
        }
    }
}
