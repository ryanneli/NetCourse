using API.Domain.Entities;
namespace API.Domain.Interfaces
{
    public interface IUser
    {
        Task<User> GetByIdAsync(int id);
        Task<List<User>> GetAllAsync();

        Task<User> AddAsync(User user);

        Task<User> UpdateAsync(User user);

        Task<User> DeleteAsync(int id);
        
    }

}