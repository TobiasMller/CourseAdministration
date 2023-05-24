using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Model
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Room { get; set; }

        public List<Student> Students { get; set; }



        public Course(string name, string room)
        {
            Name = name;
            Room = room;
            Students = new List<Student>();
        }
        public Course(){}

    }
}
