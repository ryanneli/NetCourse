using API.Application.DTO;
namespace API.Application.Interfaces
{
 public interface IUserService
    {
        Task<UserGetDto> GetByIdAsync(int id);
        Task<List<UserGetDto>> GetAllAsync();
        Task<UserGetDto> AddAsync(UserPutDto user);
        Task<UserGetDto> UpdateAsync(int id, UserPutDto user);
        Task<UserGetDto> DeleteAsync(int id);
    }
}