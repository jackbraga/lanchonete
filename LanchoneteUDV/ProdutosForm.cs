using LanchoneteUDV.Application.DTO;
using LanchoneteUDV.Application.Interfaces;
using LanchoneteUDV.Business;


namespace LanchoneteUDV
{

    public partial class ProdutosForm : Form
    {
        Helper _helper = new Helper();
        private readonly IProdutoService _produtoService;
        private readonly ICategoriaService _categoriaService;
        public ProdutosForm(IProdutoService produtoService, ICategoriaService categoriaService)
        {
            _produtoService = produtoService;
            _categoriaService = categoriaService;
            InitializeComponent();

        }

        #region Eventos

        private void ProdutosForm_Load(object sender, EventArgs e)
        {
            //CategoriaComboBox.DataSource = _bll.ListarCategorias();
            CategoriaComboBox.DataSource = _categoriaService.GetCategorias().ToList();
            CategoriaComboBox.DisplayMember = "Descricao";
            CategoriaComboBox.ValueMember = "ID";
            CategoriaComboBox.SelectedIndex = -1;

            RecarregaGrid();
        }

        private void CustoCaixaTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void QtdCaixaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void PrecoCustoUnitarioTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void EstoqueInicialTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
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

        private void SalvarButton_Click(object sender, EventArgs e)
        {
       
            //produto.ID = Convert.ToInt32(IdTextBox.Text);

            if (!ValidaCamposParaSalvar())
            {
                return;
            }

            ValidaComZero(QtdCaixaTextBox, EstoqueInicialTextBox, CategoriaComboBox, PrecoCustoCaixaTextBox, PrecoCustoUnitarioTextBox, PrecoVendaTextBox
                , ProdutoVendaCheckBox);


            var produto = new ProdutoDTO
            {
                Id = Convert.ToInt32(IdTextBox.Text),
                CategoriaId = (Int32)CategoriaComboBox.SelectedValue,
                Descricao = DescricaoTextBox.Text.Trim(),
                EstoqueInicial = Convert.ToInt32(EstoqueInicialTextBox.Text),
                PrecoCustoCaixa = Double.Parse(PrecoCustoCaixaTextBox.Text),
                PrecoCustoUnitario = Double.Parse(PrecoCustoUnitarioTextBox.Text),
                PrecoVenda = Double.Parse(PrecoVendaTextBox.Text),
                ProdutoVenda = Convert.ToBoolean(ProdutoVendaCheckBox.Checked),
                QtdPorCaixa = Convert.ToInt32(QtdCaixaTextBox.Text)
            };


            if (produto.Id > 0)
            {
                _produtoService.Update(produto);
            }
            else
            {
                _produtoService.Add(produto);
            }

            RecarregaGrid();
            LimparButton_Click(sender, e);
            MessageBox.Show("Produto registrado com sucesso!", "Sucesso!", MessageBoxButtons.OK);

        }

        private bool ValidaCamposParaSalvar()
        {
            bool valido = true;
            ValidaComZero(PrecoVendaTextBox, PrecoCustoUnitarioTextBox, PrecoCustoCaixaTextBox,
                QtdCaixaTextBox, EstoqueInicialTextBox);
            if (string.IsNullOrEmpty(DescricaoTextBox.Text))
            {
                valido = false;
                MessageBox.Show("É necessário definir uma descrição para o Produto!", "Atenção!", MessageBoxButtons.OK);
            }
            else if (string.IsNullOrEmpty(CategoriaComboBox.Text))
            {
                valido = false;
                MessageBox.Show("É necessário definir uma categoria para o Produto!", "Atenção!", MessageBoxButtons.OK);
            }
            else if (string.IsNullOrEmpty(CategoriaComboBox.Text))
            {
                valido = false;
                MessageBox.Show("É necessário definir uma categoria para o Produto!", "Atenção!", MessageBoxButtons.OK);
            }

            return valido;
        }

        private void EditarButton_Click(object sender, EventArgs e)
        {
            _helper.Habilita(DescricaoTextBox, CategoriaComboBox, PrecoCustoUnitarioTextBox, PrecoCustoCaixaTextBox,
                QtdCaixaTextBox, PrecoVendaTextBox, EstoqueInicialTextBox, SalvarButton, LimparButton, ProdutoVendaCheckBox);
            _helper.Desabilita(EditarButton, ExcluirButton);
        }

        private void LimparButton_Click(object sender, EventArgs e)
        {
            _helper.Desabilita(DescricaoTextBox, CategoriaComboBox, PrecoCustoCaixaTextBox, PrecoCustoUnitarioTextBox,
                            QtdCaixaTextBox, PrecoVendaTextBox, EstoqueInicialTextBox, ProdutoVendaCheckBox,
                ExcluirButton, EditarButton, SalvarButton);

            _helper.Habilita(NovoButton);
            LimparCampos();
        }

