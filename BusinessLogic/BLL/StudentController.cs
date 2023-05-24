using DataAccess.Model;

using DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.BLL
{
    public class StudentController
    {

        public static void createStudent(String name, int age/*, List<Course> courses*/)
        {
            Student student = new Student(name, age);
            StudentRepository.AddStudent(student);
        }
        

        public static Student getStudent(int id)
        {
            return StudentRepository.getStudent(id);
        }

        
        public static List<Student> getStudents()
        {
        List<Student> StudentList = new List<Student>();
            foreach (Student student in StudentRepository.getStudents())
            {
                   StudentList.Add(student);
            }
            return StudentList;
            }


        public static List<Student> getStudentsOnACourse(int id)
        {
            List<Student> StudentList = new List<Student>();
            foreach (Student student in StudentRepository.getStudentsOnACourse(id))
            {
                StudentList.Add(student);
            }
            return StudentList;
        }



        public static void deleteStudent(int id)
        {
            StudentRepository.DeleteStudent(id);
        }

        public static void editStudent(Student student)
        {
            StudentRepository.EditStudent(student);
        }
    }
}
