using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BusinessLogic.BLL;
using DataAccess.Model;

namespace CourseAPI.Controllers
{
    public class CourseAPIController : ApiController
    {

        

        [HttpGet]
        public List<Course> GetCourses()
        {
            return CourseController.getCourses();
        }



    }
}
