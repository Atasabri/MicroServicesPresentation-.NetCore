using PersonsService_Domain.IServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsService_Domain.IUnitOfWork
{
    public interface IUnitOfWork
    {
        IStudentService Students { get; }
        IEmployeeService Employees { get; }

        void Save();
    }
}
