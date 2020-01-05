using System;
using System.Collections.Generic;
using System.Text;

namespace HTO.EntityFrameworkCore.Entities
{
    public class Phone : BaseEntity
    {
        /// <summary>
        /// ტელეფონის ნომერი
        /// </summary>
        public string Number { get; set; }
    }
}
