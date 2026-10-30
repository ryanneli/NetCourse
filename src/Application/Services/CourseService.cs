using API.Application.DTO;
using API.Application.Interfaces;
using API.Domain.Interfaces;
using API.Domain.Entities;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace API.Application.Services{
    public class CourseService : ICourseService
    {
        private readonly ICourse _courseRepository;

        public CourseService(ICourse courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public async Task<CourseGetDto> AddAsync(CoursePutDto course)
        {
            var newCourse = new Course
            {
                Name = course.Name,
                Description = course.Description
            };

            var addedCourse = await _courseRepository.AddAsync(newCourse);

            return new CourseGetDto
            {
                Id = addedCourse.Id,
                Name = addedCourse.Name,
                Description = addedCourse.Description
            };
        }

        public async Task<CourseGetDto> DeleteAsync(int id)
        {
            var deletedCourse = await _courseRepository.DeleteAsync(id);
            
            if (deletedCourse == null)
                return null;

            return new CourseGetDto
            {
                Id = deletedCourse.Id,
                Name = deletedCourse.Name,
                Description = deletedCourse.Description
            };

        }

        public async Task<List<CourseGetDto>> GetAllAsync()
        {
            var courses = await _courseRepository.GetAllAsync();
            var courseList = new List<CourseGetDto>();

            foreach (var x in courses)
            {
                courseList.Add(new CourseGetDto { Id = x.Id, Name = x.Name, Description = x.Description });
            }

            return courseList;
        }

        public async Task<CourseGetDto> GetByIdAsync(int id)
        {
            var course = await _courseRepository.GetByIdAsync(id);
            if (course == null)
                return null;

            return new CourseGetDto
            {
                Id = course.Id,
                Name = course.Name,
                Description = course.Description,
            };
        }

        public async Task<CourseGetDto> UpdateAsync(int id, CoursePutDto courseDto)
        {
            var existingItem = await _courseRepository.GetByIdAsync(id);
            if (existingItem == null)
                return null;

            existingItem.Name = courseDto.Name;
            existingItem.Description = courseDto.Description;

            await _courseRepository.AddAsync(existingItem);

            return new CourseGetDto
            {
                Id = existingItem.Id,
                Name = existingItem.Name,
                Description = existingItem.Description,
            };
        }

    }
}