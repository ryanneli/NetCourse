using API.Application.DTO;
using API.Application.Interfaces;
using API.Domain.Interfaces;
using API.Domain.Entities;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace API.Application.Services
{
    public class GroupService : IGroupService
    {
        private readonly IGroup _group;

        public GroupService(IGroup group)
        {
            _group = group;
        }

        public async Task<GroupGetDto> AddAsync(GroupPutDto group)
        {
            var newGroup = await _group.AddAsync(new Group { Name = group.Name, Description = group.Description });
            if (newGroup == null) return null;

            return new GroupGetDto
            {
                Id = newGroup.Id,
                Name = newGroup.Name,
                Description = newGroup.Description
            };
        }

        public async Task<GroupGetDto> DeleteAsync(int id)
        {
            var deleted = await _group.DeleteAsync(id);
            if (deleted == null) return null;

            return new GroupGetDto
            {
                Id = deleted.Id,
                Name = deleted.Name,
                Description = deleted.Description,
                GroupId = deleted.GroupId,
                CourseId = deleted.CourseId,
            };
        }

        public async Task<GroupGetDto> GetByIdAsync(int id)
        {
            var selectedItem = await _group.GetByIdAsync(id);
            if (selectedItem == null) return null;

            return new GroupGetDto
            {
                Id = selectedItem.Id,
                Name = selectedItem.Name,
                Description = selectedItem.Description
            };
        }

        public async Task<List<GroupGetDto>> GetAllAsync()
        {
            var groups = await _group.GetAllAsync();
            var groupDtos = new List<GroupGetDto>();
            groupDtos.AddRange(groups.Select(g => new GroupGetDto
            {
                Id = g.Id,
                Name = g.Name,
                
                Description = g.Description
            }));
            return groupDtos;
        }

        public async Task<GroupGetDto> UpdateAsync(int id, GroupPutDto group)
        {
            var updatedGroup = await _group.GetByIdAsync(id);
            updatedGroup.Name = group.Name;
            updatedGroup.Description = group.Description;
            updatedGroup.CourseId = group.CourseId;
            updatedGroup.GroupId = group.GroupId;
            updatedGroup = await _group.UpdateAsync(updatedGroup);

            if (updatedGroup == null) return null;

            return new GroupGetDto
            {
                Id = updatedGroup.Id,
                Name = updatedGroup.Name,
                Description = updatedGroup.Description
            };
        }




    }
}