using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DTO.Model
{
    public class Student
    {
        // public List<Course> courses { get; set; }
        public int age { get; set; }

        public string name { get; set; }

        public int Id { get; set; }

        public List<Course> courses { get; set; }

        public Student() { }


        public Student(string name, int age/*, List<Course> Courses*/)
        {
            this.name = name;
            this.age = age;
            /*this.Courses = new List<Course>(Courses);*/
        }


    }
}
