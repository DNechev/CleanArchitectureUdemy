using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Infrastructure.Data.Context;
using System.Collections.Generic;

namespace CleanArchitecture.Infrastructure.Data.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private CleanArchDbContext _context;

        public CourseRepository(CleanArchDbContext cleanArchDbContext)
        {
            this._context = cleanArchDbContext;
        }

        public void AddCourse(Course course)
        {
            _context.Courses.Add(course);
            _context.SaveChanges();
        }

        public IEnumerable<Course> GetCourses()
        {
            return _context.Courses;
        }
    }
}
