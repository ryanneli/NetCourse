using System.Data.Common;
using API.Domain.Entities;
using API.Domain.Interfaces;
using API.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace API.Infra.Repository
{
    public class RegistrationRepository : IRegistration
    {
        private readonly ApplicationDbContext _context;

        public RegistrationRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Registration> GetByIdAsync(int id)
        {
            return await _context.Registration.Where(x => x.Excluido == false && x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<Registration> AddAsync(Registration registration)
        {
            await _context.Registration.AddAsync(registration);
            await _context.SaveChangesAsync();
            return registration;
        }


        public async Task<Registration> UpdateAsync(Registration registration)
        {
            _context.Registration.Update(registration);
            await _context.SaveChangesAsync();
            return registration;

        }

        public async Task<Registration> DeleteAsync(int id)
        {
            var registration = await _context.Registration.Where(x => x.Excluido == false && x.Id == id).FirstOrDefaultAsync();
            if (registration == null)
            {
                return null;
            }

            registration.Excluido = true;
            _context.Registration.Update(registration);
            await _context.SaveChangesAsync();
            return registration;
        }
        public async Task<List<Registration>> GetAllAsync()
        {
            return await _context.Registration.Where(x => x.Excluido == false).ToListAsync();
        }
    }

}          
 