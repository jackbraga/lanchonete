using LanchoneteUDV.Application.Interfaces;
using LanchoneteUDV.Application.Services;
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
    public partial class VendasParceriasForm : Form
    {
        Helper _helper = new Helper();
        public int Id;
        public string Descricao;

        private readonly IProdutoService _produtoService;
        private readonly IParceriasService _parceriasService;
        private readonly IVendasPedidoService _vendasPedidoService;

        public VendasParceriasForm(IProdutoService produtoService, IParceriasService parceriasService, IVendasPedidoService vendasPedidoService)
        {
            InitializeComponent();
            _produtoService = produtoService;
            _parceriasService = parceriasService;
            _vendasPedidoService = vendasPedidoService;
        }

        private void VendasParceriasForm_Load(object sender, EventArgs e)
        {
            groupBox4.Text = Descricao.ToUpper();
            RecarregaGridProdutos();
            RecarregaGridEscalas();
            RecarregaGridVendasProdutos();
        }

        private void RecarregaGridProdutos()
        {
            ProdutosParceirosDataGridView.DataSource = _parceriasService.BuscarProdutosParceria(Id);
            FormatarGridProdutos();
        }
        private void RecarregaGridEscalas()
        {
            EscalasDataGridView.DataSource = _parceriasService.BuscarParceriaEscala(Id);
            FormatarGridEscalas();
        }

        private void RecarregaGridVendasProdutos()
        {
            VendasProdutosDataGridView.DataSource = _parceriasService.BuscarVendasProdutosParceria(Id,RetiradosCheckBox.Checked);
            FormatarGridProdutosParceria();
        }

        private void FormatarGridProdutosParceria()

        {
            VendasProdutosDataGridView.Columns[0].HeaderText = "Data da Escala";
            VendasProdutosDataGridView.Columns[0].Width = 120;

            VendasProdutosDataGridView.Columns[1].HeaderText = "Escala";
            VendasProdutosDataGridView.Columns[1].Width = 250;

            VendasProdutosDataGridView.Columns[2].HeaderText = "Socio";
            VendasProdutosDataGridView.Columns[2].Width = 350;

            VendasProdutosDataGridView.Columns[3].HeaderText = "Produto";
            VendasProdutosDataGridView.Columns[3].Width = 350;


            VendasProdutosDataGridView.Columns[4].HeaderText = "Quantidade";
            VendasProdutosDataGridView.Columns[4].Width = 120;

            VendasProdutosDataGridView.Columns[5].HeaderText = "Preço";
            VendasProdutosDataGridView.Columns[5].Width = 150;
            VendasProdutosDataGridView.Columns[5].DefaultCellStyle.Format = "R$ 0.00##";

            VendasProdutosDataGridView.Columns[7].Visible = false;
        }

        private void FormatarGridEscalas()
        {

            EscalasDataGridView.Columns[0].HeaderText = "Data da Escala";
            EscalasDataGridView.Columns[0].Width = 110;

            EscalasDataGridView.Columns[1].HeaderText = "Escala";
            EscalasDataGridView.Columns[1].Width = 150;

            EscalasDataGridView.Columns[2].Visible= false;

            EscalasDataGridView.Columns[3].HeaderText = "Tipo Comissao";
            EscalasDataGridView.Columns[3].Width = 100;

            EscalasDataGridView.Columns[4].HeaderText = "Valor da Comissão";
            EscalasDataGridView.Columns[4].DefaultCellStyle.Format = "0.00##";
            EscalasDataGridView.Columns[4].Width = 80;

            EscalasDataGridView.Columns[5].HeaderText = "Qtd Vendas";
            EscalasDataGridView.Columns[5].Width = 70;

            EscalasDataGridView.Columns[6].HeaderText = "Total de vendas";
            EscalasDataGridView.Columns[6].DefaultCellStyle.Format = "R$ 0.00##";
            EscalasDataGridView.Columns[6].Width = 80;

            EscalasDataGridView.Columns[7].Width = 100;
            EscalasDataGridView.Columns[7].HeaderText = "Total de comissão";
            EscalasDataGridView.Columns[7].DefaultCellStyle.Format = "R$ 0.00##";

            EscalasDataGridView.Columns[8].Visible = false;
            EscalasDataGridView.Columns[9].Visible = false;


            EscalasDataGridView.Columns[10].Width = 80;
            EscalasDataGridView.Columns[10].HeaderText = "Valor Repasse";
            EscalasDataGridView.Columns[10].DefaultCellStyle.Format = "R$ 0.00##";


            ColorirRepasseFeito();
        }

        private void FormatarGridProdutos()
        {
            ProdutosParceirosDataGridView.Columns[0].Visible = false;
            ProdutosParceirosDataGridView.Columns[1].Visible = false;
            ProdutosParceirosDataGridView.Columns[2].Visible = false;
            ProdutosParceirosDataGridView.Columns[3].Visible = false;

            ProdutosParceirosDataGridView.Columns[4].HeaderText = "Produto";
            ProdutosParceirosDataGridView.Columns[4].Width = 260;

            ProdutosParceirosDataGridView.Columns[5].HeaderText = "Preco Venda";
            ProdutosParceirosDataGridView.Columns[5].Width = 110;
            ProdutosParceirosDataGridView.Columns[5].DefaultCellStyle.Format = "R$ 0.00##";

            ProdutosParceirosDataGridView.Columns[6].HeaderText = "Produto Ativo";
            ProdutosParceirosDataGridView.Columns[6].Width = 100;
            ColorirSemEstoque();


        }

        private void AdicionarButton_Click(object sender, EventArgs e)
        {
            ProdutosParceiroForm produtosParceiroForm = new ProdutosParceiroForm(_parceriasService, _produtoService);
            produtosParceiroForm.Id = Convert.ToInt32(Id);
            produtosParceiroForm.Descricao = Descricao;
            produtosParceiroForm.ShowDialog();
        }

        private void RetiradosCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            RecarregaGridVendasProdutos();
        }

        private void VendasProdutosDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = VendasProdutosDataGridView.CurrentRow.Index;
            if (!Convert.ToBoolean(VendasProdutosDataGridView.Rows[row].Cells[6].Value))
            {
                RegistrarRetirada();
            }
            else
            {
                DesmarcarRetirada();
            }
        }

        private void RegistrarRetirada()
        {
            int row = VendasProdutosDataGridView.CurrentRow.Index;
            _vendasPedidoService.RegistrarRetirada(Convert.ToInt32(VendasProdutosDataGridView.Rows[row].Cells[7].Value));
            RecarregaGridVendasProdutos();
            MessageBox.Show("Retirada registrada!", "Atenção!", MessageBoxButtons.OK);

        }

        private void DesmarcarRetirada()
        {
            int row = VendasProdutosDataGridView.CurrentRow.Index;
            _vendasPedidoService.DesmarcarRetirada(Convert.ToInt32(VendasProdutosDataGridView.Rows[row].Cells[7].Value));
            RecarregaGridVendasProdutos();
            MessageBox.Show("Desmarcada retirada!", "Atenção!", MessageBoxButtons.OK);

        }

        private void ColorirSemEstoque()
        {
            foreach (DataGridViewRow row in ProdutosParceirosDataGridView.Rows)
            {
                if (Convert.ToInt32(row.Cells[7].Value) <= 0)
                {
                    row.DefaultCellStyle.BackColor = Color.LightPink;
                }
            }

            foreach (DataGridViewRow row in ProdutosParceirosDataGridView.Rows)
            {
                if (Convert.ToInt32(row.Cells[7].Value) <= 0)
                {
                    row.DefaultCellStyle.BackColor = Color.LightPink;
                }
            }
        }

        private void ColorirRepasseFeito()
        {
            foreach (DataGridViewRow row in EscalasDataGridView.Rows)
            {
                if (Convert.ToBoolean(row.Cells[11].Value))
                {
                    row.DefaultCellStyle.BackColor = Color.DarkSeaGreen;
                }
            }
        }

        private void EscalasDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = EscalasDataGridView.CurrentRow.Index;
            int idParceria = Convert.ToInt32(EscalasDataGridView.Rows[row].Cells[8].Value);
            int idEscala = Convert.ToInt32(EscalasDataGridView.Rows[row].Cells[9].Value);            
            bool repasse = Convert.ToBoolean(EscalasDataGridView.Rows[row].Cells[11].Value);

            if (repasse)
            {
                _parceriasService.DesregistraRepasseParceria(idEscala, idParceria);
                MessageBox.Show("Repasse removido!", "Atenção!", MessageBoxButtons.OK);
            }
            else
            {
                _parceriasService.RegistraRepasseParceria(idEscala, idParceria, true);
                MessageBox.Show("Repasse registrado!", "Atenção!", MessageBoxButtons.OK);
            }  

            RecarregaGridEscalas();
        }
    }
}
