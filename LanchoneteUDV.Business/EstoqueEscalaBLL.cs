using LanchoneteUDV.Database;
using LanchoneteUDV.DataObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchoneteUDV.Business
{
    public class EstoqueEscalaBLL : BaseBLL

    {
        EstoqueEscalaDAL _dal = new EstoqueEscalaDAL();
        public DataTable ListarEstoqueEscala(int idEscala)
        {
            return _dal.ListarEstoqueEscala(idEscala);
        }

        public void ExcluirEstoqueEscala(EstoqueEscalaDTO estoqueEscala)
        {
            _dal.ExcluirEstoqueEscala(estoqueEscala);

            SalvarLog(new LoggingDTO
            {
                Acao = "DELETE",
                IDUsuario = 1,
                DataHora = DateTime.Now,
                Log =
                    "IDEstoqueEscala: " + estoqueEscala.ID + " " +
                    "IDProduto: " + estoqueEscala.IDProduto + " " +
                    "IDEscala: " + estoqueEscala.IDEscala + " " +
                    "QtdVenda: " + estoqueEscala.QtdVenda + " " +
                    "Observacao: " + estoqueEscala.Observacao + " " +
                    "Excluido por: " + "Jackson Santos Braga " +
                    "Em: " + DateTime.Now.ToString(),
                Formulario = "EstoqueEscalaForm",
                IDTabela = estoqueEscala.ID,
                NomeTabela = "tbEstoqueEscala"
            });
        }

        public void SalvarEstoqueEscala(EstoqueEscalaDTO estoqueEscala)
        {
            int idEstoque = 0;
            if (estoqueEscala.ID == 0)
            {
                idEstoque = _dal.AdicionarEstoqueEscala(estoqueEscala);

                SalvarLog(new LoggingDTO
                {
                    Acao = "INSERT",
                    IDUsuario = 1,
                    DataHora = DateTime.Now,
                    Log =
                    "IDCompra: " + idEstoque + " " +
                    "IDProduto: " + estoqueEscala.IDProduto + " " +
                    "IDEscala: " + estoqueEscala.IDEscala + " " +
                    "QtdVenda: " + estoqueEscala.QtdVenda + " " +
                    "Observacao: " + estoqueEscala.Observacao + " " +
                    "Adicionado por: " + "Jackson Santos Braga " +
                    "Em: " + DateTime.Now.ToString(),
                    Formulario = "EstoqueEscalaForm",
                    IDTabela = idEstoque,
                    NomeTabela = "tbEstoqueEscala"
                });
            }
            else
            {
                _dal.AtualizarEstoqueEscala(estoqueEscala);

                SalvarLog(new LoggingDTO
                {
                    Acao = "UPDATE",
                    IDUsuario = 1,
                    DataHora = DateTime.Now,
                    Log =
                    "IDCompra: " + estoqueEscala.ID + " " +
                    "IDProduto: " + estoqueEscala.IDProduto + " " +
                    "IDEscala: " + estoqueEscala.IDEscala + " " +
                    "QtdVenda: " + estoqueEscala.QtdVenda + " " +
                    "Observacao: " + estoqueEscala.Observacao + " " +
                    "Atualizado por: " + "Jackson Santos Braga " +
                    "Em: " + DateTime.Now.ToString(),
                    Formulario = "EstoqueEscalaForm",
                    IDTabela = estoqueEscala.ID,
                    NomeTabela = "tbEstoqueEscala"
                });

            }
        }

        public void CompletarEstoqueEscala(int idEscala)
        {
            _dal.CompletarEstoqueEscala(idEscala);

        }

    }
}
