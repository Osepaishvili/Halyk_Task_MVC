using HTO.EntityFrameworkCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HTO.EntityFrameworkCore.Repositories
{
    public class EmployeeRepo : GenericRepository<Employee>
    {
        public EmployeeRepo(HTODbContext context) : base(context)
        {
        }
    }
}
