using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TaskMvcOne.Models
{
    public class Feedback
    {
        [Key]
        public int FeedbackId { get; set; }

        [Display(Name ="Sender First Name")]
        [Required]
        [DataType(DataType.Text)]
        public string senderFname { get; set; }

        [Display(Name = "Sender Last Name")]
        [Required]
        [DataType(DataType.Text)]
        public string senderLname { get; set; }

        [Display(Name = "Feedback Massege")]
        [Required]
        [DataType(DataType.Text)]
        public string msg { get; set; }

        public Manager Manager { get; set; }
        public int ManagerId { get; set; }
    }
}
