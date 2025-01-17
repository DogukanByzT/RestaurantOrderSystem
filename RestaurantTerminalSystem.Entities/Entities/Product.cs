﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantTerminalSystem.Entities.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public byte[]? Image { get; set; }

        public int CategoryId { get; set; }
        public Category? Category { get; set; }

        public int TableId { get; set; }

        public override string ToString()
        {
            return $"{Name} {Price} | {Category.Name}";
        }

    }
}
