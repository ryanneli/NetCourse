using System.Security.Cryptography.X509Certificates;
using API.Domain.Entities;
using API.Domain.Interfaces;
using API.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace API.Infra.Repository
{
    public class UserRepository : IUser
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<User> GetByIdAsync(int id)
        {
            // Passamos a condição diretamente para dentro do FirstOrDefaultAsync
            return await _context.User.FirstOrDefaultAsync(x => x.Excluido == false && x.Id == id);
        }

        public async Task<User> AddAsync(User user)
        {
            await _context.User.AddAsync(user);
            _context.SaveChangesAsync();
            return user;
        }

        public async Task<User> UpdateAsync(User user)
        {
            _context.User.AddAsync(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task<User> DeleteAsync(int id)
        {
            var user = await _context.User.FirstOrDefaultAsync(x => x.Excluido == false && x.Id == id);
            if (user == null)
            {
                return null;
            }

            user.Excluido = true;
            _context.User.Update(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task<List<User>> GetAllAsync()
        {
            return await _context.User.Where(x => x.Excluido == false).ToListAsync();
        }
    }
}