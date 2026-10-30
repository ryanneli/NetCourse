using API.Application.DTO;
namespace API.Application.Interfaces
{
    public interface IScoreService
    {
        Task<ScoreGetDto> GetByIdAsync(int id);
        Task<List<ScoreGetDto>> GetAllAsync();
        Task<ScoreGetDto> AddAsync(ScorePutDto score);
        Task<ScoreGetDto> UpdateAsync(int id, ScorePutDto score);
        Task<ScoreGetDto> DeleteAsync(int id);
    }
}