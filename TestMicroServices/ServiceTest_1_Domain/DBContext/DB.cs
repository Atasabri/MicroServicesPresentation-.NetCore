using Microsoft.EntityFrameworkCore;
using PersonsService_Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsService_Domain.DBContext
{
   public class DB : DbContext
    {
        public DB(DbContextOptions<DB> options) : base(options)
        {

        }


        public DbSet<Employee> Employees { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
