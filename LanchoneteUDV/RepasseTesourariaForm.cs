﻿using LanchoneteUDV.Application.Interfaces;

namespace LanchoneteUDV
{
    public partial class RepasseTesourariaForm : Form
    {
        Helper _helper = new Helper();
        private readonly IEscalaService _escalaService;
        private readonly IFinanceiroService _financeiroService;
        private readonly IVendaService _vendaService;
        private readonly ICaixaService _caixaService;
        public RepasseTesourariaForm(IEscalaService escalaService, IFinanceiroService financeiroService, IVendaService vendaService, ICaixaService caixaService)
        {
            _escalaService = escalaService;
            _financeiroService = financeiroService;
            _vendaService = vendaService;
            InitializeComponent();
            _caixaService = caixaService;
        }

        #region Eventos

        private void RepasseTesourariaForm_Load(object sender, EventArgs e)
        {
            RecarregarGrid();
        }

        private void AbrirEscalaButton_Click(object sender, EventArgs e)
        {
            RepasseTesourariaVendaForm repasseVendaForm = new RepasseTesourariaVendaForm(_escalaService,_financeiroService,_vendaService,_caixaService);
            repasseVendaForm.IDEscala = Convert.ToInt32(IdTextBox.Text);
            repasseVendaForm.ShowDialog();
            RecarregarGrid();

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
            _helper.Habilita(AbrirEscalaButton);
        }

        private void EscalasDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AbrirEscalaButton_Click(sender, e);
        }

        #endregion

        #region Metodos
        private void RecarregarGrid()
        {
            EscalasDataGridView.DataSource = _escalaService.GetAll();
            EscalasDataGridView.Columns[0].Visible = false;

            EscalasDataGridView.Columns[1].HeaderText = "Data da Escala";

            EscalasDataGridView.Columns[2].HeaderText = "Descricao";
            EscalasDataGridView.Columns[2].Width = 230;

            EscalasDataGridView.Columns[3].HeaderText = "Tipo de Sessão";

            EscalasDataGridView.Columns[4].HeaderText = "Observacao";
            EscalasDataGridView.Columns[4].Width = 150;

            EscalasDataGridView.Columns[5].HeaderText = "Finalizada";

            EscalasDataGridView.Columns[6].HeaderText = "Repasse Tesouraria";

            EscalasDataGridView.Columns[7].HeaderText = "Resumo de Vendas";
            EscalasDataGridView.Columns[7].DefaultCellStyle.Format = "R$ 0.00##";
            EscalasDataGridView.ClearSelection();
        }
        #endregion

    }
}
