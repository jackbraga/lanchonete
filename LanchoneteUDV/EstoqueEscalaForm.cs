using LanchoneteUDV.Business;
using LanchoneteUDV.DataObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LanchoneteUDV
{
    public partial class EstoqueEscalaForm : Form
    {
        public int IDEscala { get; set; }

        VendasBLL _bllVendas = new VendasBLL();
        EstoqueEscalaBLL _bllEstoqueEscala = new EstoqueEscalaBLL();
        Helper _helper = new Helper();
        Regex reg = new Regex(@"^-?\d+[.]?\d*$");
        public EstoqueEscalaForm()
        {
            InitializeComponent();
        }

        #region Metodos

        private void CarregarCombos()
        {
            //SocioComboBox.DataSource = _bllSocios.ListarSocios();
            //SocioComboBox.DisplayMember = "Nome";
            //SocioComboBox.ValueMember = "ID";
            //SocioComboBox.SelectedValue = -1;

            DataTable dt = new DataTable();

            dt = _bllVendas.ListarEstoque();
            ProdutosComboBox.DataSource = dt;
            ProdutosComboBox.DisplayMember = "Descricao";
            ProdutosComboBox.ValueMember = "ID";
            ProdutosComboBox.SelectedValue = -1;

            EstoqueComboBox.DataSource = dt;
            EstoqueComboBox.DisplayMember = "Estoque";

            EstoqueComboBox.ValueMember = "ID";
            EstoqueComboBox.SelectedValue = -1;
        }

        private void RecarregaGrid()
        {
            EstoqueEscalaDataGridView.DataSource = _bllEstoqueEscala.ListarEstoqueEscala(IDEscala);
            EstoqueEscalaDataGridView.Columns[0].Visible = false;

            EstoqueEscalaDataGridView.Columns[1].Visible = false;

            EstoqueEscalaDataGridView.Columns[2].HeaderText = "Produto";
            EstoqueEscalaDataGridView.Columns[2].Width = 200;

            EstoqueEscalaDataGridView.Columns[3].HeaderText = "Quantidade";

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

            EstoqueEscalaDTO estoqueEscala = new EstoqueEscalaDTO();

            estoqueEscala.ID = Convert.ToInt32(IDTextBox.Text);

            if (!ValidaCamposParaSalvar())
            {
                return;
            }

            estoqueEscala.IDProduto = Convert.ToInt32(ProdutosComboBox.SelectedValue);
            estoqueEscala.QtdVenda = Convert.ToInt32(QtdVendaTextBox.Text);
            estoqueEscala.Observacao = ObservacaoTextBox.Text;
            estoqueEscala.IDEscala = IDEscala;

            _bllEstoqueEscala.SalvarEstoqueEscala(estoqueEscala);


            RecarregaGrid();
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
                estoque.ID = Convert.ToInt32(IDTextBox.Text);
                estoque.QtdVenda = Convert.ToInt32(QtdVendaTextBox.Text);
                estoque.IDProduto = Convert.ToInt32(ProdutosComboBox.SelectedValue);
                estoque.Observacao = ObservacaoTextBox.Text;



                _bllEstoqueEscala.ExcluirEstoqueEscala(estoque);
                MessageBox.Show("item removido com sucesso!", "Sucesso!", MessageBoxButtons.OK);
                LimparButton_Click(sender, e);
                RecarregaGrid();
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
            ProdutosComboBox.SelectedValue = Convert.ToInt32(EstoqueEscalaDataGridView.Rows[row].Cells[1].Value);
            EstoqueComboBox.SelectedValue = Convert.ToInt32(EstoqueEscalaDataGridView.Rows[row].Cells[1].Value);
            QtdVendaTextBox.Text = EstoqueEscalaDataGridView.Rows[row].Cells[3].Value.ToString();

            ObservacaoTextBox.Text = EstoqueEscalaDataGridView.Rows[row].Cells[4].Value.ToString();


            _helper.Desabilita( ProdutosComboBox, 
                              QtdVendaTextBox, SalvarButton);

            _helper.Habilita(ExcluirButton, EditarButton, NovoButton);
        }
    }
}

