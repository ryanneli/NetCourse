using API.Domain.Entities;
namespace API.Domain.Interfaces
{
    public interface IScore
    {
        Task<Score> GetByIdAsync(int id);
        Task<List<Score>> GetAllAsync();
        Task<Score> AddAsync(Score score);
        Task<Score> UpdateAsync(Score score);
        Task<Score> DeleteAsync(int id);
    }
}