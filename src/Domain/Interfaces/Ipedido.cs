using API.Domain.Entities;

namespace API.Domain.Interfaces
{
    public interface Ipedido
    {
        Task<Pedido> GetByIdAsync(int id);
        Task<Pedido> DeleteAsync(int id);

        Task<List<Pedido>> GetAllAsync();

        Task<Pedido> AddAsync(Pedido servico);

        Task<Pedido> UpdateAsync(Pedido servico);

    }
}