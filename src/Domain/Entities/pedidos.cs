namespace API.Domain.Entities
{
    public class Pedido
    {
        public int Id { get; set; }
        public int OsId { get; set; }
        public DateTime DataCriação { get; set; }
        public string Description { get; set; }
        public OrdemServico OrdemServico { get; set; }

    }
}