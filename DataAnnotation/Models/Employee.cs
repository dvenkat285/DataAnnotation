using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DataAnnotation.Models
{
    public class Employee
    {

        [Required(ErrorMessage = "Id is mandatory")]
        public int EmployeeId { get; set; }
        [Required(ErrorMessage = "Name is mandatory")]
        [StringLength(20,MinimumLength =5, ErrorMessage ="Name should be between 5 and 20")]
        public string EmployeeName { get; set; }
        [Required(ErrorMessage = "Age is mandatory")]
        [Range(20,60, ErrorMessage = "Age should be in the range of 20 and 60")]
        public int? EmployeeAge { get; set; }
        [Required(ErrorMessage = "Gender is mandatory")]
        public string EmployeeGender { get; set; }
        [Required(ErrorMessage = "Email is mandatory")]
        [RegularExpression("^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$", ErrorMessage ="Invalid Email")]
        public string EmployeeEmail { get; set; }

        [Required(ErrorMessage = "Employee password is mandatory")]
        [RegularExpression(@"(?=^.{8,}$)((?=.*\d)|(?=.*\W+))(?![.\n])(?=.*[A-Z])(?=.*[a-z]).*$", ErrorMessage = "UpperCase, LowerCase, Numbers, Symbols, 8 Charactors")]
        public string EmpPassword { get; set; }

    }
}