using API.Domain.Entities;
using API.Domain.Interfaces;
using API.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

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

        public async Task<Course> DeleteAsync(int id)
        {
            var course = await _context.Course.Where(x => x.Excluido == false && x.Id == id).FirstOrDefaultAsync();
            if (course == null)
            {
                return null;
            }
            /* 
            _context.Course.Remove(course);
            await _context.SaveChangesAsync();
            return course;
            */

            //softdelete 
            course.Excluido = true;
            _context.Course.Update(course);
            _context.SaveChangesAsync();
            return course;
            }

        public async Task<List<Course>> GetAllAsync()
        {

            return await _context.Course.Where(x => x.Excluido == false).ToListAsync();
        }

        public async Task<Course> GetByIdAsync(int id)
        {
            return await _context.Course.Where(x => x.Excluido == false && x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<Course> UpdateAsync(Course course)
        {
            _context.Course.Update(course);

            await _context.SaveChangesAsync();

            return course;

        }
    }
}
