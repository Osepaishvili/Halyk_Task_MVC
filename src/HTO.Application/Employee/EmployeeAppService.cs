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

        protected override void Create(EmployeeManageDto model)
        {
            var employee = new HTO.EntityFrameworkCore.Entities.Employee
            {
                Name = model.Name,
                SurName = model.SurName,
                Nationality = model.Nationality,
                BirthDate = model.BirthDate,
                PersonalId = model.PersonalId,
                Salary = model.Salary,
                Currency = model.Currency
            };

            //foreach (var phone in model.PhoneNumbers)
            //{
            //    var number = new HTO.EntityFrameworkCore.Entities.Phone
            //    {
            //        Number = phone
            //    };
            //}

            _unitOfWork.EmployeeRepo.Insert(employee);
            _unitOfWork.Save();
        }

        public override void Delete(int id)
        {
            var dboEmployee = _unitOfWork.EmployeeRepo.GetById(id);

            dboEmployee.IsDeleted = true;

            _unitOfWork.EmployeeRepo.Update(dboEmployee);
            _unitOfWork.Save();
        }

        public override void Dispose()
        {
            _unitOfWork.Dispose();
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
            if (model.Id == 0)
                Create(model);
            else
                Update(model);
        }

        protected override void Update(EmployeeManageDto model)
        {
            var dboEmployee = _unitOfWork.EmployeeRepo.Set()
                .First(a => a.Id == model.Id);

            dboEmployee.Name = model.Name;
            dboEmployee.SurName = model.SurName;
            dboEmployee.Nationality = model.Nationality;
            dboEmployee.BirthDate = model.BirthDate;
            dboEmployee.PersonalId = model.PersonalId;
            dboEmployee.Salary = model.Salary;
            dboEmployee.Currency = model.Currency;

            _unitOfWork.EmployeeRepo.Update(dboEmployee);
            _unitOfWork.Save();
        }

        public override EmployeeManageDto GetViewModel(int id)
        {
            var model = new EmployeeManageDto();

            if (id == 0)
                return model;

            var dboEmployee = _unitOfWork.EmployeeRepo.Set()
                .First(a => a.Id == id);

            model.Id = dboEmployee.Id;
            model.BirthDate = dboEmployee.BirthDate;
            model.Currency = dboEmployee.Currency;
            model.Name = dboEmployee.Name;
            model.SurName = dboEmployee.SurName;
            model.Salary = dboEmployee.Salary;
            model.PersonalId = dboEmployee.PersonalId;
            model.Nationality = dboEmployee.Nationality;

            return model;
        }

        public override void FillManageDtoWithInitialData(EmployeeManageDto model)
        {
            //დროპდაუნების ჩამატება თუ დამჭირდება
            throw new NotImplementedException();
        }
    }
}
