﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HTO.Employee.Dto
{
    public class EmployeeDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string SurName { get; set; }

        public string PersonalId { get; set; }

        public DateTime BirthDate { get; set; }

        public string Nationality { get; set; }

    }
}
