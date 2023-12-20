using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TaskMvcTwo.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        [Display(Name = "أسم المنتج")]
        [Required(ErrorMessage = "أدخل أسم المنتج")]
        public string Name { get; set; }

        [Display(Name = "وصف المنتج")]
        [Required(ErrorMessage = "أدخل وصف المنتج")]
        public string ProductDesc { get; set; }

        [DataType(DataType.Currency)]
        [Required(ErrorMessage = "أدخل سعر القطعة")]
        public decimal? Price { get; set; }

        [Required(ErrorMessage = "أدخل عدد القطع")]
        public int? Qty { get; set; }

        [Display(Name="أدخل صورة المنتج")]
        [DataType(DataType.ImageUrl)]
        public string ImageProduct { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}
