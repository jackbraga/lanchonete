using LanchoneteUDV.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchoneteUDV.Application.DTO
{
    public class ParceriasDTO
    {

        public int ID { get; set; }
        public string Descricao { get; set; }
        public string Responsavel { get; set; }
        public string StringTipoComissao
        {
            get
            {
                if (this.TipoComissao == 1)
                {
                    return "R$ por venda";
                }
                else
                {
                    return "% por venda";
                }

            }
        }

        public int TipoComissao { get; set; }
        public double Comissao { get; set; }

    }

    public class ParceriasProdutoDTO
    {
        public int ID { get; set; }
        public int IDParceria { get; set; }
        public string DescricaoParceria { get; set; }
        public int IDProduto { get; set; }
        public string DescricaoProduto { get; set; }

        public double PrecoVenda { get; set; }
        public bool ProdutoAtivo { get; set; }
    }
}
