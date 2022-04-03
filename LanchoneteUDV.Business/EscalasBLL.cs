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
    public class EscalasBLL : BaseBLL
    {
        EscalasDAL _dal = new EscalasDAL();

        public DataTable ListarEscalas()
        {
            return _dal.ListarEscalas();
        }

        public DataTable PesquisarEscala(string pesquisa)
        {
            return _dal.PesquisarEscala(pesquisa);
        }


        public void SalvarEscala(EscalaDTO escala)
        {
            int idEscala = 0;
            if (escala.ID == 0)
            {
                idEscala = _dal.AdicionarEscala(escala);

                SalvarLog(new LoggingDTO
                {
                    Acao = "INSERT",
                    IDUsuario = 1,
                    DataHora = DateTime.Now,
                    Log =
                        "IDEscala: " + idEscala + " " +
                        "Descricao: " + escala.Descricao + " " +
                        "DataEscala: " + escala.DataEscala + " " +
                        "Finalizada: " + escala.Finalizada + " " +
                        "Observacao: " + escala.Observacao + " " +
                        "TipoSessao: " + escala.TipoSessao + " " +
                        "Adicionado por: " + "Jackson Santos Braga " +
                        "Em: " + DateTime.Now.ToString(),
                    Formulario = "EscalasForm",
                    IDTabela = idEscala,
                    NomeTabela = "tbEscalas"
                });
            }
            else
            {
                _dal.AtualizarEscala(escala);

                SalvarLog(new LoggingDTO
                {
                    Acao = "UPDATE",
                    IDUsuario = 1,
                    DataHora = DateTime.Now,
                    Log =
                        "IDEscala: " + escala.ID + " " +
                        "Descricao: " + escala.Descricao + " " +
                        "DataEscala: " + escala.DataEscala + " " +
                        "Finalizada: " + escala.Finalizada + " " +
                        "Observacao: " + escala.Observacao + " " +
                        "TipoSessao: " + escala.TipoSessao + " " +
                        "Atualizado por: " + "Jackson Santos Braga " +
                        "Em: " + DateTime.Now.ToString(),
                    Formulario = "EscalasForm",
                    IDTabela = escala.ID,
                    NomeTabela = "tbEscalas"
                });

            }
        }

        public void ExcluirEscala(EscalaDTO escala)
        {
            _dal.ExcluirEscala(escala);

            SalvarLog(new LoggingDTO
            {
                Acao = "DELETE",
                IDUsuario = 1,
                DataHora = DateTime.Now,
                Log =
                        "IDEscala: " + escala.ID + " " +
                        "Descricao: " + escala.Descricao + " " +
                        "DataEscala: " + escala.DataEscala + " " +
                        "Finalizada: " + escala.Finalizada + " " +
                        "Observacao: " + escala.Observacao + " " +
                        "TipoSessao: " + escala.TipoSessao + " " +
                        "Excluido por: " + "Jackson Santos Braga " +
                        "Em: " + DateTime.Now.ToString(),
                Formulario = "EscalasForm",
                IDTabela = escala.ID,
                NomeTabela = "tbEscalas"
            });
        }


        public void FinalizarEscala(int idEscala)
        {
            _dal.FinalizarEscala(idEscala);

            SalvarLog(new LoggingDTO
            {
                Acao = "UPDATE",
                IDUsuario = 1,
                DataHora = DateTime.Now,
                Log =
                        "IDEscala: " + idEscala + " " +
                        "Escala Finalizado por: " + "Jackson Santos Braga " +
                        "Em: " + DateTime.Now.ToString(),
                Formulario = "EscalasForm",
                IDTabela = idEscala,
                NomeTabela = "tbEscalas"
            });
        }


    }
}
