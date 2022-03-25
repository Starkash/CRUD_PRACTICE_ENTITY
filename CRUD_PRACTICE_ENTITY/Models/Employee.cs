using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_PRACTICE_ENTITY.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [DisplayName("EmpName")]
        [Required(ErrorMessage ="EmpName is Required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Email is Required")]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        
        public string MobileNo { get; set; }
        [Required]
        [MinLength(11)]
        public string Address { get; set; }

    }
}
