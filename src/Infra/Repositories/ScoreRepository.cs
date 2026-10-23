using API.Domain.Entities;
using API.Domain.Interfaces;

namespace API.Infra.Repository
{
    public class ScoreRepository : IScore
    {
        public Task<Score> AddAsync(Score score)
        {
            throw new NotImplementedException();
        }

        public Task<Score> UpdateAsync(Score score)
        {
            throw new NotImplementedException();
        }

        public Task<Score> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Score>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Score> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}