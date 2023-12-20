using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TaskMvcOne.Models
{
    public class Manager
    {
        [Key]
        public int ManagerId { get; set; }

        [DataType(DataType.Text)]
        [Display(Name ="Manager Name")]
        [Required]
        public string ManagerName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name ="Password Manager")]
        public string ManagerPassword { get; set; }

    }
}
