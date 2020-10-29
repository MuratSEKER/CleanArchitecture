using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using CleanArch.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

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

        public IEnumerable<Course> GetCourses()
        {
            return context.Courses;
        }
    }
}
