using LanchoneteUDV.Application.DTO;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LanchoneteUDV
{
    public partial class ParceirosForm : Form
    {

        Helper _helper = new Helper();

        private readonly IParceriasService _parceriasService;
        private readonly IProdutoService _produtoService;
        private readonly IVendasPedidoService _vendasPedidoService;

        public ParceirosForm(IParceriasService parceriasService, IProdutoService produtoService,IVendasPedidoService vendasPedidoService)
        {
            _parceriasService = parceriasService;
            InitializeComponent();
            _produtoService = produtoService;
            _vendasPedidoService = vendasPedidoService;
        }

        private void RecarregaGrid()
        {
            ParceirosDataGridView.DataSource = _parceriasService.GetAll();
            FormatarGrid();
        }
        private void RecarregaGrid(string texto)
        {
            ParceirosDataGridView.DataSource = _parceriasService.GetByName(texto);
            FormatarGrid();
        }

        private void FormatarGrid()
        {
            ParceirosDataGridView.Columns[0].Visible = false;
            ParceirosDataGridView.Columns[1].MinimumWidth = 190;
            ParceirosDataGridView.Columns[2].MinimumWidth = 190;
            ParceirosDataGridView.Columns[3].HeaderText = "Tipo de Comissão";
            ParceirosDataGridView.Columns[4].Visible = false;
            ParceirosDataGridView.Columns[5].HeaderText = "Valor";

        }

        private void ParceirosForm_Load(object sender, EventArgs e)
        {
            RecarregaGrid();
        }

        private void NovoButton_Click(object sender, EventArgs e)
        {
            LimparButton_Click(sender, e);
            _helper.Habilita(DescricaoTextBox, ResponsavelTextBox, ComissaoPercentRadioButton,
                ComissaoReaisRadioButton, ValorTextBox, SalvarButton);
            _helper.Desabilita(NovoButton, ExcluirButton, EditarButton, AbrirParceiroButton);
        }

        private void LimparButton_Click(object sender, EventArgs e)
        {
            IdTextBox.Text = "0";
            DescricaoTextBox.Text = "";
            ResponsavelTextBox.Text = "";
            ComissaoPercentRadioButton.Checked = false;
            ComissaoReaisRadioButton.Checked = false;
            ValorTextBox.Text = "";

            _helper.Habilita(NovoButton);
            _helper.Desabilita(ExcluirButton, EditarButton, SalvarButton,
                DescricaoTextBox, ResponsavelTextBox, ValorTextBox, ComissaoPercentRadioButton, ComissaoReaisRadioButton);
        }

        private void SalvarButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(DescricaoTextBox.Text))
            {
                var parceiro = new ParceriasDTO
                {
                    ID = Convert.ToInt32(IdTextBox.Text),
                    Descricao = DescricaoTextBox.Text.ToUpper().Trim(),
                    Responsavel = ResponsavelTextBox.Text.Trim(),
                    TipoComissao = ComissaoReaisRadioButton.Checked ? 1 : 2,
                    Comissao = Convert.ToDouble(ValorTextBox.Text),

                };

                if (parceiro.ID > 0)
                {
                    _parceriasService.Update(parceiro);
                }
                else
                {
                    _parceriasService.Add(parceiro);
                }

                RecarregaGrid();
                LimparButton_Click(sender, e);
                MessageBox.Show("Parceiro registrado com sucesso!", "Sucesso!", MessageBoxButtons.OK);
            }
        }

        private void EditarButton_Click(object sender, EventArgs e)
        {
            _helper.Habilita(DescricaoTextBox, ResponsavelTextBox, SalvarButton, ComissaoPercentRadioButton, ComissaoReaisRadioButton, ValorTextBox);
            _helper.Desabilita(EditarButton, NovoButton);
        }

        private void ExcluirButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir o Parceiro: " + DescricaoTextBox.Text, "ATENÇÃO!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _parceriasService.Remove(Convert.ToInt32(IdTextBox.Text));
                MessageBox.Show("Parceiro removido com sucesso!", "Sucesso!", MessageBoxButtons.OK);
                RecarregaGrid();
            }
        }

        private void ParceirosDataGridView_DoubleClick(object sender, EventArgs e)
        {



        }

        private void AbrirParceiroButton_Click(object sender, EventArgs e)
        {

            VendasParceriasForm vendasParceiro = new VendasParceriasForm(_produtoService, _parceriasService,_vendasPedidoService);
            vendasParceiro.Id = Convert.ToInt32(IdTextBox.Text);
            vendasParceiro.Descricao = DescricaoTextBox.Text;
            vendasParceiro.ShowDialog();



            //ProdutosParceiroForm produtosParceiroForm = new ProdutosParceiroForm(_parceriasService, _produtoService);
            //produtosParceiroForm.Id = Convert.ToInt32(IdTextBox.Text);
            //produtosParceiroForm.Descricao = DescricaoTextBox.Text;
            //produtosParceiroForm.ShowDialog();
        }

        private void ParceirosDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int row = ParceirosDataGridView.CurrentRow.Index;

            IdTextBox.Text = ParceirosDataGridView.Rows[row].Cells[0].Value.ToString();
            DescricaoTextBox.Text = ParceirosDataGridView.Rows[row].Cells[1].Value.ToString();
            ResponsavelTextBox.Text = ParceirosDataGridView.Rows[row].Cells[2].Value.ToString();
            ValorTextBox.Text = ParceirosDataGridView.Rows[row].Cells[5].Value.ToString();

            if (Convert.ToInt32(ParceirosDataGridView.Rows[row].Cells[4].Value) == 1)
            {
                ComissaoReaisRadioButton.Checked = true;
                ComissaoPercentRadioButton.Checked = false;
            }
            else
            {
                ComissaoReaisRadioButton.Checked = false;
                ComissaoPercentRadioButton.Checked = true;
            }


            _helper.Desabilita(DescricaoTextBox, IdTextBox,
                ComissaoPercentRadioButton, ResponsavelTextBox, ComissaoReaisRadioButton, ValorTextBox, SalvarButton, NovoButton);
            _helper.Habilita(ExcluirButton, EditarButton, AbrirParceiroButton);

        }

        private void ParceirosDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AbrirParceiroButton_Click(sender, e);
        }
    }
}
