using LanchoneteUDV.Application.DTO;
using LanchoneteUDV.Application.Interfaces;

namespace LanchoneteUDV
{
    public partial class EscalasForm : Form
    {
        //EscalasBLL _bllEscalas = new EscalasBLL();


        private readonly IEscalaService _escalaService;
        private readonly IProdutoService _produtoService;
        Helper _helper = new Helper();
        //Regex reg = new Regex(@"^-?\d+[.]?\d*$");

        public EscalasForm(IEscalaService escalaService,IProdutoService produtoService)
        {
            _escalaService = escalaService;
            _produtoService = produtoService;
            InitializeComponent();
        }


        #region Eventos

        private void EscalasForm_Load(object sender, EventArgs e)
        {
            RecarregaGrid();
        }

        private void NovoButton_Click(object sender, EventArgs e)
        {
            _helper.Habilita(DataEscalaDateTimePicker, TipoSessaoComboBox, DescricaoTextBox,
                FinalizadaCheckBox, ObservacaoTextBox,
             SalvarButton);

            _helper.Desabilita(NovoButton, EditarButton, ExcluirButton,AbrirEscalaButton);
            LimparCampos();
        }

        private void SalvarButton_Click(object sender, EventArgs e)
        {
            //EscalaDTO escala = new EscalaDTO();

            //escala.ID = Convert.ToInt32(IdTextBox.Text);

            if (!ValidaCamposParaSalvar())
            {
                return;
            }

            //escala.DataEscala = DataEscalaDateTimePicker.Value.Date;
            //escala.Descricao = DescricaoTextBox.Text.Trim();
            //escala.TipoSessao = TipoSessaoComboBox.Text;
            //escala.Observacao = ObservacaoTextBox.Text.Trim();

            //_bllEscalas.SalvarEscala(escala);

            var escala = new EscalaDTO
            {
                DataEscala = DataEscalaDateTimePicker.Value.Date,
                Descricao = DescricaoTextBox.Text.Trim(),
                TipoSessao = TipoSessaoComboBox.Text,
                Observacao = ObservacaoTextBox.Text.Trim(),
                Id = Convert.ToInt32(IdTextBox.Text)
            };

            if (escala.Id>0)
            {
                _escalaService.Update(escala);
            }
            else
            {
                _escalaService.Add(escala);
            }            

            RecarregaGrid();
            LimparButton_Click(sender, e);
            MessageBox.Show("Escala registrada com sucesso!", "Sucesso!", MessageBoxButtons.OK);
        }

        private void EditarButton_Click(object sender, EventArgs e)
        {
            _helper.Habilita(DataEscalaDateTimePicker, TipoSessaoComboBox, DescricaoTextBox, FinalizadaCheckBox,
               ObservacaoTextBox, ObservacaoTextBox, SalvarButton, LimparButton);
            _helper.Desabilita(EditarButton, ExcluirButton);
        }

        private void ExcluirButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir a escala?", "ATENÇÃO!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _escalaService.Remove(Convert.ToInt32(IdTextBox.Text));
 

                //_bllEscalas.ExcluirEscala(new EscalaDTO { ID = Convert.ToInt32(IdTextBox.Text) });

