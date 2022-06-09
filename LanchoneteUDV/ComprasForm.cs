using LanchoneteUDV.Application.DTO;
using LanchoneteUDV.Application.Interfaces;
using System.Text.RegularExpressions;

namespace LanchoneteUDV
{

    public partial class ComprasForm : Form
    {
        Helper _helper = new Helper();
        Regex reg = new Regex(@"^-?\d+[.]?\d*$");

        private readonly ICompraService _compraService;
        private readonly IProdutoService _produtoService;

        public ComprasForm(ICompraService compraService,IProdutoService produtoService)
        {
            _compraService = compraService;
            _produtoService = produtoService;
            InitializeComponent();

        }

        #region Eventos

        private void ComprasForm_Load(object sender, EventArgs e)
        {
            ProdutoComboBox.DataSource = _produtoService.GetAll();//_bllCompras.ListarProdutos();
            ProdutoComboBox.DisplayMember = "Descricao";
            ProdutoComboBox.ValueMember = "ID";
            ProdutoComboBox.SelectedValue = -1;
            FiltroComboBox.SelectedIndex = 0;

            RecarregaGrid();
        }

        private void PrecoTextBox_KeyPress(object sender, KeyPressEventArgs e)
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


        private void QuantidadeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) return;
            if (!reg.IsMatch(QuantidadeTextBox.Text.Insert(QuantidadeTextBox.SelectionStart, e.KeyChar.ToString()) + "1")) e.Handled = true;
            //if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            //{
            //    e.Handled = true;
            //}
        }

        private void ExcluirButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir o registro de compra?", "ATENÇÃO!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _compraService.Remove(Convert.ToInt32(IdTextBox.Text));
                //_bllCompras.ExcluirCompra(new CompraDTO { ID = Convert.ToInt32(IdTextBox.Text) });
                MessageBox.Show("Sócio removido com sucesso!", "Sucesso!", MessageBoxButtons.OK);
                LimparButton_Click(sender, e);
                RecarregaGrid();
            }
        }

        private void SalvarButton_Click(object sender, EventArgs e)
        {
            if (!ValidaCamposParaSalvar())
            {
                return;
            }

            var compra = new CompraDTO
            {
                Id = Convert.ToInt32(IdTextBox.Text),
                Quantidade = Convert.ToInt32(QuantidadeTextBox.Text),
                CompradoPor = CompradoPorTextBox.Text,
                DataCompra = DataCompraDateTimePicker.Value.Date,
                IdProduto = Convert.ToInt32(ProdutoComboBox.SelectedValue),
                PrecoUnitario = Double.Parse(PrecoTextBox.Text),
                DescricaoProduto = ProdutoComboBox.Text,
                TipoEntrada = TipoEntradaComboBox.Text,
                Observacao = ObservacaoTextBox.Text.Trim()
            };

            if (compra.Id>0)
            {
                _compraService.Update(compra);
            }
            else
            {
                _compraService.Add(compra);
            }

            RecarregaGrid();
            LimparButton_Click(sender, e);
            MessageBox.Show("Compra registrada com sucesso!", "Sucesso!", MessageBoxButtons.OK);

        }

        private void EditarButton_Click(object sender, EventArgs e)
        {
            _helper.Habilita(DataCompraDateTimePicker, ProdutoComboBox, CompradoPorTextBox, PrecoTextBox,
                QuantidadeTextBox, ObservacaoTextBox, TipoEntradaComboBox, SalvarButton, LimparButton);
            _helper.Desabilita(EditarButton, ExcluirButton);
        }

        private void LimparButton_Click(object sender, EventArgs e)
        {
            _helper.Desabilita(ProdutoComboBox, PrecoTextBox, CompradoPorTextBox,
                              QuantidadeTextBox, DataCompraDateTimePicker, ObservacaoTextBox, TipoEntradaComboBox,
                ExcluirButton, EditarButton, SalvarButton);

            _helper.Habilita(NovoButton);
            LimparCampos();
            CompradoPorTextBox.Clear();
        }

        private void NovoButton_Click(object sender, EventArgs e)
        {


            _helper.Habilita(DataCompraDateTimePicker, ProdutoComboBox, PrecoTextBox, QuantidadeTextBox, ObservacaoTextBox, TipoEntradaComboBox,
     CompradoPorTextBox, SalvarButton);

            _helper.Desabilita(NovoButton, EditarButton, ExcluirButton);
            LimparCampos();


        }

        private void ComprasDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = ComprasDataGridView.CurrentRow.Index;

            IdTextBox.Text = ComprasDataGridView.Rows[row].Cells[0].Value.ToString();

            DataCompraDateTimePicker.Value = Convert.ToDateTime(ComprasDataGridView.Rows[row].Cells[1].Value);
            ProdutoComboBox.SelectedValue = (Int32)ComprasDataGridView.Rows[row].Cells[6].Value;
            QuantidadeTextBox.Text = ComprasDataGridView.Rows[row].Cells[3].Value.ToString();
            PrecoTextBox.Text = String.Format("{0:N2}", double.Parse(ComprasDataGridView.Rows[row].Cells[4].Value.ToString()));
            CompradoPorTextBox.Text = ComprasDataGridView.Rows[row].Cells[5].Value.ToString();
            TipoEntradaComboBox.Text = ComprasDataGridView.Rows[row].Cells[7].Value.ToString();
            ObservacaoTextBox.Text = ComprasDataGridView.Rows[row].Cells[8].Value.ToString();

            _helper.Desabilita(DataCompraDateTimePicker, ProdutoComboBox, PrecoTextBox, CompradoPorTextBox,
                              QuantidadeTextBox, SalvarButton);

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
            ProdutoComboBox.SelectedIndex = -1;
            PrecoTextBox.Clear();
            QuantidadeTextBox.Clear();
            ObservacaoTextBox.Clear();
            TipoEntradaComboBox.SelectedIndex = -1;
            CompradoPorTextBox.Clear();


            if (FixarNomecheckBox.Checked)
            {
                CompradoPorTextBox.Text = NomeLabel.Text;
            }
        }

        private void RecarregaGrid()
        {
            ComprasDataGridView.DataSource = _compraService.GetAll();
            FormatarGrid();
        }
        private void RecarregaGrid(string texto)
        {
            ComprasDataGridView.DataSource = _compraService.GetByName(texto);
            FormatarGrid();
        }

        private void FormatarGrid()
        {
            ComprasDataGridView.Columns[0].Visible = false;
            ComprasDataGridView.Columns[6].Visible = false;
            ComprasDataGridView.Columns[1].HeaderText = "Data da Compra";
            ComprasDataGridView.Columns[2].HeaderText = "Descrição";
            ComprasDataGridView.Columns[2].Width = 230;
            ComprasDataGridView.Columns[3].HeaderText = "Quantidade";
            ComprasDataGridView.Columns[4].HeaderText = "Preço Unitário";
            ComprasDataGridView.Columns[4].DefaultCellStyle.Format = "R$ 0.00##";
            ComprasDataGridView.Columns[5].HeaderText = "Comprado Por";
            ComprasDataGridView.Columns[7].HeaderText = "Tipo de Entrada";
            ComprasDataGridView.Columns[8].HeaderText = "Observacao";
            ComprasDataGridView.Columns[8].Width = 230;
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

        private bool ValidaCamposParaSalvar()
        {
            bool valido = true;

            ValidaComZero(QuantidadeTextBox, PrecoTextBox);

            if (DataCompraDateTimePicker.Value.Date > DateTime.Now.Date)
            {
                valido = false;
            }

            else if (TipoEntradaComboBox.Text != "Ajuste no Estoque" && Convert.ToInt32(QuantidadeTextBox.Text) <= 0)
            {
                MessageBox.Show("Quantidade deve ser no mínimo 1!", "Atenção!", MessageBoxButtons.OK);
                valido = false;
            }
            else if (string.IsNullOrEmpty(ProdutoComboBox.Text))
            {
                MessageBox.Show("É necessário informar um produto!", "Atenção!", MessageBoxButtons.OK);
                valido = false;
            }
            else if (string.IsNullOrEmpty(TipoEntradaComboBox.Text))
            {
                MessageBox.Show("É necessário informar um tipo de entrada!", "Atenção!", MessageBoxButtons.OK);
                valido = false;
            }


            return valido;
        }


        #endregion


    }
}
