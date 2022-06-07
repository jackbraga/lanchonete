using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchoneteUDV.Application.DTO
{
    public class VendasPedidoDTO
    {
        public int Id { get; set; }
        public int IdVenda { get; set; }
        public int IdProduto { get; set; }
        public int Quantidade { get; set; }
        public double PrecoProduto { get; set; }
        public string Observacao { get; set; }
        public bool Retirado { get; set; }
        public DateTime DataHoraPedido { get; set; }

        public string TipoPagamento  { get; set; }
    }
}
