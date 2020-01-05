using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HTO.EntityFrameworkCore.Entities
{
    public class Employee : BaseEntity
    {
        /// <summary>
        /// სახელი
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// გვარი
        /// </summary>
        [Required]
        public string SurName { get; set; }

        /// <summary>
        /// პირადი ნომერი
        /// </summary>
        [Required]
        public string PersonalId { get; set; }

        /// <summary>
        /// დაბადების თარიღი
        /// </summary>
        [Required]
        public DateTime BirthDate { get; set; }

        /// <summary>
        /// ეროვნება 
        /// </summary>
        [Required]
        public string Nationality { get; set; }

        /// <summary>
        /// ხელფასი
        /// </summary>
        public decimal Salary { get; set; }

        /// <summary>
        /// ხელფასის ვალუტა
        /// </summary>
        public string Currency { get; set; }

        /// <summary>
        /// მობილური ტელ. ნომერი 
        /// </summary>
        public List<Phone> PhoneNumber { get; set; }
    }
}