                MessageBox.Show("Escala removida com sucesso!", "Sucesso!", MessageBoxButtons.OK);
                LimparButton_Click(sender, e);
                RecarregaGrid();
            }
        }

        private void LimparButton_Click(object sender, EventArgs e)
        {
            _helper.Desabilita(DataEscalaDateTimePicker, TipoSessaoComboBox, DescricaoTextBox, ObservacaoTextBox,
            ExcluirButton, EditarButton, SalvarButton, AbrirEscalaButton);

            _helper.Habilita(NovoButton);
            LimparCampos();

        }

        #endregion

        #region Métodos
        private void LimparCampos()
        {
            IdTextBox.Text = "0";
            TipoSessaoComboBox.SelectedIndex = -1;
            DescricaoTextBox.Clear();
            FinalizadaCheckBox.Checked = false;
            ObservacaoTextBox.Clear();
            DataEscalaDateTimePicker.Value = DateTime.Now;
        }

        private void PesquisaTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            //EscalasDataGridView.DataSource = _bllEscalas.PesquisarEscala(PesquisaTextBox.Text);
            //EscalasDataGridView.DataSource = _bllEscalas.PesquisarEscala(PesquisaTextBox.Text);
            //EscalasDataGridView.DataSource = _escalaService.
            RecarregaGrid(PesquisaTextBox.Text);   

        }

        private async void RecarregaGrid()
        {
            //EscalasDataGridView.DataSource = _bllEscalas.ListarEscalas();
            EscalasDataGridView.DataSource =  _escalaService.GetAll();
            FormataGrid();
        }
        private  void RecarregaGrid(string pesquisa)
        {
            //EscalasDataGridView.DataSource = _bllEscalas.ListarEscalas();
            EscalasDataGridView.DataSource =  _escalaService.GetByName(pesquisa);
            FormataGrid();
        }

        private void FormataGrid()
        {
            EscalasDataGridView.Columns[0].Visible = false;

            EscalasDataGridView.Columns[1].HeaderText = "Data da Escala";

            EscalasDataGridView.Columns[2].HeaderText = "Descricao";
            EscalasDataGridView.Columns[2].Width = 230;

            EscalasDataGridView.Columns[3].HeaderText = "Tipo de Sessão";

            EscalasDataGridView.Columns[4].HeaderText = "Observacao";
            EscalasDataGridView.Columns[4].Width = 150;

            EscalasDataGridView.Columns[5].HeaderText = "Finalizada";

            EscalasDataGridView.Columns[6].Visible = false;

            EscalasDataGridView.Columns[7].HeaderText = "Resumo de Vendas";
            EscalasDataGridView.Columns[7].DefaultCellStyle.Format = "R$ 0.00##";
            EscalasDataGridView.ClearSelection();
        }

        private bool ValidaCamposParaSalvar()
        {
            bool valido = true;

            if (DataEscalaDateTimePicker.Value.Date < DateTime.Now.Date)
            {
                //valido = false;
            }

            else if (string.IsNullOrEmpty(TipoSessaoComboBox.Text))
            {
                MessageBox.Show("É necessário informar o tipo da sessão!", "Atenção!", MessageBoxButtons.OK);
                valido = false;
            }
            else if (string.IsNullOrEmpty(DescricaoTextBox.Text))
            {
                MessageBox.Show("É necessário informar uma descrição para a escala!", "Atenção!", MessageBoxButtons.OK);
                valido = false;
            }

            return valido;
        }

        #endregion

        private void EscalasDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
 
            AbrirEscalaButton_Click(sender, e);
        }

        private void AbrirEscalaButton_Click(object sender, EventArgs e)
        {
            VendasForm vendasForm = new VendasForm(_produtoService);
            vendasForm.Tag = IdTextBox.Text;
            vendasForm.ShowDialog();         
            
        }

        private void EscalasDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = EscalasDataGridView.CurrentRow.Index;

            IdTextBox.Text = EscalasDataGridView.Rows[row].Cells[0].Value.ToString();
            DataEscalaDateTimePicker.Value = Convert.ToDateTime(EscalasDataGridView.Rows[row].Cells[1].Value);
            DescricaoTextBox.Text = EscalasDataGridView.Rows[row].Cells[2].Value.ToString();

            TipoSessaoComboBox.Text = EscalasDataGridView.Rows[row].Cells[3].Value.ToString();
            ObservacaoTextBox.Text = EscalasDataGridView.Rows[row].Cells[4].Value.ToString();

            FinalizadaCheckBox.Checked = Convert.ToBoolean(EscalasDataGridView.Rows[row].Cells[5].Value);

            _helper.Desabilita(DataEscalaDateTimePicker, TipoSessaoComboBox, DescricaoTextBox, ObservacaoTextBox,
                               SalvarButton);

            _helper.Habilita(ExcluirButton, EditarButton, NovoButton, AbrirEscalaButton);
        }
    }
}
