using System.Data.Common;
using API.Domain.Entities;
using API.Domain.Interfaces;
using API.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace API.Infra.Repository
{
    public class ScoreRepository : IScore
    {
        private readonly ApplicationDbContext _context;

        public ScoreRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Score> AddAsync(Score score)
        {
            await _context.Score.AddAsync(score);
            await _context.SaveChangesAsync();
            return score;
        }

        public async Task<Score> UpdateAsync(Score score)
        {
            _context.Score.Update(score);
            await _context.SaveChangesAsync();
            return score;
        }

        public async Task<Score> DeleteAsync(int id)
        {
            var score = await _context.Score.Where(x => x.Excluido == false && x.Id == id).FirstOrDefaultAsync();
            
            if (score == null)
            {
                return null;
            }

            _context.Score.Remove(score);
            await _context.SaveChangesAsync();
            return score;
        }

        public async Task<List<Score>> GetAllAsync()
        {
            return await _context.Score.Where(x => x.Excluido == false).ToListAsync();
        }

        public async Task<Score> GetByIdAsync(int id)
        {
            return await _context.Score.Where(x => x.Excluido == false && x.Id == id).FirstOrDefaultAsync();
        }
    }
}