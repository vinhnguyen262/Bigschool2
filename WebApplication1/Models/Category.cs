﻿using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Category
    {
        public byte Id { get; set; }
        [Required]
        [StringLength (255)]
        public string name { get; set; }
    }
}