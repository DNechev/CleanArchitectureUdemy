using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.Mvc.Controllers
{
    [Authorize]
    public class CourseContoller : Controller
    {
        private ICourseService _courseService;

        public CourseContoller(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpGet("Course/Courses")]
        public IActionResult Courses()
        {
            return View("Views/Course/Courses.cshtml", _courseService.GetCourses());
        }
    }
}
