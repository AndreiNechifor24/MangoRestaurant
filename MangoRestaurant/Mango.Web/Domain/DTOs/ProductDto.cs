using System;

namespace Mango.Web.Domain.DTOs
{
    public class ProductDto
    {
        public Guid ProductId { get; set; }

        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string Category { get; set; }
    }
}
