using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TaskMvcTwo.Models
{
    public class Category
    {
        [Display(Name ="الفئة")]
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "ادخل الفئة")]
        [Display(Name = "الفئة")]
        [MinLength(3, ErrorMessage = "Min 3 char")]
        [MaxLength(12, ErrorMessage = "Max 12 char")]

        public string CategoryName { get; set; }
        [Display(Name = "صورة الفئة")]
        [DataType(DataType.ImageUrl)]
        public string Image { get; set; }
    }
}
