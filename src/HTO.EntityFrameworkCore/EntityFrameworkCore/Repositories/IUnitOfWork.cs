using System;
using System.Collections.Generic;
using System.Text;

namespace HTO.EntityFrameworkCore.Repositories
{
    public interface ICustomUnitOfWork : IDisposable
    {

        EmployeeRepo EmployeeRepo { get; }
        void Save();

    }
}
