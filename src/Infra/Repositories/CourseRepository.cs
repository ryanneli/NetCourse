using API.Domain.Entities;
using API.Domain.Interfaces;
using API.Infra.Data.Context;

namespace API.Infra.Repository
{
    public class CourseRepository : ICourse
    {

        private readonly ApplicationDbContext _context;

        public CourseRepository(ApplicationDbContext context) {
            _context = context;
        }




        public Task<Course> AddAsync(Course course)
        {
            _context.Course.Add(course);
            _context.SaveChanges();
            return Task.FromResult(course);
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
