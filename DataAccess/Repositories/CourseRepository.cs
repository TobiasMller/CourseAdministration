using DataAccess.Context;
using DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class CourseRepository
    {
        public static Course getCourse(int id)
        {
            using (Contexts context = new Contexts())
            {
                //Maybe throw exception if not found

                return context.Courses.Find(id);
            }
        }
        public static void AddCourse(Course course)
        {
            using (Contexts context = new Contexts())
            {
                context.Courses.Add(course);
                context.SaveChanges();
            }
        }
        

        public static List<Course> getCourses()
        {
            using (Contexts context = new Contexts())
            {

                return context.Courses.Include(p => p.Students).ToList();
            } 
        }

       


        public static void DeleteCourse(int id)
        {
                using (Contexts context = new Contexts())
            {
                var selectedCourse = context.Courses.Find(id);
                context.Courses.Remove(selectedCourse);
                context.SaveChanges();
            }
        }

        public static void addStudentToCourse(List<Student> students, Course course)
        {
            using (Contexts context = new Contexts())
            {
                Course foundCourse = course;
                context.Courses.Add(foundCourse);

                foreach (Student student in students)
                {
                    Student foundStudent = context.Students.Find(student.Id);
                    foundCourse.Students.Add(foundStudent);
                    

                }
           
                context.SaveChanges();
            }
        
    }


        public static void editCourse(Course course)
        {
            using (Contexts context = new Contexts())
            {
                Course theCourse = context.Courses.Find(course.Id);
                if (theCourse != null)
                {
                    theCourse.Name = course.Name;
                    theCourse.Room = course.Room;
                    context.SaveChanges();
                }
            }
        }

    }
}
