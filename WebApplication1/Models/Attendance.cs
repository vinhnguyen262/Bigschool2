using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Attendance
    {
        public Course course { get; set; }
        [key]
        [Column (Ordere =1)]
        public int CourseID { get; set; }
        public ApplicationUser Attendee { get; set; }

        [key]
        [Column(Order = 2)]
        public string AttendeeId { get; set; }
    }
}