using LanchoneteUDV.Application.DTO;
using LanchoneteUDV.Application.Interfaces;
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
    public partial class ProdutosParceiroForm : Form
    {
        Helper _helper = new Helper();
        public int Id;
        public string Descricao;


        private readonly IParceriasService _parceriasService;
        private readonly IProdutoService _produtoService;
        public ProdutosParceiroForm(IParceriasService parceriasService, IProdutoService produtoService)
        {
            _parceriasService = parceriasService;
            InitializeComponent();
            _produtoService = produtoService;
        }

        #region Eventos


        private void SalvarButton_Click(object sender, EventArgs e)
        {
            if (!ValidaCamposParaSalvar())
            {
                return;
            }

            ValidaComZero(PrecoVendaTextBox);


            var produto = new ProdutoDTO
            {
                Id = Convert.ToInt32(IdTextBox.Text),
                CategoriaId = 16,
                Descricao = DescricaoTextBox.Text.Trim(),
                PrecoVenda = Double.Parse(PrecoVendaTextBox.Text),
                ProdutoVenda = ProdutoVendaCheckBox.Checked

            };


            if (produto.Id > 0)
            {
                _produtoService.Update(produto);
            }
            else
            {
                var retorno = _produtoService.Add(produto);
                var produtoParceria = new ParceriasProdutoDTO
                {
                    IDParceria = Id,
                    IDProduto = retorno.Id
                };
                _parceriasService.AdicionaProdutoParceria(produtoParceria);
            }

            RecarregaGrid();
            LimparButton_Click(sender, e);
            MessageBox.Show("Produto registrado com sucesso!", "Sucesso!", MessageBoxButtons.OK);

        }

        private bool ValidaCamposParaSalvar()
        {
            bool valido = true;
            ValidaComZero(PrecoVendaTextBox);
            if (string.IsNullOrEmpty(DescricaoTextBox.Text))
            {
                valido = false;
                MessageBox.Show("É necessário definir uma descrição para o Produto!", "Atenção!", MessageBoxButtons.OK);
            }

            return valido;
        }

        private void EditarButton_Click(object sender, EventArgs e)
        {
            _helper.Habilita(DescricaoTextBox,
                 PrecoVendaTextBox, SalvarButton, LimparButton, ProdutoVendaCheckBox);
            _helper.Desabilita(EditarButton, ExcluirButton);
        }

        private void LimparButton_Click(object sender, EventArgs e)
        {
            _helper.Desabilita(DescricaoTextBox,
                             PrecoVendaTextBox, ProdutoVendaCheckBox,
                ExcluirButton, EditarButton, SalvarButton);

            _helper.Habilita(NovoButton);
            LimparCampos();
        }

        private void NovoButton_Click(object sender, EventArgs e)
        {
            _helper.Habilita(DescricaoTextBox,
      PrecoVendaTextBox, ProdutoVendaCheckBox, SalvarButton);

            _helper.Desabilita(NovoButton, EditarButton, ExcluirButton);
            LimparCampos();
        }

        private void ProdutosDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = ProdutosParceirosDataGridView.CurrentRow.Index;

            IdTextBox.Text = ProdutosParceirosDataGridView.Rows[row].Cells[0].Value.ToString();
            DescricaoTextBox.Text = ProdutosParceirosDataGridView.Rows[row].Cells[1].Value.ToString();
            PrecoVendaTextBox.Text = String.Format("{0:N2}", double.Parse(ProdutosParceirosDataGridView.Rows[row].Cells[7].Value.ToString()));

            _helper.Desabilita(DescricaoTextBox,
                             PrecoVendaTextBox, ProdutoVendaCheckBox
                            , SalvarButton);

            _helper.Habilita(ExcluirButton, EditarButton, NovoButton);
        }


        private void PesquisaTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            RecarregaGrid(PesquisaTextBox.Text);
        }

        #endregion

        #region Métodos

        private void LimparCampos()
        {
            IdTextBox.Text = "0";
            DescricaoTextBox.Clear();
            PrecoVendaTextBox.Text = "0";
            ProdutoVendaCheckBox.Checked = false;
        }

        private void RecarregaGrid()
        {
            ProdutosParceirosDataGridView.DataSource = _parceriasService.BuscarProdutosParceria(Id);
            FormatarGrid();
        }
        private void RecarregaGrid(string pesquisa)
        {
            FormatarGrid();
        }

        private void FormatarGrid()
        {
            ProdutosParceirosDataGridView.Columns[0].Visible = false;
            ProdutosParceirosDataGridView.Columns[1].Visible = false;
            ProdutosParceirosDataGridView.Columns[2].Visible = false;
            ProdutosParceirosDataGridView.Columns[3].Visible = false;

            ProdutosParceirosDataGridView.Columns[4].HeaderText = "Produto";
            ProdutosParceirosDataGridView.Columns[4].Width = 230;

            ProdutosParceirosDataGridView.Columns[5].HeaderText = "Preco Venda";
            ProdutosParceirosDataGridView.Columns[5].Width = 150;
            ProdutosParceirosDataGridView.Columns[5].DefaultCellStyle.Format = "R$ 0.00##";

            ProdutosParceirosDataGridView.Columns[6].HeaderText = "Produto Ativo";
            ProdutosParceirosDataGridView.Columns[6].Width = 230;
        }

        public void ValidaComZero(params Object[] objetos)
        {

            foreach (Control item in objetos)
            {
                if (string.IsNullOrEmpty(item.Text))
                {
                    item.Text = "0";
                }
            }
        }

        #endregion

        private void ExcluirButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir esse produto?", "ATENÇÃO!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _produtoService.Remove(Convert.ToInt32(IdTextBox.Text));

                MessageBox.Show("Produto removido com sucesso!", "Sucesso!", MessageBoxButtons.OK);
                LimparButton_Click(sender, e);
                RecarregaGrid();
            }
        }

        private void ProdutosParceiroForm_Load(object sender, EventArgs e)
        {
            groupBox1.Text = $"Produtos da parceira {Descricao.ToUpper()}";
            RecarregaGrid();
        }

        private void ProdutosParceirosDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            int row = ProdutosParceirosDataGridView.CurrentRow.Index;

            IdTextBox.Text = ProdutosParceirosDataGridView.Rows[row].Cells[3].Value.ToString();
            DescricaoTextBox.Text = ProdutosParceirosDataGridView.Rows[row].Cells[4].Value.ToString();
            PrecoVendaTextBox.Text = String.Format("{0:N2}", double.Parse(ProdutosParceirosDataGridView.Rows[row].Cells[5].Value.ToString()));
            ProdutoVendaCheckBox.Checked = Convert.ToBoolean(ProdutosParceirosDataGridView.Rows[row].Cells[6].Value);

            _helper.Desabilita(DescricaoTextBox, IdTextBox, PrecoVendaTextBox,
                 SalvarButton, NovoButton);
            _helper.Habilita(ExcluirButton, EditarButton);
        }

        private void PrecoVendaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }


    }
}
