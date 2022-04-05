//using LanchoneteUDV.Database;
//using LanchoneteUDV.DataObject;
//using System.Data;

//namespace LanchoneteUDV.Business
//{
//    public class CategoriasBLL : BaseBLL
//    {
//        CategoriasDAL _dal = new CategoriasDAL();
//        LoggingDAL _log = new LoggingDAL();
//        public void SalvarCategoria(CategoriaDTO categoria)
//        {
//            int idCategoria = 0;
//            if (categoria.ID == 0)
//            {
//                idCategoria = _dal.AdicionarCategoria(categoria);
//                SalvarLog(new LoggingDTO
//                {
//                    Acao = "INSERT",
//                    IDUsuario = 1,
//                    DataHora = DateTime.Now,
//                    Log =
//                        "IDCategoria: " + idCategoria + " " +
//                        "Categoria: " + categoria.Descricao + " " +
//                        "Adicionada por: " + "Jackson Santos Braga " +
//                        "Em: " + DateTime.Now.ToString(),
//                    Formulario = "CategoriasForm",
//                    IDTabela = idCategoria,
//                    NomeTabela = "tbCategorias"

//                });
//            }
//            else
//            {
//                _dal.AtualizarCategoria(categoria);

//                SalvarLog(new LoggingDTO
//                {
//                    Acao = "UPDATE",
//                    IDUsuario = 1,
//                    DataHora = DateTime.Now,
//                    Log =
//                        "IDCategoria: " + categoria.ID + " Categoria: " + categoria.Descricao + " " +
//                        "Atualizada por: " + "Jackson Santos Braga " +
//                        "Em: " + DateTime.Now.ToString(),
//                    Formulario = "CategoriasForm",
//                    IDTabela = categoria.ID,
//                    NomeTabela = "tbCategorias"
//                });
//            }
//        }

//        public void ExcluirCategoria(CategoriaDTO categoria)
//        {
//            _dal.ExcluirCategoria(categoria);

//            SalvarLog(new LoggingDTO
//            {
//                Acao = "DELETE",
//                IDUsuario = 1,
//                DataHora = DateTime.Now,
//                Log =
//                    "IDCategoria: " + categoria.ID + " " +
//                    "Categoria: " + categoria.Descricao + " " +
//                    "Excluida por: " + "Jackson Santos Braga " +
//                    "Em: " + DateTime.Now.ToString(),
//                Formulario = "CategoriasForm",
//                IDTabela = categoria.ID,
//                NomeTabela = "tbCategorias"

//            });
//        }


//        public DataTable ListarCategorias()
//        {
//            return _dal.ListarCategorias();
//        }

//        public DataTable PesquisarCategoria(string pesquisa)
//        {
//            return _dal.PesquisarCategoria(pesquisa);
//        }


//    }
//}