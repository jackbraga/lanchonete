using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchoneteUDV.Domain.Entidades
{
    public class Compra : BaseEntity
    {
        public DateTime DataCompra { get; set; }

        public int IdProduto { get; set; }
        public string DescricaoProduto { get; set; }
        public int Quantidade { get; set; }
        public double PrecoUnitario { get; set; }
        public string CompradoPor { get; set; }
  
        public string TipoEntrada { get; set; }
        public string Observacao { get; set; }

        public Compra()
        {

        }
        //public Compra(string descricao, int categoria, double precoCustoCaixa, int qtdPorCaixa, double precoCustoUnitario, double precoVenda, int estoqueInicial, bool prevoVenda)
        //{
        //    ValidarDominio(descricao, categoria, precoCustoCaixa, qtdPorCaixa, precoCustoUnitario, precoVenda, estoqueInicial, prevoVenda);
        //}

        //public Compra(int id, string descricao, int categoria, double precoCustoCaixa, int qtdPorCaixa, double precoCustoUnitario, double precoVenda, int estoqueInicial, bool produtoVenda)
        //{
        //    DomainExceptionValidation.When(id < 0, "Necessário informar um ID");
        //    Id = id;
        //    ValidarDominio(descricao, categoria, precoCustoCaixa, qtdPorCaixa, precoCustoUnitario, precoVenda, estoqueInicial, produtoVenda);
        //}

        //public void Update(string descricao, int categoria, double precoCustoCaixa, int qtdPorCaixa, double precoCustoUnitario, double precoVenda, int estoqueInicial, bool produtoVenda)
        //{
        //    ValidarDominio(descricao, categoria, precoCustoCaixa, qtdPorCaixa, precoCustoUnitario, precoVenda, estoqueInicial, produtoVenda);
        //}

        //private void ValidarDominio(string descricao, int categoria, double precoCustoCaixa, int qtdPorCaixa, double precoCustoUnitario, double precoVenda, int estoqueInicial, bool produtoVenda)
        //{
        //    DomainExceptionValidation.When(string.IsNullOrEmpty(descricao),
        //        "É necessário informar um produto");
        //    DomainExceptionValidation.When(descricao.Trim().Length < 3,
        //        "Produto muito curta para o cadastro");

        //    Descricao = descricao;
        //    CategoriaId = categoria;
        //    PrecoCustoCaixa = precoCustoCaixa;
        //    QtdPorCaixa = qtdPorCaixa;
        //    PrecoCustoUnitario = precoCustoUnitario;
        //    PrecoVenda = precoVenda;
        //    EstoqueInicial = estoqueInicial;
        //    ProdutoVenda = produtoVenda;

        //}
    }
}
