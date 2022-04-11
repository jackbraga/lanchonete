namespace LanchoneteUDV.Application.DTO
{
    public class EstoqueEscalaDTO
    {
        public int Id { get; set; }
        public int IdEscala { get; set; }
        public int IdProduto { get; set; }
        public string DescricaoProduto { get; set; }
        public int QtdVenda { get; set; }
        public string Observacao { get; set; }
    }
}
