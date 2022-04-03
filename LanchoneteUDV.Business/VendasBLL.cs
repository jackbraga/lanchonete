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
    public class VendasBLL : BaseBLL
    {
        VendasDAL _vendasDal = new VendasDAL();

        public DataTable ListarVendas(int id)
        {
            return _vendasDal.ListarVendas(id);
        }

        public DataTable ListarVendasPesquisa(int idEscala, string pesquisa)
        {
            return _vendasDal.ListarVendasPesquisa(idEscala, pesquisa);
        }

        public DataTable ListarEstoque()
        {
            return _vendasDal.ListarEstoque();
        }

        public DataTable ListarEstoquePorEscala(int idEscala)
        {
            return _vendasDal.ListarEstoquePorEscala(idEscala);
        }

        public DataTable ListarEstoqueSalgadosPorEscala(int idEscala)
        {
            return _vendasDal.ListarEstoqueSalgadosPorEscala(idEscala);
        }
        

        public DataTable PesquisarEstoque(string pesquisa)
        {
            return _vendasDal.PesquisarEstoque(pesquisa);
        }

        public DataTable TrazerEscala(int idEscala)
        {
            return _vendasDal.TrazerEscala(idEscala);
        }

        public DataTable TrazerVenda(int idEscala, int idSocio)
        {
            return _vendasDal.TrazerVenda(idEscala, idSocio);
        }

        public int SalvarVenda(VendasDTO venda)
        {

            int idVenda;

            if (venda.ID == 0)
            {
                idVenda = _vendasDal.AdicionarVenda(venda);

                SalvarLog(new LoggingDTO
                {
                    Acao = "INSERT",
                    IDUsuario = 1,
                    DataHora = DateTime.Now,
                    Log =
                        "IDVenda: " + idVenda + " " +
                        "Escala: " + venda.IDEscala + " " +
                        "Socio: " + venda.IDSocio + " " +
                        "TipoPagamento: " + venda.TipoPagamento + " " +
                        "Adicionado por: " + "Jackson Santos Braga " +
                        "Em: " + DateTime.Now.ToString(),
                    Formulario = "PedidoFormForm",
                    IDTabela = idVenda,
                    NomeTabela = "tbVendas"
                });
            }


            else
            {
                _vendasDal.AtualizarVenda(venda);
                idVenda = venda.ID;

                SalvarLog(new LoggingDTO
                {
                    Acao = "UPDATE",
                    IDUsuario = 1,
                    DataHora = DateTime.Now,
                    Log =
                    "IDVenda: " + venda.ID + " " +
                    "Escala: " + venda.IDEscala + " " +
                    "Socio: " + venda.IDSocio + " " +
                    "TipoPagamento: " + venda.TipoPagamento + " " +
                    "Atualizado por: " + "Jackson Santos Braga " +
                    "Em: " + DateTime.Now.ToString(),
                                Formulario = "PedidoFormForm",
                                IDTabela = venda.ID,
                                NomeTabela = "tbVendas"
                            });
            }

            return idVenda;

        }


        //public DataTable PesquisarCompra(string pesquisa, string filtro)
        //{
        //    if (filtro == "Data da Compra")
        //    {
        //        filtro = "DataCompra";
        //    }
        //    else if (filtro == "Comprado Por")
        //    {
        //        filtro = "CompradoPor";
        //    }

        //    return _dal.PesquisarCompra(pesquisa, filtro);
        //}


        //public void SalvarCompra(CompraDTO compra)
        //{
        //    int idCompra = 0;
        //    if (compra.ID == 0)
        //    {
        //        idCompra = _dal.AdicionarCompra(compra);

        //        SalvarLog(new LoggingDTO
        //        {
        //            Acao = "INSERT",
        //            IDUsuario = 1,
        //            DataHora = DateTime.Now,
        //            Log =
        //                "IDCompra: " + idCompra + " " +
        //                "TipoEntrada: " + compra.TipoEntrada + " " +
        //                "Observacao: " + compra.Observacao + " " +
        //                "Descricao: " + compra.Descricao + " " +
        //                "Adicionado por: " + "Jackson Santos Braga " +
        //                "Em: " + DateTime.Now.ToString(),
        //            Formulario = "ComprasForm",
        //            IDTabela = idCompra,
        //            NomeTabela = "tbCompras"
        //        });
        //    }
        //    else
        //    {
        //        _dal.AtualizarCompra(compra);

        //        SalvarLog(new LoggingDTO
        //        {
        //            Acao = "UPDATE",
        //            IDUsuario = 1,
        //            DataHora = DateTime.Now,
        //            Log =
        //                "IDCompra: " + compra.ID + " " +
        //                "TipoEntrada: " + compra.TipoEntrada + " " +
        //                "Observacao: " + compra.Observacao + " " +
        //                "Descricao: " + compra.Descricao + " " +
        //                "Atualizado por: " + "Jackson Santos Braga " +
        //                "Em: " + DateTime.Now.ToString(),
        //            Formulario = "ComprasForm",
        //            IDTabela = compra.ID,
        //            NomeTabela = "tbCompras"
        //        });

        //    }
        //}

        //public void ExcluirCompra(CompraDTO compra)
        //{
        //    _dal.ExcluirCompra(compra);

        //    SalvarLog(new LoggingDTO
        //    {
        //        Acao = "DELETE",
        //        IDUsuario = 1,
        //        DataHora = DateTime.Now,
        //        Log =
        //            "IDCompra: " + compra.ID + " " +
        //            "TipoEntrada: " + compra.TipoEntrada + " " +
        //            "Observacao: " + compra.Observacao + " " +
        //            "Descricao: " + compra.Descricao + " " +
        //            "Excluido por: " + "Jackson Santos Braga " +
        //            "Em: " + DateTime.Now.ToString(),
        //        Formulario = "ComprasForm",
        //        IDTabela = compra.ID,
        //        NomeTabela = "tbCompras"
        //    });
        //}

    }
}
