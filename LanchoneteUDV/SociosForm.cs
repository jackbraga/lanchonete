﻿using LanchoneteUDV.Application.DTO;
using LanchoneteUDV.Application.Interfaces;


namespace LanchoneteUDV
{
    public partial class SociosForm : Form
    {
        Helper _helper = new Helper();

        private readonly ISocioService _socioService;

        public SociosForm(ISocioService socioService)
        {
            _socioService = socioService;
            InitializeComponent();
        }

        private void SociosForm_Load(object sender, EventArgs e)
        {
            Controls.Clear();
            InitializeComponent();
            RecarregaGrid();
            CarregarCombos();

        }

        private void CarregarCombos()
        {
            ResponsavelFinanceiroComboBox.DataSource = _socioService.GetAll();
            ResponsavelFinanceiroComboBox.DisplayMember = "Nome";
            ResponsavelFinanceiroComboBox.ValueMember = "ID";
            ResponsavelFinanceiroComboBox.SelectedValue = -1;
        }

        private void SociosDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = SociosDataGridView.CurrentRow.Index;

            IdTextBox.Text = SociosDataGridView.Rows[row].Cells[0].Value.ToString();
            NomeTextBox.Text = SociosDataGridView.Rows[row].Cells[1].Value.ToString();
            EmailTextBox.Text = SociosDataGridView.Rows[row].Cells[2].Value.ToString();
            ResponsavelFinanceiroComboBox.SelectedValue = Convert.ToInt32(SociosDataGridView.Rows[row].Cells[3].Value);
            _helper.Desabilita(NomeTextBox, IdTextBox, SalvarButton, NovoButton);
            _helper.Habilita(ExcluirButton, EditarButton);
        }
        private void LimparButton_Click(object sender, EventArgs e)
        {
            IdTextBox.Text = "0";
            NomeTextBox.Text = "";
            EmailTextBox.Text = "";
            ResponsavelFinanceiroComboBox.SelectedIndex = -1;
            _helper.Habilita(NovoButton);
            _helper.Desabilita(ExcluirButton, EditarButton, SalvarButton, NomeTextBox, EmailTextBox, ResponsavelFinanceiroComboBox);
        }

        private void SalvarButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(NomeTextBox.Text))
            {
                var socio = new SocioDTO
                {
                    Id = Convert.ToInt32(IdTextBox.Text),
                    Nome = NomeTextBox.Text.ToUpper().Trim(),
                    Email = EmailTextBox.Text.Trim(),
                    TipoSocio = 1,
                    ResponsavelFinanceiro = Convert.ToInt32(ResponsavelFinanceiroComboBox.SelectedValue)
                };

                if (socio.Id > 0)
                {
                    _socioService.Update(socio);
                }
                else
                {
                    _socioService.Add(socio);
                }

                RecarregaGrid();
                LimparButton_Click(sender, e);
                MessageBox.Show("Sócio registrado com sucesso!", "Sucesso!", MessageBoxButtons.OK);
            }
        }

        private void EditarButton_Click(object sender, EventArgs e)
        {
            _helper.Habilita(NomeTextBox, EmailTextBox, SalvarButton, ResponsavelFinanceiroComboBox);
            _helper.Desabilita(EditarButton, NovoButton);
        }

        private void SociosForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }



        private void ExcluirButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir o Socio: " + NomeTextBox.Text, "ATENÇÃO!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _socioService.Remove(Convert.ToInt32(IdTextBox.Text));
                MessageBox.Show("Sócio removido com sucesso!", "Sucesso!", MessageBoxButtons.OK);
                RecarregaGrid();
            }
        }

        private void NovoButton_Click(object sender, EventArgs e)
        {
            LimparButton_Click(sender, e);
            _helper.Habilita(NomeTextBox, EmailTextBox, SalvarButton);
            _helper.Desabilita(NovoButton, ExcluirButton, EditarButton, ResponsavelFinanceiroComboBox);
        }

        private void RecarregaGrid()
        {
            SociosDataGridView.DataSource = _socioService.GetAll();
            FormatarGrid();
        }
        private void RecarregaGrid(string texto)
        {
            SociosDataGridView.DataSource = _socioService.GetByName(texto);
            FormatarGrid();
        }

        private void FormatarGrid()
        {
            SociosDataGridView.Columns[0].Visible = false;
            SociosDataGridView.Columns[1].MinimumWidth = 190;
            SociosDataGridView.Columns[2].MinimumWidth = 190;
            SociosDataGridView.Columns[3].Visible = false;
            SociosDataGridView.Columns[4].HeaderText = "Financeiro";
            SociosDataGridView.Columns[4].MinimumWidth = 190;
            SociosDataGridView.Columns[5].Visible = false;
        }

        private void PesquisaTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            RecarregaGrid(PesquisaTextBox.Text);
        }
    }
}
