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
    public class FinanceiroBLL : BaseBLL
    {
        FinanceiroDAL _dal = new FinanceiroDAL();
        public RepasseFinanceiroDTO ListarItensRepasseFinanceiro(int idEscala, int idSocio)
        {
            RepasseFinanceiroDTO repasse = new RepasseFinanceiroDTO();


            DataTable dt = _dal.ListarItensRepasseFinanceiro(idEscala, idSocio);

            repasse.DataEscala = Convert.ToDateTime(dt.Rows[0]["DataEscala"]);
            repasse.DescricaoEscala = dt.Rows[0]["Escala"].ToString();
            repasse.Nome = dt.Rows[0]["Nome"].ToString();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                repasse.Itens.Add(
                    new RepasseFinanceiroItem
                    {
                        Produto = dt.Rows[i]["Produto"].ToString(),
                        PrecoUnitario = Convert.ToDouble(dt.Rows[i]["PrecoProduto"]),
                        Quantidade = Convert.ToInt32(dt.Rows[i]["Quantidade"])
                    });
            }

            return repasse;
        }

        public DataTable ListarVendasRepasse(int idEscala)
        {
            return _dal.ListarVendasRepasse(idEscala);
        }

        public DataTable ListarCaixa()
        {
            return _dal.ListarCaixa();
        }

        public DataTable ListarCategoriaLancamento()
        {
            return _dal.ListarCategoriaLancamento();
        }

        public DataTable ListarResumo()
        {
            return _dal.ListarResumo();
        }

        public DataTable ListarMesAMes(int ano)
        {
            return _dal.ListarMesAMes(ano);
        }

        public void AtualizaEmailDisparado(int idVenda)
        {
            _dal.AtualizaEmailDisparado(idVenda);       

                SalvarLog(new LoggingDTO
                {
                    Acao = "UPDATE",
                    IDUsuario = 1,
                    DataHora = DateTime.Now,
                    Log =
                        "IDVenda: " + idVenda + " " +
                        "Email disparado por: " + "Jackson Santos Braga " +
                        "Em: " + DateTime.Now.ToString(),
                    Formulario = "RepasseTesourariaVendaForm",
                    IDTabela = idVenda,
                    NomeTabela = "tbVendas"
                });
        }

        public void AdicionarEventoCaixa(CaixaDTO caixa)
        {
            int id;
            id = _dal.AdicionarEventoCaixa(caixa);

            SalvarLog(new LoggingDTO
            {
                Acao = "INSERT",
                IDUsuario = 1,
                DataHora = DateTime.Now,
                Log =
                    "IDCaixa: " + id + " " +
                    "DataEvento: " + caixa.DataEvento + " " +
                    "TipoEvento: " + caixa.TipoEvento + " " +
                    "Categoria: " + caixa.Categoria + " " +
                    "Valor: " + caixa.Valor + " " +
                    "Observacao: " + caixa.Observacao + " " +
                    "Adicionado Por: " + "Jackson Santos Braga " +
                    "Em: " + DateTime.Now.ToString(),
                Formulario = "RepasseTesourariaVendaForm",
                IDTabela = id,
                NomeTabela = "tbVendas"
            });
        }


    }

}

