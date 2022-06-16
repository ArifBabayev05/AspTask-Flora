﻿using System;
namespace DAL.Models
{
	public class Product
	{
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Tag { get; set; }
        public string ImageUrl { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime UpdatedTime { get; set; }
        public int Count { get; set; }
        public bool IsDeleted { get; set; }
    }
}

