using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HTO.EntityFrameworkCore.Repositories
{
    public class CustomUnitOfWork : ICustomUnitOfWork
    {
        private readonly HTODbContext _context = new HTODbContext(new DbContextOptions<HTODbContext>());

        private EmployeeRepo _employeeRepo;

        public void Save()
        {
            _context.SaveChanges();
        }

        private bool _disposed;

        public EmployeeRepo EmployeeRepo
        {
            get
            {
                if (this._employeeRepo == null)
                    this._employeeRepo = new EmployeeRepo(_context);

                return _employeeRepo;
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this._disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
