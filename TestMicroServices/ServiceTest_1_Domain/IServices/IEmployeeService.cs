using PersonsService_Domain.IRepositories;
using PersonsService_Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsService_Domain.IServices
{
    public interface IEmployeeService : IGeneralRepository<Employee>
    {
    }
}
