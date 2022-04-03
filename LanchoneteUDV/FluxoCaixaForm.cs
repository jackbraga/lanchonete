using LanchoneteUDV.Business;
using LanchoneteUDV.DataObject;
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
    public partial class FluxoCaixaForm : Form
    {

        FinanceiroBLL _bllFinanceiro = new FinanceiroBLL();
        Helper _helper = new Helper();

        public FluxoCaixaForm()
        {
            InitializeComponent();
        }

        private void PrecoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SalvarButton_Click(object sender, EventArgs e)
        {
            //NomeLabel.Text = CompradoPorTextBox.Text;
            CaixaDTO caixa = new CaixaDTO();

            caixa.ID = Convert.ToInt32(IdTextBox.Text);

            if (!ValidaCamposParaSalvar())
            {
                return;
            }

            caixa.DataEvento = DataEventoDateTimePicker.Value;
            caixa.TipoEvento = TipoEventoComboBox.Text;
            caixa.Categoria = Convert.ToInt32(CategoriaComboBox.SelectedValue);

            if (TipoEventoComboBox.Text == "Entrada")
            {
                caixa.Valor = Convert.ToDouble(PrecoTextBox.Text);
            }
            else
            {
                caixa.Valor = Convert.ToDouble(PrecoTextBox.Text) * -1;
            }

            caixa.Observacao = ObservacaoTextBox.Text.Trim();

            _bllFinanceiro.AdicionarEventoCaixa(caixa);

            RecarregarTela();
            LimparButton_Click(sender, e);
            MessageBox.Show("Evento registrado com sucesso!", "Sucesso!", MessageBoxButtons.OK);
        }

        private bool ValidaCamposParaSalvar()
        {
            bool valido = true;

            //ValidaComZero(QuantidadeTextBox, PrecoTextBox);

            if (DataEventoDateTimePicker.Value.Date > DateTime.Now.Date)
            {
                valido = false;
            }

            else if (string.IsNullOrEmpty(TipoEventoComboBox.Text))
            {
                MessageBox.Show("É necessário informar o Tipo do Evento!", "Atenção!", MessageBoxButtons.OK);
                valido = false;
            }
            else if (string.IsNullOrEmpty(CategoriaComboBox.Text))
            {
                MessageBox.Show("É necessário informar a categoria do Lançamento!", "Atenção!", MessageBoxButtons.OK);
                valido = false;
            }
            else if (Convert.ToDouble(PrecoTextBox.Text) <= 0)
            {
                MessageBox.Show("É necessário informar valor válido!", "Atenção!", MessageBoxButtons.OK);
                valido = false;
            }


            return valido;
        }


        private void FluxoCaixaForm_Load(object sender, EventArgs e)
        {
            CategoriaComboBox.DataSource = _bllFinanceiro.ListarCategoriaLancamento();
            CategoriaComboBox.DisplayMember = "Descricao";
            CategoriaComboBox.ValueMember = "ID";
            CategoriaComboBox.SelectedValue = -1;
            AnoComboBox.Text = DateTime.Now.Year.ToString();
            RecarregarTela();
            
            CarregarMesaMes(DateTime.Now.Year);
            

        }

        private void RecarregarTela()
        {
            RecarregarGrid();
            CarregarResumo();
        }



        private void RecarregarGrid()
        {

            FluxoCaixaDataGridView.DataSource = _bllFinanceiro.ListarCaixa();
            FluxoCaixaDataGridView.Columns[0].Visible = false;

            FluxoCaixaDataGridView.Columns[1].HeaderText = "Data do Evento";
            FluxoCaixaDataGridView.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";

            FluxoCaixaDataGridView.Columns[2].HeaderText = "Tipo do Evento";

            // FluxoCaixaDataGridView.Columns[2].Width = 230;


            FluxoCaixaDataGridView.Columns[3].HeaderText = "Valor";
            FluxoCaixaDataGridView.Columns[3].DefaultCellStyle.Format = "R$ 0.00##";



            FluxoCaixaDataGridView.Columns[4].HeaderText = "Categoria";
            FluxoCaixaDataGridView.Columns[4].Width = 150;

            FluxoCaixaDataGridView.Columns[5].HeaderText = "Observacao";
            FluxoCaixaDataGridView.Columns[5].Width = 150;
            ColorirEntradaSaida();
            FluxoCaixaDataGridView.ClearSelection();
        }

        private void FluxoCaixaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void NovoButton_Click(object sender, EventArgs e)
        {
            _helper.Habilita(DataEventoDateTimePicker, TipoEventoComboBox, CategoriaComboBox, PrecoTextBox, ObservacaoTextBox, PrecoTextBox,
            SalvarButton);

            _helper.Desabilita(NovoButton, EditarButton, ExcluirButton);
            LimparCampos();
        }

        private void LimparCampos()
        {
            IdTextBox.Text = "0";
            TipoEventoComboBox.Text = "";
            CategoriaComboBox.SelectedIndex = -1;
            PrecoTextBox.Clear();

            ObservacaoTextBox.Clear();

        }

        private void LimparButton_Click(object sender, EventArgs e)
        {
            _helper.Desabilita(TipoEventoComboBox, CategoriaComboBox, PrecoTextBox, ObservacaoTextBox,
                     DataEventoDateTimePicker, ObservacaoTextBox,
      ExcluirButton, EditarButton, SalvarButton);

            _helper.Habilita(NovoButton);
            LimparCampos();

        }

        private void ExcluirButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir o lançamento?", "ATENÇÃO!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // _bllFinanceiro.ExcluirLancamento(new CompraDTO { ID = Convert.ToInt32(IdTextBox.Text) });
                MessageBox.Show("Sócio removido com sucesso!", "Sucesso!", MessageBoxButtons.OK);
                LimparButton_Click(sender, e);
                RecarregarGrid();
            }
        }

        private void EditarButton_Click(object sender, EventArgs e)
        {
            _helper.Habilita(DataEventoDateTimePicker, TipoEventoComboBox, CategoriaComboBox, PrecoTextBox,
          ObservacaoTextBox, SalvarButton, LimparButton);
            _helper.Desabilita(EditarButton, ExcluirButton);
        }


        private void ColorirEntradaSaida()
        {
            foreach (DataGridViewRow row in FluxoCaixaDataGridView.Rows)
            {
                if (row.Cells[2].Value.ToString() == "Saida")
                {
                    row.DefaultCellStyle.BackColor = Color.LightPink;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                }
            }
        }

        private void CarregarResumo()
        {
            DataTable dados = _bllFinanceiro.ListarResumo();

            if (dados.Rows.Count > 0)
            {
                DataRow row = dados.Rows[0];
                SaldoInicialTextBox.Text = "R$ " + String.Format("{0:N2}", double.Parse(row["SaldoInicial"].ToString()));
                EntradasTextBox.Text = "R$ " + String.Format("{0:N2}", double.Parse(row["Entradas"].ToString()));
                SaidasTextBox.Text = "R$ " + String.Format("{0:N2}", double.Parse(row["Saidas"].ToString()));
                FaturadoTextBox.Text = "R$ " + String.Format("{0:N2}", double.Parse(row["Faturado"].ToString()));
                LucroTextBox.Text = "R$ " + String.Format("{0:N2}", double.Parse(row["Lucro"].ToString()));
                DinheiroTextBox.Text = "R$ " + String.Format("{0:N2}", double.Parse(row["Dinheiro"].ToString()));
                SaldoAtualTextBox.Text = "R$ " + String.Format("{0:N2}", double.Parse(row["Saldo"].ToString()));
            }
        }

        private void CarregarMesaMes(int ano)
        {
            DataTable dados = _bllFinanceiro.ListarMesAMes(ano);

            if (dados.Rows.Count > 0)
            {
                CarregaCamposMesAMes(dados.Rows[0], JanEntradasTextBox, JanSaidasTextBox, JanFaturadoTextBox, JanLucroTextBox);
                CarregaCamposMesAMes(dados.Rows[1], FevEntradasTextBox, FevSaidasTextBox, FevFaturadoTextBox, FevLucroTextBox);
                CarregaCamposMesAMes(dados.Rows[2], MarEntradasTextBox, MarSaidasTextBox, MarFaturadoTextBox, MarLucroTextBox);
                CarregaCamposMesAMes(dados.Rows[3], AbrEntradasTextBox, AbrSaidasTextBox, AbrFaturadoTextBox, AbrLucroTextBox);
                CarregaCamposMesAMes(dados.Rows[4], MaiEntradasTextBox, MaiSaidasTextBox, MaiFaturadoTextBox, MaiLucroTextBox);
                CarregaCamposMesAMes(dados.Rows[5], JunEntradasTextBox, JunSaidasTextBox, JunFaturadoTextBox, JunLucroTextBox);
                CarregaCamposMesAMes(dados.Rows[6], JulEntradasTextBox, JulSaidasTextBox, JulFaturadoTextBox, JulLucroTextBox);
                CarregaCamposMesAMes(dados.Rows[7], AgoEntradasTextBox, AgoSaidasTextBox, AgoFaturadoTextBox, AgoLucroTextBox);
                CarregaCamposMesAMes(dados.Rows[8], SetEntradasTextBox, SetSaidasTextBox, SetFaturadoTextBox, SetLucroTextBox);
                CarregaCamposMesAMes(dados.Rows[9], OutEntradasTextBox, OutSaidasTextBox, OutFaturadoTextBox, OutLucroTextBox);                
                CarregaCamposMesAMes(dados.Rows[10], NovEntradasTextBox, NovSaidasTextBox, NovFaturadoTextBox, NovLucroTextBox);
                CarregaCamposMesAMes(dados.Rows[11], DezEntradasTextBox, DezSaidasTextBox, DezFaturadoTextBox, DezLucroTextBox);
            }
        }

        private void CarregaCamposMesAMes(DataRow row, params Object[] objetos)
        {
            Control entradas = (Control)objetos[0];
            Control saidas = (Control)objetos[1];
            Control faturado = (Control)objetos[2];
            Control lucro = (Control)objetos[3];

            entradas.Text = "R$ " + String.Format("{0:N2}", double.Parse(row["Entradas"].ToString()));
            saidas.Text = "R$ " + String.Format("{0:N2}", double.Parse(row["Saidas"].ToString()));
            faturado.Text = "R$ " + String.Format("{0:N2}", double.Parse(row["Faturado"].ToString()));
            lucro.Text = "R$ " + String.Format("{0:N2}", double.Parse(row["Lucro"].ToString()));

        }

        private void AnoComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CarregarMesaMes(Convert.ToInt32(AnoComboBox.Text));
        }
    }
}
