using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchoneteUDV.Domain.Entidades
{
    public class Parcerias : BaseEntity
    {
        public string Descricao { get; set; }
        public string Responsavel { get; set; }
        public int TipoComissao { get; set; }
        public double Comissao { get; set; }
    }

    public class ParceriasProduto: BaseEntity
    {
        public int IDParceria { get; set; }
        public string DescricaoParceria { get; set; }
        public int IDProduto { get; set; }
        public string DescricaoProduto { get; set; }

        public double PrecoVenda { get; set; }
        public bool ProdutoAtivo { get; set; }
    }
}
