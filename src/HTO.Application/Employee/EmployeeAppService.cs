using Abp.ObjectMapping;
using HTO.Employee.Dto;
using HTO.EntityFrameworkCore.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace HTO.Employee
{
    public class EmployeeAppService : BaseEmployeeAppService
    {
        private readonly ICustomUnitOfWork _unitOfWork;
        private readonly IObjectMapper _objectMapper;


        public EmployeeAppService(ICustomUnitOfWork unitOfWork, IObjectMapper objectMapper)
        {
            _unitOfWork = unitOfWork;
            _objectMapper = objectMapper;
        }

        public override void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public override void Dispose()
        {
            throw new NotImplementedException();
        }

        public override void Save(EmployeeDto model)
        {
            throw new NotImplementedException();
        }

        public override void Create()
        {
            var employee = new EntityFrameworkCore.Entities.Employee();

        }

        public override void Update(EmployeeDto model)
        {
            throw new NotImplementedException();
        }
    }
}