        private void NovoButton_Click(object sender, EventArgs e)
        {
            _helper.Habilita(DescricaoTextBox, CategoriaComboBox, PrecoCustoCaixaTextBox, QtdCaixaTextBox,
     PrecoCustoUnitarioTextBox, PrecoVendaTextBox, EstoqueInicialTextBox, ProdutoVendaCheckBox, SalvarButton);

            _helper.Desabilita(NovoButton, EditarButton, ExcluirButton);
            LimparCampos();
        }

        private void ProdutosDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = ProdutosDataGridView.CurrentRow.Index;

            IdTextBox.Text = ProdutosDataGridView.Rows[row].Cells[0].Value.ToString();
            DescricaoTextBox.Text = ProdutosDataGridView.Rows[row].Cells[1].Value.ToString();
            CategoriaComboBox.SelectedValue = ProdutosDataGridView.Rows[row].Cells[2].Value;
            PrecoCustoCaixaTextBox.Text = String.Format("{0:N2}", double.Parse(ProdutosDataGridView.Rows[row].Cells[4].Value.ToString()));
            QtdCaixaTextBox.Text = ProdutosDataGridView.Rows[row].Cells[5].Value.ToString();
            PrecoCustoUnitarioTextBox.Text = String.Format("{0:N2}", double.Parse(ProdutosDataGridView.Rows[row].Cells[6].Value.ToString()));
            PrecoVendaTextBox.Text = String.Format("{0:N2}", double.Parse(ProdutosDataGridView.Rows[row].Cells[7].Value.ToString()));
            EstoqueInicialTextBox.Text = ProdutosDataGridView.Rows[row].Cells[8].Value.ToString();
            ProdutoVendaCheckBox.Checked = Convert.ToBoolean(ProdutosDataGridView.Rows[row].Cells[9].Value);


            _helper.Desabilita(DescricaoTextBox, CategoriaComboBox, PrecoCustoCaixaTextBox, PrecoCustoUnitarioTextBox,
                            QtdCaixaTextBox, PrecoVendaTextBox, EstoqueInicialTextBox, ProdutoVendaCheckBox
                            , SalvarButton);

            _helper.Habilita(ExcluirButton, EditarButton, NovoButton);
        }


        private void PesquisaTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            //ProdutosDataGridView.DataSource = _bllProdutos.PesquisarProduto(PesquisaTextBox.Text);
            RecarregaGrid(PesquisaTextBox.Text);
        }

        #endregion

        #region Métodos

        private void LimparCampos()
        {
            IdTextBox.Text = "0";
            DescricaoTextBox.Clear();
            CategoriaComboBox.SelectedIndex = -1;
            PrecoCustoCaixaTextBox.Text = "0";
            QtdCaixaTextBox.Text = "0";
            PrecoCustoUnitarioTextBox.Text = "0";
            PrecoVendaTextBox.Text = "0";
            EstoqueInicialTextBox.Text = "0";
            ProdutoVendaCheckBox.Checked = false;
        }

        private void RecarregaGrid()
        {
            ProdutosDataGridView.DataSource = _produtoService.GetAll();
            FormatarGrid();
        }
        private void RecarregaGrid(string pesquisa)
        {
            ProdutosDataGridView.DataSource = _produtoService.GetByName(pesquisa);
            FormatarGrid();
        }

        private void FormatarGrid() 
        {
            ProdutosDataGridView.Columns[0].Visible = false;
            ProdutosDataGridView.Columns[2].Visible = false;
            ProdutosDataGridView.Columns[1].Width = 230;
            ProdutosDataGridView.Columns[4].HeaderText = "Custo Caixa";
            ProdutosDataGridView.Columns[4].DefaultCellStyle.Format = "R$ 0.00##";
            ProdutosDataGridView.Columns[5].HeaderText = "Qtd na Caixa";
            ProdutosDataGridView.Columns[6].HeaderText = "Custo Unitário";
            ProdutosDataGridView.Columns[6].DefaultCellStyle.Format = "R$ 0.00##";
            ProdutosDataGridView.Columns[7].HeaderText = "Valor Venda";
            ProdutosDataGridView.Columns[7].DefaultCellStyle.Format = "R$ 0.00##";
            ProdutosDataGridView.Columns[8].HeaderText = "Estoque Inicial";
            ProdutosDataGridView.Columns[9].HeaderText = "Produto de Venda";
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
    }
}
