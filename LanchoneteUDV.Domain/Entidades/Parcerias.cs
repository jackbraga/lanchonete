using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LanchoneteUDV.Domain.Entidades
{
    public class Parcerias : BaseEntity
    {
        public string Descricao { get; set; }
        public string Responsavel { get; set; }
        public int TipoComissao { get; set; }
        public double Comissao { get; set; }

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


    }

    public class ParceriasProduto : BaseEntity
    {
        public int IDParceria { get; set; }
        public string DescricaoParceria { get; set; }
        public int IDProduto { get; set; }
        public string DescricaoProduto { get; set; }

        public double PrecoVenda { get; set; }
        public bool ProdutoAtivo { get; set; }
    }

    public class VendasParceriaEscala
    {
        public DateTime DataEscala { get; set; }

        public string DescricaoEscala { get; set; }


        public int TipoComissao { get; set; }
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
        public double Comissao { get; set; }
        public int QtdVendidos { get; set; }
        public double Total { get; set; }

        public double TotalComissao
        {
            get
            {
                if (this.TipoComissao==1)
                {
                    return Comissao * QtdVendidos;
                }
                else
                {
                    return (Comissao / 100) * Total;
                }
               
            }
        }

        public int IDParceria { get; set; }
        public int IDEscala { get; set; }
        public bool RepasseFeito { get; set; }


    }

    public class VendasParceriaProduto
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
