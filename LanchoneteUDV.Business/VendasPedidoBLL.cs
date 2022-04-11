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
//    public class VendasPedidoBLL : BaseBLL
//    {
//        VendasPedidoDAL _vendasPedidoDal = new VendasPedidoDAL();
//        public int AdicionarVendaPedido(VendasPedidoDTO vendaPedido)
//        {
//            int idVendaPedido;
//            idVendaPedido =  _vendasPedidoDal.AdicionarVendasPedido(vendaPedido);

//            SalvarLog(new LoggingDTO
//            {
//                Acao = "INSERT",
//                IDUsuario = 1,
//                DataHora = DateTime.Now,
//                Log =
//                    "IDVendaPedido: " + idVendaPedido + " " +
//                    "IDVenda: " + vendaPedido.IDVenda + " " +
//                    "IDProduto: " + vendaPedido.IDProduto + " " +
//                    "Quantidade: " + vendaPedido.Quantidade + " " +
//                    "PrecoProduto: " + vendaPedido.PrecoProduto + " " +
//                    "Observacao: " + vendaPedido.Observacao + " " +
//                    "Retirado: " + vendaPedido.Retirado + " " +
//                    "Quantidade: " + vendaPedido.Quantidade + " " +
//                    "DataHoraPedido: " + vendaPedido.DataHoraPedidoItem + " " +
//                    "Adicionado por: " + "Jackson Santos Braga " +
//                    "Em: " + DateTime.Now.ToString(),
//                Formulario = "PedidoFormForm",
//                IDTabela = idVendaPedido,
//                NomeTabela = "tbVendasPedido"
//            });

//            return idVendaPedido;
//        }

//        public void RegistrarRetirada(int idVendaPedido)
//        {
//            _vendasPedidoDal.RegistrarRetirada(idVendaPedido);

//            SalvarLog(new LoggingDTO
//            {
//                Acao = "UPDATE",
//                IDUsuario = 1,
//                DataHora = DateTime.Now,
//                Log =
//                    "IDVendaPedido: " + idVendaPedido + " " +
//                    "Retirada: true " +
//                    "Atualizado por: " + "Jackson Santos Braga " +
//                    "Em: " + DateTime.Now.ToString(),
//                Formulario = "PedidoFormForm",
//                IDTabela = idVendaPedido,
//                NomeTabela = "tbVendasPedido"
//            });

//        }

//        public void DesmarcarRetirada(int idVendaPedido)
//        {
//            _vendasPedidoDal.DesmarcarRetirada(idVendaPedido);

//            SalvarLog(new LoggingDTO
//            {
//                Acao = "UPDATE",
//                IDUsuario = 1,
//                DataHora = DateTime.Now,
//                Log =
//                    "IDVendaPedido: " + idVendaPedido + " " +
//                    "Retirada: false " +
//                    "Atualizado por: " + "Jackson Santos Braga " +
//                    "Em: " + DateTime.Now.ToString(),
//                            Formulario = "PedidoFormForm",
//                            IDTabela = idVendaPedido,
//                            NomeTabela = "tbVendasPedido"
//            });

//        }

//        public void ExcluirItemPedido(int idVendaPedido)
//        {
//            _vendasPedidoDal.ExcluirItemPedido(idVendaPedido);

//            SalvarLog(new LoggingDTO
//            {
//                Acao = "DELETE",
//                IDUsuario = 1,
//                DataHora = DateTime.Now,
//                Log =
//                    "IDVendaPedido: " + idVendaPedido + " " +
//                    "Excluido por: " + "Jackson Santos Braga " +
//                    "Em: " + DateTime.Now.ToString(),
//                Formulario = "PedidoFormForm",
//                IDTabela = idVendaPedido,
//                NomeTabela = "tbVendasPedido"
//            });

//        }

        


//        public DataTable ListarVendasPedido(int idVenda)
//        {
//            return _vendasPedidoDal.ListarVendasPedido(idVenda);
//        }

//        public DataTable ListarTodosVendasPedido(int idEscala)
//        {
//            return _vendasPedidoDal.ListarTodosVendasPedido(idEscala);
//        }

        


//    }
//}
