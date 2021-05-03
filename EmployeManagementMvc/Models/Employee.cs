using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EmployeManagementMvc.Models
{
    public class Employee
    {
       [Required(ErrorMessage ="Enter Name")]
       [Display(Name="Enter Name")]
       [StringLength(maximumLength:10,MinimumLength =3,ErrorMessage ="Name Length Must Be Maximun 10 & Minimum 3")]

        public string Name { get; set; }
        [Required(ErrorMessage = "Please Enter Age")]
        [Range(18,50)]
        public int Age { get; set; }
        [Required(ErrorMessage ="Please Enter Email Address")]
        [Display(Name ="Email Id:")]
        public string Email { get; set; }
    }
}