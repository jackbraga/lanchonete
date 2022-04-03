using LanchoneteUDV.Database;
using LanchoneteUDV.DataObject;
using System.Data;

namespace LanchoneteUDV.Business
{
    public class SociosBLL : BaseBLL
    {
        SociosDAL _dal = new SociosDAL();
        public void SalvarSocio(SocioDTO socio)
        {
            int idSocio = 0;
            if (socio.ID == 0)
            {
                idSocio = _dal.AdicionarSocio(socio);

                SalvarLog(new LoggingDTO
                {
                    Acao = "INSERT",
                    IDUsuario = 1,
                    DataHora = DateTime.Now,
                    Log =
                        "ID: " + idSocio + " " +
                        "Socio: " + socio.Nome + " " +
                        "Email: " + socio.Email+ " " +
                        "Adicionado por: " + "Jackson Santos Braga " +
                        "Em: " + DateTime.Now.ToString(),
                    Formulario = "SociosForm",
                    IDTabela = idSocio,
                    NomeTabela = "tbSocios"

                });
            }
            else
            {
                _dal.AtualizarSocio(socio);

                SalvarLog(new LoggingDTO
                {
                    Acao = "UPDATE",
                    IDUsuario = 1,
                    DataHora = DateTime.Now,
                    Log =
                        "ID: " + socio.ID + " " +
                        "Socio: " + socio.Nome + " " +
                        "Email: " + socio.Email + " " +
                        "Atualizado por: " + "Jackson Santos Braga " +
                        "Em: " + DateTime.Now.ToString(),
                    Formulario = "SociosForm",
                    IDTabela = socio.ID,
                    NomeTabela = "tbSocios"
                });
            }
        }

        public void ExcluirSocio(SocioDTO socio)
        {
            _dal.ExcluirSocio(socio);

            SalvarLog(new LoggingDTO
            {
                Acao = "DELETE",
                IDUsuario = 1,
                DataHora = DateTime.Now,
                Log =
                    "ID: " + socio.ID + " " +
                    "Socio: " + socio.Nome + " " +
                    "Excluido por: " + "Jackson Santos Braga " +
                    "Em: " + DateTime.Now.ToString(),
                Formulario = "SociosForm",
                IDTabela = socio.ID,
                NomeTabela = "tbSocios"
            });
        }

        public DataTable ListarSocios()
        {
            return _dal.ListarSocios();
        }
        public DataTable ListarSociosVisitantes()
        {
            return _dal.ListarSociosVisitantes();
        }
        public DataTable ListarSociosVenda()
        {
            return _dal.ListarSociosVenda();
        }
        

        public DataTable PesquisarSocio(string pesquisa)
        {
            return _dal.PesquisarSocio(pesquisa);
        }
    }
}