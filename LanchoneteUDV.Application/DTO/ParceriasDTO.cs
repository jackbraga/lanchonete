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

        public string StringTipoComissao { get; set; }
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

        public int Estoque { get; set; }
    }

    public class VendasParceriaEscalaDTO
    {
        public DateTime DataEscala { get; set; }

        public string DescricaoEscala { get; set; }
        public int TipoComissao { get; set; }
        public string StringTipoComissao { get; set; }
        public double Comissao { get; set; }

        public int QtdVendidos { get; set; }
        public double Total { get; set; }

        public double TotalComissao { get; set; }

        public int IDParceria { get; set; }
        public int IDEscala { get; set; }
        public double ValorRepasse
        {
            get
            {
                return Total - TotalComissao;
            }
        }
        public bool RepasseFeito { get; set; }

  

    }

    public class VendasParceriaProdutoDTO
    {
        public DateTime DataEscala { get; set; }
        public string DescricaoEscala { get; set; }
        public string NomeSocio { get; set; }
        public string DescricaoProduto { get; set; }
        public int Quantidade { get; set; }
        public double PrecoProduto { get; set; }
        public bool Retirado { get; set; }

        public int IdRetirado { get; set; }

    }
}
