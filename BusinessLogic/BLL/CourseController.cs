using DataAccess.Context;
using DataAccess.Model;
using DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace BusinessLogic.BLL
{
    public class CourseController
    {

        public static void CreateCourse(string name, string room)
        {
            Course course = new Course(name, room);
            CourseRepository.AddCourse(course);
        }

        
        public static List<Course> getCourses()
        {
            List<Course> CourseList = new List<Course>();
            foreach (Course course in CourseRepository.getCourses())
            {
                CourseList.Add(course);
            }
            return CourseList;
        }
        

        public static Course getCourse(int id)
        {   
            return CourseRepository.getCourse(id);
        }

        public static void deleteCourse(int id)
        {
            CourseRepository.DeleteCourse(id);
        }

        public static void addStudentToCourse(List<Student> students, Course course)
        {
            CourseRepository.addStudentToCourse(students, course);
        }


        public static void editCourse(Course course)
        {
            CourseRepository.editCourse(course);
        }






        /*public static List<Student> getStudentsAttendingcourse(Student id)
        {
            List<Student> studentList = new List<Student>();
            foreach (Student student in CourseRepository.getStudentsAttendingCourse(id))
            {
                studentList.Add(student);
            }
            return studentList;
        }
        */

    }
}
