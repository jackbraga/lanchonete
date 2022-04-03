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
    public class ComprasBLL : BaseBLL
    {
        ComprasDAL _dal = new ComprasDAL();
        public DataTable ListarProdutos()
        {
            return _dal.ListarProdutos();
        }

        public DataTable ListarCompras()
        {
            return _dal.ListarCompras();
        }

        public DataTable PesquisarCompra(string pesquisa, string filtro)
        {
            if (filtro == "Data da Compra")
            {
                filtro = "DataCompra";
            }
            else if (filtro == "Comprado Por")
            {
                filtro = "CompradoPor";
            }

            return _dal.PesquisarCompra(pesquisa, filtro);
        }


        public void SalvarCompra(CompraDTO compra)
        {
            int idCompra = 0;
            if (compra.ID == 0)
            {
                idCompra= _dal.AdicionarCompra(compra);

                SalvarLog(new LoggingDTO
                {
                    Acao = "INSERT",
                    IDUsuario = 1,
                    DataHora = DateTime.Now,
                    Log =
                        "IDCompra: " + idCompra + " " +
                        "TipoEntrada: " + compra.TipoEntrada + " " +
                        "Observacao: " + compra.Observacao + " " +
                        "Descricao: " + compra.Descricao + " " +
                        "Adicionado por: " + "Jackson Santos Braga " +
                        "Em: " + DateTime.Now.ToString(),
                    Formulario = "ComprasForm",
                    IDTabela = idCompra,
                    NomeTabela = "tbCompras"
                });
            }
            else
            {
                _dal.AtualizarCompra(compra);

                SalvarLog(new LoggingDTO
                {
                    Acao = "UPDATE",
                    IDUsuario = 1,
                    DataHora = DateTime.Now,
                    Log =
                        "IDCompra: " + compra.ID + " " +
                        "TipoEntrada: " + compra.TipoEntrada + " " +
                        "Observacao: " + compra.Observacao + " " +
                        "Descricao: " + compra.Descricao + " " +
                        "Atualizado por: " + "Jackson Santos Braga " +
                        "Em: " + DateTime.Now.ToString(),
                    Formulario = "ComprasForm",
                    IDTabela = compra.ID,
                    NomeTabela  = "tbCompras"
                });

            }
        }

        public void ExcluirCompra(CompraDTO compra)
        {
            _dal.ExcluirCompra(compra);

            SalvarLog(new LoggingDTO
            {
                Acao = "DELETE",
                IDUsuario = 1,
                DataHora = DateTime.Now,
                Log =
                    "IDCompra: " + compra.ID + " " +
                    "TipoEntrada: " + compra.TipoEntrada + " " +
                    "Observacao: " + compra.Observacao + " " +
                    "Descricao: " + compra.Descricao + " " +
                    "Excluido por: " + "Jackson Santos Braga " +
                    "Em: " + DateTime.Now.ToString(),
                Formulario = "ComprasForm",
                IDTabela = compra.ID,
                NomeTabela = "tbCompras"
            });
        }
    }


}
