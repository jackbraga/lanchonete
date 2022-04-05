//using LanchoneteUDV.Database;
//using LanchoneteUDV.DataObject;
//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace LanchoneteUDV.Business
//{
//    public class ProdutosBLL : BaseBLL
//    {
//        ProdutosDAL _dal = new ProdutosDAL();
//        public DataTable ListarProdutos()
//        {
//            return _dal.ListarProdutos();
//        }

//        public DataTable ListarProdutosParaVenda()
//        {
//            return _dal.ListarProdutosParaVenda();
//        }
//        public DataTable ListarProdutosParaVendaPorEscala(int idEscala)
//        {
//            return _dal.ListarProdutosParaVendaPorEscala(idEscala);
//        }             

//        public DataTable PesquisarProduto(string pesquisa)
//        {
//            return _dal.PesquisarProduto(pesquisa);
//        }


//        public void SalvarProduto(ProdutoDTO produto)
//        {
//            int idProduto = 0;
//            if (produto.ID == 0)
//            {
//                idProduto = _dal.AdicionarProduto(produto);

//                SalvarLog(new LoggingDTO
//                {
//                    Acao = "INSERT",
//                    IDUsuario = 1,
//                    DataHora = DateTime.Now,
//                    Log =
//                        "ID: " + idProduto + " " +
//                        "Produto: " + produto.Descricao + " " +
//                        "Adicionado por: " + "Jackson Santos Braga " +
//                        "Em: " + DateTime.Now.ToString(),
//                    Formulario = "ProdutosForm",
//                    IDTabela = idProduto,
//                    NomeTabela = "tbProdutos"
//                });

//            }
//            else
//            {
//                _dal.AtualizarProduto(produto);

//                SalvarLog(new LoggingDTO
//                {
//                    Acao = "UPDATE",
//                    IDUsuario = 1,
//                    DataHora = DateTime.Now,
//                    Log =
//                        "ID: " + produto.ID + " " +
//                        "Produto: " + produto.Descricao + " " +
//                        "Atualizado por: " + "Jackson Santos Braga " +
//                        "Em: " + DateTime.Now.ToString(),
//                    Formulario = "ProdutosForm",
//                    IDTabela = produto.ID,
//                    NomeTabela = "tbProdutos"
//                });
//            }
//        }

//        public void ExcluirProduto(ProdutoDTO produto)
//        {
//            _dal.ExcluirProduto(produto);

//            SalvarLog(new LoggingDTO
//            {
//                Acao = "DELETE",
//                IDUsuario = 1,
//                DataHora = DateTime.Now,
//                Log =
//                    "ID: " + produto.ID + " " +
//                    "Produto: " + produto.Descricao + " " +
//                    "Excluido por: " + "Jackson Santos Braga " +
//                    "Em: " + DateTime.Now.ToString(),
//                Formulario = "ProdutosForm",
//                IDTabela = produto.ID,
//                NomeTabela = "tbProdutos"

//            });
//        }

//    }
//}
