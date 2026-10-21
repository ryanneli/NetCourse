using API.Domain.Entities;
namespace API.Domain.Interfaces
{
    public interface IRegistration
    {
        Task<Registration> GetByIdAsync(int id);
        Task<List<Registration>> GetAllAsync();
        Task<Registration> AddAsync(Registration registration);
        Task<Registration> UpdateAsync(Registration registration);
        Task<Registration> DeleteAsync(int id);
    }
}
