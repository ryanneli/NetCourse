using API.Application.DTO;
using API.Application.Interfaces;
using API.Domain.Interfaces;
using API.Domain.Entities;

namespace API.Application.Services
{
    public class ScoreService : IScoreService
    {
        private readonly IScore _scoreRepository;

        public ScoreService(IScore scoreRepository)
        {
            _scoreRepository = scoreRepository;
        }


        public async Task<ScoreGetDto> DeleteAsync(int id)
        {
            var deletedScore = await _scoreRepository.DeleteAsync(id);
            if (deletedScore == null) return null;

            return new ScoreGetDto
            {
                Id = deletedScore.Id,
                RegistrationId = deletedScore.RegistrationId,
                Value = deletedScore.Value,
                IsAproved = deletedScore.IsAproved,
                Excluido = deletedScore.Excluido
            };
        }

        public async Task<ScoreGetDto> GetByIdAsync(int id)
        {
            var score = await _scoreRepository.GetByIdAsync(id);
            if (score == null) return null;

            return new ScoreGetDto
            {
                Id = score.Id,
                RegistrationId = score.RegistrationId,
                Value = score.Value,
                IsAproved = score.IsAproved,
                Excluido = score.Excluido
            };
        }

        public async Task<List<ScoreGetDto>> GetAllAsync()
        {
            var scores = await _scoreRepository.GetAllAsync();
            return scores.Select(score => new ScoreGetDto
            {
                Id = score.Id,
                RegistrationId = score.RegistrationId,
                Value = score.Value,
                IsAproved = score.IsAproved,
                Excluido = score.Excluido
            }).ToList();
        }

        public async Task<ScoreGetDto> AddAsync(ScorePutDto scoreDto)
        {
            var score = new Score
            {
                RegistrationId = scoreDto.RegistrationId,
                Value = scoreDto.Value,
                IsAproved = scoreDto.Value >= 60,
            };

             var addedScore = await _scoreRepository.AddAsync(score);

            return new ScoreGetDto
            {
                Id = addedScore.Id,
                RegistrationId = addedScore.RegistrationId,
                Value = addedScore.Value,
                IsAproved = addedScore.IsAproved,
            };
        }

        public async Task<ScoreGetDto> UpdateAsync(int id, ScorePutDto scoreDto)
        {
            var existingScore = await _scoreRepository.GetByIdAsync(id);
            if (existingScore == null) return null;

            existingScore.RegistrationId = scoreDto.RegistrationId;
            existingScore.Value = scoreDto.Value;
            existingScore.IsAproved = scoreDto.IsAproved;

            var updatedScore = await _scoreRepository.UpdateAsync(existingScore);

            return new ScoreGetDto
            {
                Id = updatedScore.Id,
                RegistrationId = updatedScore.RegistrationId,
                Value = updatedScore.Value,
                IsAproved = updatedScore.IsAproved,
                Excluido = updatedScore.Excluido
            };
        }
    }
}
    