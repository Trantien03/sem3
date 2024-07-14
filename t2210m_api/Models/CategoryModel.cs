using System;
using System.ComponentModel.DataAnnotations;
namespace t2210m_api.Models
{
    public class CategoryModel
    {
        public int id { get; set; }
        [Required]
        public string name { get; set; }
    }
}
