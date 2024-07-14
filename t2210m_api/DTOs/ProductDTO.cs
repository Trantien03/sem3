using System;
namespace t2210m_api.DTOs
{
    public class ProductDTO
    {
        public int id { get; set; }

        public string name { get; set; } = null!;

        public decimal price { get; set; }

        public string? description { get; set; }

        public string? thumbnail { get; set; }

        public int qty { get; set; }

        public int category_id { get; set; }

        public virtual CategoryDTO category { get; set; }
    }
}
