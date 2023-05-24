using DataAccess.Context;
using DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using System.Net;


namespace DataAccess.Repositories
{
    public class StudentRepository
    {
        public static Student getStudent(int id)
        {
            using (Contexts context = new Contexts())
            {
                
                return context.Students.Find(id);
                
            }
        }

        public static List<Student> getStudents()
        {
            using (Contexts context = new Contexts())
            {
                
                return context.Students.Include(t => t.courses).ToList();
            }
        }

        public static void AddStudent(Student student)
        {
            using (Contexts context = new Contexts())
            {
                context.Students.Add(student);
                context.SaveChanges();
            }
        }

        public static List<Student> getStudentsOnACourse(int courseId)
        {
            using (Contexts context = new Contexts())
            {
                // Retrieve the course object with the given ID and its associated students
                var course = context.Courses.Include(c => c.Students).FirstOrDefault(c => c.Id == courseId);

                // Return the list of students associated with the course
                return course?.Students.ToList();
            }
        }

        public static void DeleteStudent(int studentId)
        {
            using (Contexts context = new Contexts())
            {
                Student student = context.Students.Find(studentId);
                context.Students.Remove(student);
                context.SaveChanges();
            }
        }


        public static void EditStudent(Student student)
        {
            using (Contexts context = new Contexts())
            {
                Student existingStudent = context.Students.Find(student.Id);
                if (existingStudent != null)
                {
                    existingStudent.name = student.name;
                    existingStudent.age = student.age;
                    context.SaveChanges();
                }
            }
        }
        
    }
}
