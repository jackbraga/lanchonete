using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchoneteUDV.Domain.Entidades
{
    public class VendasPedidoSocio
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public double PrecoProduto { get; set; }
        public int Quantidade { get; set; }
        public double Total { get; set; }
        public string Observacao { get; set; }
        public bool Retirado { get; set; }
        public DateTime DataHoraPedido { get; set; }
    }
}
