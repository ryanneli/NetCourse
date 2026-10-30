using API.Application.DTO;

namespace API.Application.Interfaces {
    public interface ICourseService
    {
        Task<CourseGetDto> GetByIdAsync(int id);
        Task<List<CourseGetDto>> GetAllAsync();
        Task<CourseGetDto> AddAsync(CoursePutDto course);
        Task<CourseGetDto> UpdateAsync(int id, CoursePutDto course);
        Task<CourseGetDto> DeleteAsync(int id);
    }
}
