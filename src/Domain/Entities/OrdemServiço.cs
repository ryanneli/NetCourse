

namespace API.Domain.Entities
{
    public class OrdemServico
    {
        public int Id { get; set; }
        public int Os { get; set; }
        public string Cliente { get; set; }

        public ICollection<Pedido> Pedidos { get; set; }

    }
}