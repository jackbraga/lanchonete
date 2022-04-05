﻿using LanchoneteUDV.Application.Interfaces;
using LanchoneteUDV.Business;
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
    public partial class RepasseTesourariaVendaForm : Form
    {
        VendasBLL _bllVendas = new VendasBLL();
        FinanceiroBLL _bllFinanceiro = new FinanceiroBLL();
        
        private readonly IEscalaService _escalaService;
        Helper _helper = new Helper();
        public int IDEscala { get; set; }


        public RepasseTesourariaVendaForm(IEscalaService escalaService)
        {
            _escalaService = escalaService;
            InitializeComponent();
        }

        private void RecarregarTela()
        {
            DataTable dados = _bllVendas.TrazerEscala(Convert.ToInt32(IDEscala));

            DataRow row = dados.Rows[0];

            IdTextBox.Text = row["ID"].ToString();
            DescricaoEscalaTextBox.Text = row["Descricao"].ToString();
            DataEscalaDateTimePicker.Value = Convert.ToDateTime(row["DataEscala"]);
            FinalizadaCheckBox.Checked = Convert.ToBoolean(row["Finalizada"]);

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



            if (!string.IsNullOrEmpty(row["Resumo"].ToString()))
            {
                ResumoVendasTextBox.Text = "R$ " + String.Format("{0:N2}", double.Parse(row["Resumo"].ToString()));
            }

            RecarregaGrid();
        }

        private void RecarregaGrid()
        {
            VendasDataGridView.DataSource = _bllFinanceiro.ListarVendasRepasse(Convert.ToInt32(IDEscala));
            VendasDataGridView.Columns[0].Visible = false;
            VendasDataGridView.Columns[1].Visible = false;
            VendasDataGridView.Columns[2].HeaderText = "Socio";
            VendasDataGridView.Columns[2].Width = 210;
            VendasDataGridView.Columns[3].HeaderText = "Pagamento";
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
                Email email = new Email();

                email.EnviarEmail(IDEscala, idSocio, emailSocio);
                _bllFinanceiro.AtualizaEmailDisparado(idVenda);
                MessageBox.Show("E-mail disparado com sucesso!", "E-mail", MessageBoxButtons.OK);
                RecarregaGrid();
            }


        }

        private void DispararEmailsButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente disparar o e-mail para todos os socios?", "ATENÇÃO!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                Email email = new Email();
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
                        _bllFinanceiro.AtualizaEmailDisparado(idVenda);
                    }
                    //System.Threading.Thread.Sleep(1000);

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
            EmailProgressBar.Value = 50;
        }
    }
}
