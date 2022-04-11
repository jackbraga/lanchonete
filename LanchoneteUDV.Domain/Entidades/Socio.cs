using LanchoneteUDV.Domain.Validacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchoneteUDV.Domain.Entidades
{
    public class Socio : BaseEntity
    {
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public int TipoSocio { get; set; }
        public DateTime DataCriacao { get; set; }
        public int ResponsavelFinanceiro { get; set; }
        public string NomeResponsavel { get; set; }



        public Socio()
        {

        }
        public Socio(string nome, string email, int tipoSocio, DateTime dataCriacao, int responsavelFinanceiro)
        {
            ValidarDominio(nome, email, tipoSocio, dataCriacao, responsavelFinanceiro);
        }
        public Socio(int id, string nome, string email, int tipoSocio, DateTime dataCriacao, int responsavelFinanceiro)
        {
            DomainExceptionValidation.When(id < 0, "Necessário informar um ID");
            Id = id;
            ValidarDominio(nome, email, tipoSocio, dataCriacao, responsavelFinanceiro);
        }

        private void ValidarDominio(string nome, string email, int tipoSocio, DateTime dataCriacao, int responsavelFinanceiro)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(nome),
                "É necessário informar um nome para o Socio");


            DomainExceptionValidation.When(nome.Trim().Length < 3,
                "Nome muito curto para o cadastro");

            Nome = nome;
            Email = email;
            TipoSocio = TipoSocio;
            DataCriacao = dataCriacao;
            ResponsavelFinanceiro = responsavelFinanceiro;


        }

    }
}
