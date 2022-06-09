using LanchoneteUDV.Application.DTO;
using LanchoneteUDV.Application.Interfaces;
using System.Data;
using System.Text.RegularExpressions;

namespace LanchoneteUDV
{
    public partial class EstoqueEscalaForm : Form
    {
        public int IDEscala { get; set; }

        //VendasBLL _bllVendas = new VendasBLL();
        //EstoqueEscalaBLL _bllEstoqueEscala = new EstoqueEscalaBLL();
        Helper _helper = new Helper();
        Regex reg = new Regex(@"^-?\d+[.]?\d*$");

        private readonly IEstoqueEscalaService _estoqueEscalaService;
        private readonly IVendaService _vendasService;


        public EstoqueEscalaForm(IEstoqueEscalaService estoqueEscalaService,IVendaService vendasService)
        {
            _estoqueEscalaService = estoqueEscalaService;
            _vendasService = vendasService;
            InitializeComponent();
        }

        #region Metodos

        private void CarregarCombos()
        {
            var estoque = _estoqueEscalaService.ListarEstoqueComboProdutos(IDEscala);
            ProdutosComboBox.DataSource = estoque;
            ProdutosComboBox.DisplayMember = "DescricaoProduto";
            ProdutosComboBox.ValueMember = "IdProduto";
            ProdutosComboBox.SelectedValue = -1;

            EstoqueComboBox.DataSource = estoque;
            EstoqueComboBox.DisplayMember = "QtdEstoque";

            EstoqueComboBox.ValueMember = "IdProduto";
            EstoqueComboBox.SelectedValue = -1;
        }

        private async void RecarregaGrid()
        {
            EstoqueEscalaDataGridView.DataSource =  _estoqueEscalaService.ListarProdutosEstoqueEscala(IDEscala);
            EstoqueEscalaDataGridView.Columns[0].Visible = false;
            EstoqueEscalaDataGridView.Columns[1].Visible = false;
            EstoqueEscalaDataGridView.Columns[2].Visible = false;

            EstoqueEscalaDataGridView.Columns[3].HeaderText = "Produto";
            EstoqueEscalaDataGridView.Columns[3].Width = 200;

            EstoqueEscalaDataGridView.Columns[4].HeaderText = "Quantidade";

            EstoqueEscalaDataGridView.Columns[4].Width = 200;

            EstoqueEscalaDataGridView.ClearSelection();

        }

        private void LimparCampos()
        {
            IDTextBox.Text = "0";
            ProdutosComboBox.SelectedIndex = -1;
            EstoqueComboBox.SelectedValue = -1;
            QtdVendaTextBox.Clear();
            ObservacaoTextBox.Clear();

        }

        private bool ValidaCamposParaSalvar()
        {
            bool valido = true;

            ValidaComZero(QtdVendaTextBox);

            if (string.IsNullOrEmpty(ProdutosComboBox.Text))
            {
                MessageBox.Show("É necessário selecionar um produto para salvar!", "Atenção!", MessageBoxButtons.OK);
            }

            return valido;
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

        #region Eventos
        private void EstoqueEscalaForm_Load(object sender, EventArgs e)
        {
            CarregarCombos();
            RecarregaGrid();

        }

        private void ProdutosComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            EstoqueComboBox.SelectedValue = ProdutosComboBox.SelectedValue;
            QtdVendaTextBox.Text = EstoqueComboBox.Text;
        }

        private void LimparButton_Click(object sender, EventArgs e)
        {
            _helper.Desabilita(ProdutosComboBox, QtdVendaTextBox, ObservacaoTextBox,
          ExcluirButton, EditarButton, SalvarButton);

            _helper.Habilita(NovoButton);
            LimparCampos();
        }

        private void SalvarButton_Click(object sender, EventArgs e)
        {

            if (!ValidaCamposParaSalvar())
            {
                return;
            }

            var estoqueEscala = new EstoqueEscalaDTO
            {
                Id = Convert.ToInt32(IDTextBox.Text),
                IdProduto = Convert.ToInt32(ProdutosComboBox.SelectedValue),
                QtdVenda = Convert.ToInt32(QtdVendaTextBox.Text),
                Observacao = ObservacaoTextBox.Text,
                IdEscala = IDEscala
            };
            if (estoqueEscala.Id>0)
            {
                _estoqueEscalaService.Update(estoqueEscala);
            }
            else
            {
                _estoqueEscalaService.Add(estoqueEscala);
            }
  
            RecarregaGrid();
            CarregarCombos();
            LimparButton_Click(sender, e);
            MessageBox.Show("Estoque registrado com sucesso!", "Sucesso!", MessageBoxButtons.OK);
        }

        private void EditarButton_Click(object sender, EventArgs e)
        {
            _helper.Habilita(ProdutosComboBox, QtdVendaTextBox, ObservacaoTextBox,
             SalvarButton, LimparButton);
            _helper.Desabilita(EditarButton, ExcluirButton);
        }

        private void ExcluirButton_Click(object sender, EventArgs e)
        {
            EstoqueEscalaDTO estoque = new EstoqueEscalaDTO();


            if (MessageBox.Show("Deseja realmente excluir o item de estoque da escala?", "ATENÇÃO!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _estoqueEscalaService.Remove(Convert.ToInt32(IDTextBox.Text));

                MessageBox.Show("item removido com sucesso!", "Sucesso!", MessageBoxButtons.OK);
                LimparButton_Click(sender, e);
                RecarregaGrid();
                CarregarCombos();
            }
        }

        private void NovoButton_Click(object sender, EventArgs e)
        {
            _helper.Habilita(ProdutosComboBox, QtdVendaTextBox, ObservacaoTextBox, SalvarButton);

            _helper.Desabilita(NovoButton, EditarButton, ExcluirButton);
            LimparCampos();
        }

        #endregion

        private void QtdVendaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) return;
            if (!reg.IsMatch(QtdVendaTextBox.Text.Insert(QtdVendaTextBox.SelectionStart, e.KeyChar.ToString()) + "1")) e.Handled = true;

        }

        private void EstoqueEscalaDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = EstoqueEscalaDataGridView.CurrentRow.Index;

            IDTextBox.Text = EstoqueEscalaDataGridView.Rows[row].Cells[0].Value.ToString();
            ProdutosComboBox.SelectedValue = Convert.ToInt32(EstoqueEscalaDataGridView.Rows[row].Cells[2].Value);
            EstoqueComboBox.SelectedValue = Convert.ToInt32(EstoqueEscalaDataGridView.Rows[row].Cells[2].Value);
            QtdVendaTextBox.Text = EstoqueEscalaDataGridView.Rows[row].Cells[4].Value.ToString();

            ObservacaoTextBox.Text = EstoqueEscalaDataGridView.Rows[row].Cells[5].Value.ToString();

            _helper.Desabilita(ProdutosComboBox,
                              QtdVendaTextBox, SalvarButton);

            _helper.Habilita(ExcluirButton, EditarButton, NovoButton);
        }

        private void CargaCompletaButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente realizar a carga completa do estoque?", "ATENÇÃO!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _estoqueEscalaService.CompletarEstoqueEscala(IDEscala);

                MessageBox.Show("Carga completa realizada!", "Sucesso!", MessageBoxButtons.OK);
                LimparButton_Click(sender, e);
                RecarregaGrid();
                CarregarCombos();
            }
        }
    }
}

