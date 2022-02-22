using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace SimpleCURD.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Display(Name = "Employee Name")]
        [Required(ErrorMessage ="Employee Name Can't Empty!")]
        [MinLength(3,ErrorMessage ="Min length for name is 3 char!")]
        [MaxLength(30,ErrorMessage ="Max length for name is 30 Char")]
        public string Name { get; set; }

        [Display(Name ="Employee Email")]
        [Required(ErrorMessage = "Employee Email Can't Empty!")]
        [EmailAddress(ErrorMessage ="Email addres is not valid!")]
        public string Email { get; set; }


        [Display (Name ="Employee Mobile No.")]
        [Required(ErrorMessage = "Employee Mobile Can't Empty!")]
        [RegularExpression(@"^[\\+]?[(]?[0-9]{3}[)]?[-\\s\\.]?[0-9]{3}[-\\s\\.]?[0-9]{4,6}$",
            ErrorMessage ="Invalid Mobile No.!")]
        public string Mobile { get; set; }


        [Display(Name="Employee Address")]
        [Required(ErrorMessage = "Employee Address Can't Empty!")]
        [MaxLength(200,ErrorMessage ="Max @00 Char!")]
        public string Address { get; set; }
    }
}
