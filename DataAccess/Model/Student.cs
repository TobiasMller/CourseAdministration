using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataAccess.Model
{
    public class Student
    {
        //        [Display(Name = "Enter Age")]
        [Required(ErrorMessage = "You forgot to enter your age")]
        [Range(typeof(int), "1", "120", ErrorMessage = "Value for age must be between {1} and {2}")]
        public int age { get; set; }

        [Required(ErrorMessage = "You forgot to enter your name")]
        [StringLength(120, MinimumLength = 2, ErrorMessage = "Name must be at least 2 characters")]
        public string name { get; set; }

        public int Id { get; set; }

        public List<Course> courses { get; set; }

        public Student(){}


        public Student(string name, int age/*, List<Course> Courses*/)
        {
            this.name = name;
            this.age = age;
            /*this.Courses = new List<Course>(Courses);*/
        }


        public override string ToString()
        {
            return name + " " + age;
        }

    }
}
