using API.Domain.Entities;
using API.Domain.Interfaces;

namespace API.Infra.Repository
{
    public class OrdemServicoRepositorio : IOrdemServico
    {
        public Task<OrdemServico> AddAsync(OrdemServico ordem)
        {
            throw new NotImplementedException();
        }

        public Task<OrdemServico> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<OrdemServico>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<OrdemServico> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<OrdemServico> UpdateAsync(OrdemServico ordem)
        {
            throw new NotImplementedException();
        }

    }

}