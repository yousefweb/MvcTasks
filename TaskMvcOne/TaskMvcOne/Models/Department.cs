using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TaskMvcOne.Models
{
    public class Department
    {
        [Key]
        public int departmentId { get; set; }
        [Required(ErrorMessage ="Please insert department type")]
        [Display(Name ="Department Type")]
        public string departmentType { get; set; }
    }
}
