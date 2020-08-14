using ExamsService_Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamsService_Domain.DBContext
{
    public class DBExams : DbContext
    {
        public DBExams(DbContextOptions<DBExams> options) : base(options)
        {

        }


        public DbSet<Exam> Exams { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }

    }
}
