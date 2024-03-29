﻿using LanchoneteUDV.Domain.Validacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchoneteUDV.Domain.Entidades
{
    public class Produto :BaseEntity
    {
        public string Descricao { get; set; }
        public int CategoriaId { get; set; }
        public string Categoria { get; set; }
        public double PrecoCustoCaixa { get; set; }
        public int QtdPorCaixa { get; set; }
        public double PrecoCustoUnitario { get; set; }
        public double PrecoVenda { get; set; }
        public int EstoqueInicial { get; set; }
        public bool ProdutoVenda { get; set; }


        public Produto()
        {

        }
        public Produto(string descricao, int categoria,double precoCustoCaixa,int qtdPorCaixa, double precoCustoUnitario, double precoVenda, int estoqueInicial, bool prevoVenda)
        {
            ValidarDominio(descricao,categoria,  precoCustoCaixa,  qtdPorCaixa,  precoCustoUnitario,  precoVenda,  estoqueInicial,  prevoVenda);
        }

        public Produto(int id, string descricao, int categoria, double precoCustoCaixa, int qtdPorCaixa, double precoCustoUnitario, double precoVenda, int estoqueInicial, bool produtoVenda)
        {
            DomainExceptionValidation.When(id < 0, "Necessário informar um ID");
            Id = id;
            ValidarDominio(descricao, categoria, precoCustoCaixa, qtdPorCaixa, precoCustoUnitario, precoVenda, estoqueInicial, produtoVenda);
        }

        public void Update(string descricao, int categoria, double precoCustoCaixa, int qtdPorCaixa, double precoCustoUnitario, double precoVenda, int estoqueInicial, bool produtoVenda)
        {
            ValidarDominio(descricao, categoria, precoCustoCaixa, qtdPorCaixa, precoCustoUnitario, precoVenda, estoqueInicial, produtoVenda);
        }

        private void ValidarDominio(string descricao, int categoria, double precoCustoCaixa, int qtdPorCaixa, double precoCustoUnitario, double precoVenda, int estoqueInicial, bool produtoVenda)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(descricao),
                "É necessário informar um produto");
            DomainExceptionValidation.When(descricao.Trim().Length < 3,
                "Produto muito curta para o cadastro");

            Descricao = descricao;
            CategoriaId = categoria;
            PrecoCustoCaixa = precoCustoCaixa;
            QtdPorCaixa = qtdPorCaixa;
            PrecoCustoUnitario = precoCustoUnitario;
            PrecoVenda = precoVenda;
            EstoqueInicial = estoqueInicial;
            ProdutoVenda = produtoVenda;

        }
    }
}
