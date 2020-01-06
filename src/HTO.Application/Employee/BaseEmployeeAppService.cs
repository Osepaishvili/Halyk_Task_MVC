using HTO.Employee.Dto;
using HTO.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace HTO.Employee
{
    public abstract class BaseEmployeeAppService : GeneralAdminService<EmployeeManageDto, EmployeeDto>
    {
        public abstract EmployeeManageDto GetViewModel(int id);

        public abstract void FillManageDtoWithInitialData(EmployeeManageDto model);

    }
}
