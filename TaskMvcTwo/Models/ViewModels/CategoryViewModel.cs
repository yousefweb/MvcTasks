using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TaskMvcTwo.Models.ViewModels
{
    public class CategoryViewModel
    {
        [Required(ErrorMessage = "ادخل الفئة")]
        [MinLength(3, ErrorMessage = "Min 3 char")]
        [MaxLength(12, ErrorMessage = "Max 12 char")]
        public string CategoryName { get; set; }

        [Display(Name = "صورة الفئة")]
        [DataType(DataType.ImageUrl)]
        public IFormFile Image { get; set;}
    }
}
