using API.Application.DTO;

namespace API.Application.Interfaces
{
    public interface IGroupService
    {
        Task<GroupGetDto> GetByIdAsync(int id);
        Task<List<GroupGetDto>> GetAllAsync();
        Task<GroupGetDto> AddAsync(GroupPutDto group);
        Task<GroupGetDto> UpdateAsync(int id, GroupPutDto group);
        Task<GroupGetDto> DeleteAsync(int id);
    }
}