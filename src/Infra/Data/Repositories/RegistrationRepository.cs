using System.Data.Common;
using API.Domain.Entities;
using API.Domain.Interfaces;

namespace API.Infra.Repository
{
    public class RegistrationRepository : IRegistration
    {
        public Task<Registration> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Registration> AddAsync(Registration registration)
        {
            throw new NotImplementedException();
        }

        public Task<Registration> UpdateAsync(Registration registration)
        {
            throw new NotImplementedException();
        }

        public Task<Registration> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Registration>> GetAllAsync()
        {
            throw new NotImplementedException();
        }
    }

}
