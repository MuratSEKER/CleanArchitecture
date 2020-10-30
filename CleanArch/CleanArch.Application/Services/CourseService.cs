using AutoMapper;
using AutoMapper.QueryableExtensions;
using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Commands;
using CleanArch.Domain.Core.Bus;
using CleanArch.Domain.Interfaces;
using System.Collections.Generic;

namespace CleanArch.Application.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository courseRepository;
        private readonly IMediatorHandler bus;
        private readonly IMapper autoMapper;

        public CourseService(ICourseRepository courseRepository, IMediatorHandler bus, IMapper autoMapper)
        {
            this.courseRepository = courseRepository;
            this.bus = bus;
            this.autoMapper = autoMapper;
        }

        public void Create(CourseViewModel courseViewModel)
        {
            //var createCouserCommand = new CreateCourseCommand(
            //    courseViewModel.Name, courseViewModel.Description, courseViewModel.ImageUrl);

            //bus.SendCommand<CreateCourseCommand>(createCouserCommand);

            bus.SendCommand(autoMapper.Map<CreateCourseCommand>(courseViewModel));
        }

        public IEnumerable<CourseViewModel> GetCourses()
        {
            //return new CourseViewModel()
            //{
            //    Courses = courseRepository.GetCourses()
            //};
            return courseRepository.GetCourses().ProjectTo<CourseViewModel>(autoMapper.ConfigurationProvider);
        }
    }
}
