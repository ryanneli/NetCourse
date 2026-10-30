using System;
using System.Collections.Generic;
using System.Text;
using API.Domain.Entities;

namespace API.Domain.Interfaces
{
    public interface ICourse
    {
        Task<Course> GetByIdAsync(int id);
        Task<List<Course>> GetAllAsync();
        Task<Course> AddAsync(Course course);
        Task<Course> UpdateAsync(Course course);
        Task<Course> DeleteAsync(int id);
    }
}