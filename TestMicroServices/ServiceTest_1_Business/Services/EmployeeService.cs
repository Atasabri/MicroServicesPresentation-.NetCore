using PersonsService_Business.Repositories;
using PersonsService_Domain.DBContext;
using PersonsService_Domain.IServices;
using PersonsService_Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsService_Business.Services
{
    class EmployeeService : GeneralRepository<Employee> , IEmployeeService
    {
        public EmployeeService(DB db) : base(db)
        {
        }
    }
}
