using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpPost]
        public IActionResult CreateCourse([FromBody] CourseViewModel course)
        {
            _courseService.Create(course);

            return Ok(course);
        }
    }
}
