using API.Domain.Entities;
using API.Domain.Interfaces;

namespace API.Infra.Repository
{
    public class CourseRepository : ICourse
    {
        public Task<Course> AddAsync(Course course)
        {
            throw new NotImplementedException();
        }

        public Task<Course> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Course>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Course> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Course> UpdateAsync(Course course)
        {
            throw new NotImplementedException();
        }
    }
}
