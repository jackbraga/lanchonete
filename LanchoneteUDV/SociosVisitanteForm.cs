using LanchoneteUDV.Application.DTO;
using LanchoneteUDV.Application.Interfaces;

namespace LanchoneteUDV
{
    public partial class SociosVisitanteForm : Form
    {

        //SociosBLL _bll = new SociosBLL();
        private readonly ISocioService _socioService;
        Helper _helper = new Helper();
        public SociosVisitanteForm(ISocioService socioService)
        {
            _socioService = socioService;
            InitializeComponent();
        }

        private void SociosVisitanteForm_Load(object sender, EventArgs e)
        {
            Controls.Clear();
            InitializeComponent();
            RecarregaGrid();
        }

        private void SociosDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = SociosDataGridView.CurrentRow.Index;

            IdTextBox.Text = SociosDataGridView.Rows[row].Cells[0].Value.ToString();
            NomeTextBox.Text = SociosDataGridView.Rows[row].Cells[1].Value.ToString();
            EmailTextBox.Text = SociosDataGridView.Rows[row].Cells[2].Value.ToString();
            _helper.Desabilita(NomeTextBox, IdTextBox, SalvarButton, NovoButton);
            _helper.Habilita(ExcluirButton, EditarButton);
        }
        private void LimparButton_Click(object sender, EventArgs e)
        {
            IdTextBox.Text = "0";
            NomeTextBox.Text = "";
            EmailTextBox.Text = "";
            _helper.Habilita(NovoButton);
            _helper.Desabilita(ExcluirButton, EditarButton, SalvarButton, NomeTextBox, EmailTextBox);
        }

        private void SalvarButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(NomeTextBox.Text))
            {

                SocioDTO socio = new SocioDTO
                {
                    Id = Convert.ToInt32(IdTextBox.Text),
                    Nome = "VISITANTE - " + NomeTextBox.Text.ToUpper().Trim(),
                    Email = EmailTextBox.Text.Trim(),
                    TipoSocio = 2
                };

                if (socio.Id>0)
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
            _helper.Habilita(NomeTextBox, EmailTextBox, SalvarButton);
            _helper.Desabilita(EditarButton, NovoButton);
        }

        private void SociosVisitanteForm_FormClosed(object sender, FormClosedEventArgs e)
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
            _helper.Desabilita(NovoButton, ExcluirButton, EditarButton);
            NomeTextBox.Focus();
        }

        private void RecarregaGrid()
        {
            SociosDataGridView.DataSource = _socioService.ListarSociosVisitantes();

        }


        private void FormatarGrid()
        {
            SociosDataGridView.Columns[0].Visible = false;
            SociosDataGridView.Columns[1].MinimumWidth = 250;
            SociosDataGridView.Columns[2].MinimumWidth = 250;
        }
        //private void PesquisaTextBox_KeyUp(object sender, KeyEventArgs e)
        //{
        //    SociosDataGridView.DataSource = _bll.PesquisarSocio(PesquisaTextBox.Text);
        //}


    }
}
