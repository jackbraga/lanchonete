using LanchoneteUDV.Domain.Validacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchoneteUDV.Domain.Entidades
{
    public sealed class Escala : BaseEntity
    {

        public DateTime DataEscala { get; private set; }
        public string Descricao { get; private set; }
        public string TipoSessao { get; private set; }
        public string Observacao { get; private set; }
        public bool Finalizada { get; private set; }
        public bool RepasseTesouraria { get; private set; }
        public double ResumoVendas { get; private set; }


        public Escala()
        {

        }
        public Escala(string descricao, DateTime dataEscala, bool finalizada, string observacao, string tipoSessao, bool repasseTesouraria, double resumoVendas)
        {
            ValidarDominio(descricao, dataEscala, finalizada, observacao, tipoSessao, repasseTesouraria, resumoVendas);
        }
        public Escala(int id, string descricao, DateTime dataEscala, bool finalizada, string observacao, string tipoSessao, bool repasseTesouraria, double resumoVendas)
        {
            DomainExceptionValidation.When(id < 0, "Necessário informar um ID");
            Id = id;
            ValidarDominio(descricao, dataEscala, finalizada, observacao, tipoSessao, repasseTesouraria, resumoVendas);
        }

        private void ValidarDominio(string descricao, DateTime dataEscala, bool finalizada, string observacao, string tipoSessao, bool repasseTesouraria, double resumoVendas)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(descricao),
                "É necessário informar uma descrição para a escala");


            DomainExceptionValidation.When(descricao.Trim().Length < 3,
                "Descrição muito curta para o cadastro");

            DomainExceptionValidation.When(dataEscala.Equals(null),
                "É necessário informar uma data para a escala");


            Descricao = descricao;
            DataEscala = dataEscala;
            Finalizada = finalizada;
            Observacao = observacao;
            TipoSessao = tipoSessao;
            RepasseTesouraria = repasseTesouraria;
            ResumoVendas = resumoVendas;

            }
       
    }
}
