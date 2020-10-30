using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using CleanArch.Infra.Data.Context;
using System.Linq;

namespace CleanArch.Infra.Data.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private UniversityDBContext context;

        public CourseRepository(UniversityDBContext context)
        {
            this.context = context;
        }

        public void Add(Course course)
        {
            context.Add(course);
        }

        public IQueryable<Course> GetCourses()
        {
            return context.Courses;
        }
    }
}
