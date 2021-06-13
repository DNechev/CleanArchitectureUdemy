using AutoMapper;
using AutoMapper.QueryableExtensions;
using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.ViewModels;
using CleanArchitecture.Domain.Core.Bus;
using CleanArchitecture.Domain.Core.Commands;
using CleanArchitecture.Domain.Interfaces;
using System.Collections.Generic;

namespace CleanArchitecture.Application.Services
{
    public class CourseService : ICourseService
    {
        private readonly IMapper _mapper;
        private readonly ICourseRepository _courseRepository;
        private readonly IMediatorHandler _bus;

        public CourseService(ICourseRepository courseRepository, IMediatorHandler bus, IMapper mapper)
        {
            _courseRepository = courseRepository;
            _bus = bus;
            _mapper = mapper;
        }

        public void Create(CourseViewModel course)
        {
            var command = _mapper.Map<CourseCommand>(course);

            _bus.SendCommand(command);
        }

        public IEnumerable<CourseViewModel> GetCourses()
        {
            return _courseRepository.GetCourses().ProjectTo<CourseViewModel>(_mapper.ConfigurationProvider);
        }
    }
}
