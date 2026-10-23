using API.Domain.Entities;
using API.Domain.Interfaces;

namespace API.Infra.Repository
{
    public class GroupRepository : IGroup
    {
        public Task<Group> AddAsync(Group group)
        {
            throw new NotImplementedException();
        }

        public Task<Group> UpdateAsync(Group group)
        {
            throw new NotFiniteNumberException();
        }

        public Task<Group> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Group>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Group> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

    }
}