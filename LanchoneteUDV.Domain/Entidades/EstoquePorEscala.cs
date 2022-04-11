using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchoneteUDV.Domain.Entidades
{
    public class EstoquePorEscala
    {
        public string DescricaoProduto { get; set; }
        public double PrecoVenda { get; set; }
        public int QtdVenda { get; set; }
        public int Saida { get; set; }
        public int Estoque { get; set; }

                    //   "SELECT DISTINCT " +
                    //"tbProdutos.Descricao, " +
                    //"tbProdutos.PrecoVenda, " +
                    //"tbEstoqueEscala.QtdVenda, " +
                    //"dbo.ItensVendidos(tbVendasPedido.Produto," + idEscala + ") AS Saida, " +
                    //"(ISNULL(QtdVenda, 0) - ISNULL(dbo.ItensVendidos(tbVendasPedido.Produto," + idEscala + "),0)) AS Estoque " +
                    //"FROM tbProdutos " +
                    //"INNER JOIN tbEstoqueEscala ON tbProdutos.ID = tbEstoqueEscala.Produto " +
                    //"LEFT JOIN tbVendasPedido ON tbProdutos.ID = tbVendasPedido.Produto " +
                    //"WHERE Escala =" + idEscala + " " +
                    //"ORDER BY 1;";
    }
}
