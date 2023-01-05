﻿using Microsoft.Extensions.Hosting;

namespace ShowRooms.Models
{
    public class Category
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public List<Car>? Cars { get; set; }
    }
}
