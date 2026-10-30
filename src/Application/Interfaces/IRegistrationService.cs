using API.Application.DTO;
namespace API.Application.Interfaces
{
    public interface IRegistrationService
    {
        Task<RegistrationGetDto> GetByIdAsync(int id);
        Task<List<RegistrationGetDto>> GetAllAsync();
        Task<RegistrationGetDto> AddAsync(RegistrationPutDto registro);
        Task<RegistrationGetDto> UpdateAsync(int id,RegistrationPutDto registro);
        Task<RegistrationGetDto> DeleteAsync(int id);
    }
}