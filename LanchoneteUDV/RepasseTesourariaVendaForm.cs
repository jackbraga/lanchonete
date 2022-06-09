using LanchoneteUDV.Application.Interfaces;

namespace LanchoneteUDV
{
    public partial class RepasseTesourariaVendaForm : Form
    {
        //VendasBLL _bllVendas = new VendasBLL();
        //FinanceiroBLL _bllFinanceiro = new FinanceiroBLL();

        private readonly IVendaService _vendaService;
        private readonly IFinanceiroService _financeiroService;
        private readonly IEscalaService _escalaService;
        Helper _helper = new Helper();
        public int IDEscala { get; set; }


        public RepasseTesourariaVendaForm(IEscalaService escalaService, IFinanceiroService financeiroService, IVendaService vendaService)
        {
            _escalaService = escalaService;
            _financeiroService = financeiroService;
            _vendaService = vendaService;
            InitializeComponent();
        }

        private void RecarregarTela()
        {
            var escala = _escalaService.GetById(IDEscala);

            IdTextBox.Text = escala.Id.ToString();
            DescricaoEscalaTextBox.Text = escala.Descricao;
            DataEscalaDateTimePicker.Value = escala.DataEscala; 
            FinalizadaCheckBox.Checked = escala.Finalizada;

            if (FinalizadaCheckBox.Checked)
            {
                _helper.Habilita(EmailSelecionadoButton, DispararEmailsButton, GerarRepasseButton);
                _helper.Desabilita(FinalizarEscalaButton);
            }
            else
            {
                _helper.Desabilita(EmailSelecionadoButton, DispararEmailsButton, GerarRepasseButton);
                _helper.Habilita(FinalizarEscalaButton);
            }

            if (escala != null)
            {
                ResumoVendasTextBox.Text = "R$ " + String.Format("{0:N2}", escala.ResumoVendas);
            }

            RecarregaGrid();
        }

        private void RecarregaGrid()
        {
            VendasDataGridView.DataSource = _financeiroService.ListarVendasRepasseFinanceiro(Convert.ToInt32(IDEscala));
            VendasDataGridView.Columns[2].HeaderText = "Socio";
            VendasDataGridView.Columns[2].Width = 210;
            VendasDataGridView.Columns[3].HeaderText = "Pagamento";
            VendasDataGridView.Columns[3].Visible = false;
            VendasDataGridView.Columns[4].DefaultCellStyle.Format = "R$ 0.00##";
            VendasDataGridView.Columns[4].HeaderText = "Valor Total";
            VendasDataGridView.Columns[5].HeaderText = "Email Disparado";
            VendasDataGridView.Columns[6].HeaderText = "E-mail";
            VendasDataGridView.Columns[6].Width = 190;
            VendasDataGridView.ClearSelection();

        }

        private void RepasseTesourariaVendaForm_Load(object sender, EventArgs e)
        {
            RecarregarTela();
        }

        private void FinalizarEscalaButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente finalizar essa escala?", "ATENÇÃO!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _escalaService.FinalizarEscala(IDEscala);
            }
            RecarregarTela();
        }

        private void EmailSelecionadoButton_Click(object sender, EventArgs e)
        {
            int row = VendasDataGridView.CurrentRow.Index;
            int idSocio = Convert.ToInt32(VendasDataGridView.Rows[row].Cells[1].Value);
            int idVenda = Convert.ToInt32(VendasDataGridView.Rows[row].Cells[0].Value);

            string emailSocio = VendasDataGridView.Rows[row].Cells[6].Value.ToString();

            if (MessageBox.Show("Deseja realmente disparar o e-mail para o socio selecionado?", "ATENÇÃO!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Email email = new Email(_financeiroService);

                email.EnviarEmail(IDEscala, idSocio, emailSocio);
                _financeiroService.AtualizaEmailDisparado(idVenda);
                MessageBox.Show("E-mail disparado com sucesso!", "E-mail", MessageBoxButtons.OK);
                RecarregaGrid();
            }


        }

        private void DispararEmailsButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente disparar o e-mail para todos os socios?", "ATENÇÃO!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                Email email = new Email(_financeiroService);
                ProgressLabel.Visible = true;
                EmailProgressBar.Visible = true;
                EmailProgressBar.Value = 0;
                EmailProgressBar.Maximum = VendasDataGridView.Rows.Count;
                this.Update();

                foreach (DataGridViewRow row in VendasDataGridView.Rows)
                {
                    if (!Convert.ToBoolean(row.Cells[5].Value))
                    {
                        int idSocio = Convert.ToInt32(row.Cells[1].Value);
                        int idVenda = Convert.ToInt32(row.Cells[0].Value);
                        string emailSocio = row.Cells[6].Value.ToString();

                        email.EnviarEmail(IDEscala, idSocio, emailSocio);
                        _financeiroService.AtualizaEmailDisparado(idVenda);
                    }

                    EmailProgressBar.Value = EmailProgressBar.Value + 1;
                }

                MessageBox.Show("E-mails disparados com sucesso!", "E-mail", MessageBoxButtons.OK);
                EmailProgressBar.Visible = false;
                ProgressLabel.Visible = false;
                RecarregaGrid();
            }
        }

        private void GerarRepasseButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente gerar a planilha de repasse para essa escala?", "ATENÇÃO!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                bool retorno = _financeiroService.GerarListaRepasseFinanceiroExcel(IDEscala);

                if (retorno)
                {
                    MessageBox.Show("Planilha gerado com sucesso!", "Repasse tesouraria", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro ao gerar a planilha!", "Repasse tesouraria", MessageBoxButtons.OK);

                }
            }
        }
    }
}