using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TaskMvcOne.Models
{
    public class Employee
    {
      
        [Key]
        public int EmployeeId { get; set; }

        [Required(ErrorMessage = "Enter The Employee Name")]
        [Display(Name = "Employee Name")]
        [DataType(DataType.Text)]
        public string EmployeeName { get; set; }

        [Required(ErrorMessage = "Employee Birth date")]
        [Display(Name = "Employee Birth date")]
        [DataType(DataType.Date)]
        public DateTime EmpBirthdate { get; set; }

        [Required(ErrorMessage = "Enter Phone Number")]
        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        public int EmpPhoneNumber { get; set; }

        [Required(ErrorMessage = "Enter the nationlID")]
        public string NationalID { get; set; }

        [Required(ErrorMessage = "Enter the nationality")]
        public string Nationalties{ get; set; }

        [Display(Name="Personal Photo")]
        public string personalPhoto { get; set; }

        [Required(ErrorMessage ="please enter the entry date")]
        [Display( Name ="Entry Date")]
        [DataType(DataType.Date)]
        public DateTime entryDate { get; set; }

        [Required(ErrorMessage ="please enter the password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [ForeignKey("departmentId")]
        public int departmentId { get; set; }
        public Department Department { get; set; }

        public ICollection<Tasks> Tasks { get; set; }


    }
}
