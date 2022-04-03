using LanchoneteUDV.Domain.Validacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchoneteUDV.Domain.Entidades
{
    public sealed class Categoria : BaseEntity
    {
        public string Descricao { get; private set; }


        public Categoria(string descricao)
        {
            ValidarDominio(descricao);
        }

        public Categoria(int id, string descricao)
        {
            DomainExceptionValidation.When(id < 0, "Necessário informar um ID");
            Id = id;
            ValidarDominio(descricao);
        }

        public void Update(string descricao)
        {
            ValidarDominio(descricao);
        }

        private void ValidarDominio(string descricao)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(descricao),
                "É necessário informar uma categoria");
            DomainExceptionValidation.When(descricao.Trim().Length <3,
                "Categoria muito curta para o cadastro");

            Descricao = descricao;
        }


    }
}
