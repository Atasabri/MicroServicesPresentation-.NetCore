using PersonsService_Business.Services;
using PersonsService_Domain.DBContext;
using PersonsService_Domain.IServices;
using PersonsService_Domain.IUnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsService_Business.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DB db;
        public UnitOfWork(DB _db)
        {
            db = _db;
        }
        private IStudentService students;
        private IEmployeeService employees;


        public IStudentService Students {
            get
            {
                if (students == null)
                {
                    students = new StudentService(db);
                }

                return students;
            }
        }

        public IEmployeeService Employees {
            get
            {
                if (employees == null)
                {
                    employees = new EmployeeService(db);
                }

                return employees;
            }

        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
