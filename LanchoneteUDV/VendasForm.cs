using LanchoneteUDV.Application.Interfaces;
using LanchoneteUDV.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LanchoneteUDV
{
    public partial class VendasForm : Form
    {
        //VendasBLL _bllVendas = new VendasBLL();
        private readonly IVendaService _vendaService;
        private readonly IProdutoService _produtoService;
        private readonly ISocioService _socioService;
        private readonly IEstoqueEscalaService _estoqueEscalaService;
        private readonly IVendasPedidoService _vendasPedidoService;
        public VendasForm(IVendaService vendaService,IProdutoService produtoService,ISocioService socioService,IEstoqueEscalaService estoqueEscalaService
            ,IVendasPedidoService vendasPedidoService)
        {
            _vendaService = vendaService;
            _produtoService = produtoService;
            _socioService = socioService;
            _estoqueEscalaService = estoqueEscalaService;
            _vendasPedidoService = vendasPedidoService;
            InitializeComponent();
            
        }

        private void VendasForm_Load(object sender, EventArgs e)
        {
            RecarregarTela();
        }



        #region Métodos

        private void RecarregaGrid()
        {
            VendasDataGridView.DataSource = _vendaService.ListarVendasEscala(Convert.ToInt32(this.Tag)); //_bllVendas.ListarVendas(Convert.ToInt32(this.Tag));
            VendasDataGridView.Columns[0].Visible = false;
            VendasDataGridView.Columns[1].Visible = false;
            VendasDataGridView.Columns[2].HeaderText = "Socio";
            VendasDataGridView.Columns[2].Width = 210;
            VendasDataGridView.Columns[3].HeaderText = "Pagamento";
            VendasDataGridView.Columns[4].DefaultCellStyle.Format = "R$ 0.00##";
            VendasDataGridView.Columns[4].HeaderText = "Valor Total";
            VendasDataGridView.Columns[5].HeaderText = "Itens para Retirar";
            VendasDataGridView.ClearSelection();

        }

        private void FormataGridResumo()
        {
            ResumoVendasDataGridView.Columns[0].Visible = false;
            ResumoVendasDataGridView.Columns[1].Visible = false;
            ResumoVendasDataGridView.Columns[2].Visible = false;
            ResumoVendasDataGridView.Columns[4].Visible = false;
            ResumoVendasDataGridView.Columns[3].DefaultCellStyle.Format = "R$ 0.00##";
            ResumoVendasDataGridView.Columns[3].Width = 80;
            ResumoVendasDataGridView.Columns[5].Width = 80;
            ResumoVendasDataGridView.Columns[5].HeaderText = "Pagamento";


        }

        #endregion

        //private void RegistrarRetiradaButton_Click(object sender, EventArgs e)
        //{
        //    PedidoForm pedido = new PedidoForm();
        //    pedido.IdEscala = Convert.ToInt32(IdTextBox.Text);
        //    pedido.ShowDialog();
        //}

        private void VendasDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = VendasDataGridView.CurrentRow.Index;

            PedidoForm pedido = new PedidoForm(_produtoService,_socioService,_vendaService,_vendasPedidoService);
            pedido.IdEscala = Convert.ToInt32(IdTextBox.Text);
            pedido.IdSocio = Convert.ToInt32(VendasDataGridView.Rows[row].Cells[1].Value);
            pedido.ShowDialog();
            RecarregarTela();

        }

        private void RecarregarTela()
        {
            // DataTable dados = _vendaService.TrazerVendaEscalaResumoVenda(Convert.ToInt32(this.Tag));  //_bllVendas.TrazerEscala(Convert.ToInt32(this.Tag));

            //DataRow row = dados.Rows[0];

            //IdTextBox.Text = row["ID"].ToString();
            //DescricaoEscalaTextBox.Text = row["Descricao"].ToString();
            //DataEscalaDateTimePicker.Value = Convert.ToDateTime(row["DataEscala"]);
            //if (!string.IsNullOrEmpty(row["Resumo"].ToString()))
            //{
            //    ResumoVendasTextBox.Text = "R$ " + String.Format("{0:N2}", double.Parse(row["Resumo"].ToString()));
            //}

            var vendas = _vendaService.TrazerVendaEscalaResumoVenda(Convert.ToInt32(this.Tag));
            var vendas1 = vendas.First();
            IdTextBox.Text = vendas1.IdEscala.ToString();
            DescricaoEscalaTextBox.Text = vendas1.Descricao;
            DataEscalaDateTimePicker.Value = vendas1.DataEscala;
            if (!string.IsNullOrEmpty(vendas1.ResumoVendas.ToString()))
            {
                ResumoVendasTextBox.Text = "R$ " + String.Format("{0:N2}", double.Parse(vendas1.ResumoVendas.ToString()));
            }


            //vendas.First().
            ResumoVendasDataGridView.DataSource = vendas;//dados;
            FormataGridResumo();
            RecarregaGrid();
        }


        private void FilaButton_Click(object sender, EventArgs e)
        {
            FilaPedidosForm fila = new FilaPedidosForm(_vendasPedidoService);
            fila.Tag = IdTextBox.Text;
            fila.Show();
        }


        private void EstoqueButton_Click(object sender, EventArgs e)
        {
            EstoqueForm estoque = new EstoqueForm(_estoqueEscalaService);
            estoque.Show();
        }

        private void NovoButton_Click_1(object sender, EventArgs e)
        {
            PedidoForm pedido = new PedidoForm(_produtoService,_socioService,_vendaService, _vendasPedidoService);
            pedido.IdEscala = Convert.ToInt32(IdTextBox.Text);
            pedido.ShowDialog();
            RecarregarTela();
        }

        private void EstoqueEscalaButton_Click(object sender, EventArgs e)
        {
            EstoqueEscalaForm estoque = new EstoqueEscalaForm(_estoqueEscalaService,_vendaService);
            estoque.IDEscala = Convert.ToInt32(this.Tag);
            estoque.ShowDialog();
        }

        private void PesquisaTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            VendasDataGridView.DataSource = _vendaService.ListarVendasPesquisa(Convert.ToInt32(this.Tag), PesquisaTextBox.Text); //_bllVendas.ListarVendasPesquisa(Convert.ToInt32(this.Tag),PesquisaTextBox.Text);
            VendasDataGridView.Columns[0].Visible = false;
            VendasDataGridView.Columns[1].Visible = false;
            VendasDataGridView.Columns[2].HeaderText = "Socio";
            VendasDataGridView.Columns[2].Width = 210;
            VendasDataGridView.Columns[3].HeaderText = "Pagamento";
            VendasDataGridView.Columns[4].DefaultCellStyle.Format = "R$ 0.00##";
            VendasDataGridView.Columns[4].HeaderText = "Valor Total";
            VendasDataGridView.Columns[5].HeaderText = "Itens para Retirar";
            VendasDataGridView.ClearSelection();
        }

    }
}
