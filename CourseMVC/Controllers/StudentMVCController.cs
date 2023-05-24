using BusinessLogic.BLL;
using CourseMVC.Models;
using DataAccess.Model;
using DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CourseMVC.Controllers
{
    public class StudentMVCController : Controller
    {
        // GET: StudentMVC
        public ActionResult GetStudents()
        {
                return View(StudentController.getStudents());
            
        }


        public ActionResult CreateStudentView()
        {
            //StudentController.createStudent(name, age);
            return View("CreateStudentView");

        }

        [HttpGet]
        public ActionResult EditStudentView(int id)
        {
            return View(StudentController.getStudent(id));
        }


        [HttpPost]
        public ActionResult EditStudentView(Student student)
        {
            StudentController.editStudent(student);
            return RedirectToAction("GetStudents");
        }

        [HttpGet]
        public ActionResult DeleteStudentView(int id)
        {
            return View(StudentController.getStudent(id));
        }

        [HttpPost]
        public ActionResult DeleteStudentView(Student student)
        {
            StudentController.deleteStudent(student.Id);
            return RedirectToAction("GetStudents");
        }

        [HttpPost]
        public ActionResult CreateStudent(int age, string name)
        {
            if (age != 0 || name != null)
            {
                StudentController.createStudent(name, age);
                return RedirectToAction("GetStudents");
            }
            return RedirectToAction("CreateStudentView");
        }

     }
}