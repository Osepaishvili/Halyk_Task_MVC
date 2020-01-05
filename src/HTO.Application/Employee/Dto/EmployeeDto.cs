using System;
using System.Collections.Generic;
using System.Text;

namespace HTO.Employee.Dto
{
    public class EmployeeDto
    {

        public string Name { get; set; }


        public string SurName { get; set; }


        public string PersonalId { get; set; }


        public DateTime BirthDate { get; set; }


        public string Nationality { get; set; }


        public decimal Salary { get; set; }


        public string Currency { get; set; }

        public List<string> PhoneNumbers { get; set; }
    }
}
