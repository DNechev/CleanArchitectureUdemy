using CleanArchitecture.Domain.Entities;
using System.Linq;

namespace CleanArchitecture.Domain.Interfaces
{
    public interface ICourseRepository
    {
        IQueryable<Course> GetCourses();

        void AddCourse(Course course);
    }
}
