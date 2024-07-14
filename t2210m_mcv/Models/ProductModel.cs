using System;
using System.ComponentModel.DataAnnotations;

namespace t2210m.Models
{
    public class ProductModel
    {
        public int Id { get; set; } // abstract property

        [Required(ErrorMessage = "Vui lòng nhập tên")]
        public String NameProduct { get; set; }
        public String Describe { get; set; }
        public String Price { get; set; }
        public String Quantity { get; set; }

    }
}
