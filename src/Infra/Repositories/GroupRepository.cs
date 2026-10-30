using System.Data.Common;
using API.Domain.Entities;
using API.Domain.Interfaces;
using API.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace API.Infra.Repository
{
    public class GroupRepository : IGroup
    {
        
        public readonly ApplicationDbContext _context;

        public GroupRepository(ApplicationDbContext contexto)
        {
            _context = contexto;
        }

        public async Task<Group> AddAsync(Group group)
        {
            await _context.Group.AddAsync(group);
            await _context.SaveChangesAsync();
            return group;

        }

        public async Task<Group> UpdateAsync(Group group)
        {
            _context.Group.Update(group);
            await _context.SaveChangesAsync();
            return group;
        }

        public async Task<Group> DeleteAsync(int id)
        {
            var grop = await _context.Group.Where(x => x.Excluido == false && x.Id == id).FirstOrDefaultAsync();
            if (grop == null)
            {
                return null;
            }

            grop.Excluido = true;
            _context.Group.Update(grop);
            await _context.SaveChangesAsync();
            return grop;
        }

        public async Task<List<Group>> GetAllAsync()
        {
            return await _context.Group.Where(x => x.Excluido == false).ToListAsync();
        }

        public async Task<Group> GetByIdAsync(int id)
        {
            return await _context.Group.Where(x => x.Excluido == false).FirstOrDefaultAsync();     
        }

    }
}