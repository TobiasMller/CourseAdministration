using BusinessLogic.BLL;
using CourseMVC.Models;
using DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CourseMVC.Controllers
{
    public class CourseMVCController : Controller
    {

        public ActionResult GetCourses()
        {
            return View("GetCourses", CourseController.getCourses());
        }

        public ActionResult GetCourseDetail(int id)
        {
            var course = CourseController.getCourse(id);
            var students = StudentController.getStudentsOnACourse(id);
            var model = new CourseDetailViewModel
            {
                Course = course,
                Students = students
            };
            return View(model);
        }


        [HttpPost]
        public ActionResult UpdateCourse(CourseDetailViewModel model)
        {
            Course course = CourseController.getCourse(model.Course.Id);
            if (course != null)
            {
                course.Name = model.Course.Name;
                course.Room = model.Course.Room;

                CourseController.editCourse(course);

                return RedirectToAction("GetCourseDetail", new { id = course.Id });
            }

            return RedirectToAction("GetCourses");
        }
    }
}