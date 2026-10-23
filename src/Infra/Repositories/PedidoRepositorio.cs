using API.Domain.Entities;
using API.Domain.Interfaces;

namespace API.Infra.Repository
{
    public class PedidoRepositorio : Ipedido 
    {
        public Task<Pedido> AddAsync(Pedido ordem)
        {
            throw new NotImplementedException();
        }

        public Task<Pedido> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Pedido>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Pedido> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Pedido> UpdateAsync(Pedido ordem)
        {
            throw new NotImplementedException();
        }

    }

}