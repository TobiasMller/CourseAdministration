using DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CourseMVC.Models
{
    public class CourseDetailViewModel
    {
        public Course Course { get; set; }
        public List<Student> Students { get; set; }
        public Student student { get; set; }

    }
}