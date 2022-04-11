using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchoneteUDV.Application.DTO
{
    public class VendasPedidoEscalaDTO
    {
        public int Id { get; set; }
        public DateTime DataHoraPedido { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public bool Retirado { get; set; }
        public string Observacao { get; set; }
    }
}
