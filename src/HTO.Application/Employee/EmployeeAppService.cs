using Abp.ObjectMapping;
using HTO.Employee.Dto;
using HTO.EntityFrameworkCore.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public override void Create(EmployeeManageDto model)
        {
            throw new NotImplementedException();
        }

        public override void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public override void Dispose()
        {
            throw new NotImplementedException();
        }
        
        public override IEnumerable<EmployeeDto> GetTableViewModels()
        {
            var model = _unitOfWork.EmployeeRepo.Set()
                .Where(a => !a.IsDeleted)
                .Select(a => new EmployeeDto
                {
                    Id = a.Id,
                    Name = a.Name,
                    SurName = a.SurName,
                    BirthDate = a.BirthDate, 
                    PersonalId = a.PersonalId,
                    Nationality = a.Nationality
                }).OrderByDescending(a => a.Id).ToList();

            return model;
        }



        public override void Save(EmployeeManageDto model)
        {
            throw new NotImplementedException();
        }

        public override void Update(EmployeeManageDto model)
        {
            throw new NotImplementedException();
        }
    }
}
