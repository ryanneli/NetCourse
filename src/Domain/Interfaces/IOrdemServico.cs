using API.Domain.Entities;

namespace API.Domain.Interfaces
{
    public interface IOrdemServico
    {
        Task<OrdemServico> GetByIdAsync(int id);
        Task<OrdemServico> DeleteAsync(int id);

        Task<List<OrdemServico>> GetAllAsync();

        Task<OrdemServico> AddAsync(OrdemServico servico);

        Task<OrdemServico> UpdateAsync(OrdemServico servico);

    }
}