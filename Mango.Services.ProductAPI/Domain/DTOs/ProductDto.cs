﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Mango.Services.ProductAPI.Domain.Models;

namespace Mango.Services.ProductAPI.Domain.DTOs
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
