using API.Domain.Entities;

namespace API.Domain.Interfaces
{
    public interface IGroup
    {
        Task<Group> GetByIdAsync(int id);
        Task<List<Group>> GetAllAsync();
        Task<Group> AddAsync(Group group);
        Task<Group> UpdateAsync(Group group);
        Task<Group> DeleteAsync(int id);
    }
}