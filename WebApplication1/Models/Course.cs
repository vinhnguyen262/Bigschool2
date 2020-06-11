﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Course
    {
        public int Id { get; set; }

        public ApplicationUser Lecturer { get; set; }
        [Required]
        public string LecturerID { get; set; }
        [Required]
        [StringLength(255)]
        public string place { get; set; }

        public DateTime Datetime { get; set; }
        public Category Category { set; get; }
        [Required]
        public byte CategoryId { get; set; }

    }

}