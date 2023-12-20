using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TaskMvcOne.Models
{
    public class Tasks
    {
    
        [Key]
        public int TasksId { get; set; }

        [Required]
        [Display(Name ="Task Title")]
        [DataType(DataType.Text)]
        public string taskTitle { get; set; }

        [Required]
        [Display(Name = "Start Date")]
        [DataType(DataType.Date)]
        public DateTime startDate { get; set; }

        [Required]
        [Display(Name = "Due Date")]
        [DataType(DataType.Date)]
        public DateTime duetDate { get; set; }

        
        [DataType(DataType.Text)]
        public string Description { get; set; }


        public ICollection<Employee> Employees { get; set; }

    }
}
