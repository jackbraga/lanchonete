using LanchoneteUDV.Application.DTO;
using LanchoneteUDV.Application.Interfaces;

namespace LanchoneteUDV
{
    public partial class FluxoCaixaForm : Form
    {

        //FinanceiroBLL _bllFinanceiro = new FinanceiroBLL();
        private readonly ICaixaService _caixaService;

        Helper _helper = new Helper();

        public FluxoCaixaForm(ICaixaService caixaService)
        {
            _caixaService = caixaService;
            InitializeComponent();
        }

        private void PrecoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SalvarButton_Click(object sender, EventArgs e)
        {
            //NomeLabel.Text = CompradoPorTextBox.Text;
            //CaixaDTO caixa = new CaixaDTO();

            //caixa.ID = Convert.ToInt32(IdTextBox.Text);

            if (!ValidaCamposParaSalvar())
            {
                return;
            }

            //caixa.DataEvento = DataEventoDateTimePicker.Value;
            //caixa.TipoEvento = TipoEventoComboBox.Text;
            //caixa.Categoria = Convert.ToInt32(CategoriaComboBox.SelectedValue);
            //caixa.Observacao = ObservacaoTextBox.Text.Trim();


            var caixa = new CaixaDTO
            {
                DataEvento = DataEventoDateTimePicker.Value,
                IdCategoria = Convert.ToInt32(CategoriaComboBox.SelectedValue),
                Id = Convert.ToInt32(IdTextBox.Text),
                Observacao = ObservacaoTextBox.Text.Trim(),
                TipoEvento = TipoEventoComboBox.Text,
                Valor = TipoEventoComboBox.Text == "Entrada" ? Convert.ToDouble(PrecoTextBox.Text) : Convert.ToDouble(PrecoTextBox.Text) * -1
            };

            if (caixa.Id > 0)
            {
                _caixaService.Update(caixa);
            }
            else
            {
                _caixaService.Add(caixa);
            }

            //if (TipoEventoComboBox.Text == "Entrada")
            //{
            //    caixa.Valor = Convert.ToDouble(PrecoTextBox.Text);
            //}
            //else
            //{
            //    caixa.Valor = Convert.ToDouble(PrecoTextBox.Text) * -1;
            //}



            //_bllFinanceiro.AdicionarEventoCaixa(caixa);
            //_caixaService.Add(caixa);


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
            CategoriaComboBox.DataSource = _caixaService.ListarCategoriaLancamento();// _bllFinanceiro.ListarCategoriaLancamento();
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

            FluxoCaixaDataGridView.DataSource = _caixaService.GetAll();// _bllFinanceiro.ListarCaixa();
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

        private async void CarregarResumo()
        {
            //DataTable dados = _caixaService.ListarResumo();// _bllFinanceiro.ListarResumo();
            var resumo = await _caixaService.ListarResumo();

            if (resumo != null)
            {
                SaldoInicialTextBox.Text = "R$ " + String.Format("{0:N2}", (resumo.SaldoInicial));
                EntradasTextBox.Text = "R$ " + String.Format("{0:N2}", resumo.Entradas);
                SaidasTextBox.Text = "R$ " + String.Format("{0:N2}", resumo.Saidas);
                FaturadoTextBox.Text = "R$ " + String.Format("{0:N2}", resumo.Faturado);
                LucroTextBox.Text = "R$ " + String.Format("{0:N2}", resumo.Lucro);
                DinheiroTextBox.Text = "R$ " + String.Format("{0:N2}", resumo.Dinheiro);
                SaldoAtualTextBox.Text = "R$ " + String.Format("{0:N2}", resumo.Saldo);
            }
        }

        private async void CarregarMesaMes(int ano)
        {
            //DataTable dados = //_bllFinanceiro.ListarMesAMes(ano);

            var meses = (await _caixaService.ListarResumoMesAMes(ano)).ToList();


            if (meses.Count() > 0)
            {
                CarregaCamposMesAMes(meses[0], JanEntradasTextBox, JanSaidasTextBox, JanFaturadoTextBox, JanLucroTextBox);
                CarregaCamposMesAMes(meses[1], FevEntradasTextBox, FevSaidasTextBox, FevFaturadoTextBox, FevLucroTextBox);
                CarregaCamposMesAMes(meses[2], MarEntradasTextBox, MarSaidasTextBox, MarFaturadoTextBox, MarLucroTextBox);
                CarregaCamposMesAMes(meses[3], AbrEntradasTextBox, AbrSaidasTextBox, AbrFaturadoTextBox, AbrLucroTextBox);
                CarregaCamposMesAMes(meses[4], MaiEntradasTextBox, MaiSaidasTextBox, MaiFaturadoTextBox, MaiLucroTextBox);
                CarregaCamposMesAMes(meses[5], JunEntradasTextBox, JunSaidasTextBox, JunFaturadoTextBox, JunLucroTextBox);
                CarregaCamposMesAMes(meses[6], JulEntradasTextBox, JulSaidasTextBox, JulFaturadoTextBox, JulLucroTextBox);
                CarregaCamposMesAMes(meses[7], AgoEntradasTextBox, AgoSaidasTextBox, AgoFaturadoTextBox, AgoLucroTextBox);
                CarregaCamposMesAMes(meses[8], SetEntradasTextBox, SetSaidasTextBox, SetFaturadoTextBox, SetLucroTextBox);
                CarregaCamposMesAMes(meses[9], OutEntradasTextBox, OutSaidasTextBox, OutFaturadoTextBox, OutLucroTextBox);
                CarregaCamposMesAMes(meses[10], NovEntradasTextBox, NovSaidasTextBox, NovFaturadoTextBox, NovLucroTextBox);
                CarregaCamposMesAMes(meses[11], DezEntradasTextBox, DezSaidasTextBox, DezFaturadoTextBox, DezLucroTextBox);
            }
        }

        private void CarregaCamposMesAMes(ResumoVendasDTO mes, params Object[] objetos)
        {
            Control entradas = (Control)objetos[0];
            Control saidas = (Control)objetos[1];
            Control faturado = (Control)objetos[2];
            Control lucro = (Control)objetos[3];

            entradas.Text = "R$ " + String.Format("{0:N2}", mes.Entradas);
            saidas.Text = "R$ " + String.Format("{0:N2}", mes.Saidas);
            faturado.Text = "R$ " + String.Format("{0:N2}", mes.Faturado);
            lucro.Text = "R$ " + String.Format("{0:N2}", mes.Lucro);

        }

        private void AnoComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CarregarMesaMes(Convert.ToInt32(AnoComboBox.Text));
        }

        private void EditaDinheiroButton_Click(object sender, EventArgs e)
        {
            _helper.Habilita(DinheiroTextBox);
        }

        private void SalvarDinheiroButton_Click(object sender, EventArgs e)
        {
            _caixaService.AtualizarDinheiroCaixa(double.Parse(DinheiroTextBox.Text));
            DinheiroTextBox.Text = "R$ " + String.Format("{0:N2}", DinheiroTextBox.Text);
            _helper.Desabilita(DinheiroTextBox);
        }

        private void FluxoCaixaDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = FluxoCaixaDataGridView.CurrentRow.Index;

            IdTextBox.Text = FluxoCaixaDataGridView.Rows[row].Cells[0].Value.ToString();
            DataEventoDateTimePicker.Value = (DateTime)FluxoCaixaDataGridView.Rows[row].Cells[1].Value;
            TipoEventoComboBox.Text = FluxoCaixaDataGridView.Rows[row].Cells[2].Value.ToString();

            ObservacaoTextBox.Text = FluxoCaixaDataGridView.Rows[row].Cells[5].Value.ToString();

            CategoriaComboBox.SelectedValue = (Int32)FluxoCaixaDataGridView.Rows[row].Cells[6].Value;

            double valor = (Double)FluxoCaixaDataGridView.Rows[row].Cells[3].Value;
            PrecoTextBox.Text = (valor < 0 ? valor * -1 : valor).ToString();



            //NomeTextBox.Text = SociosDataGridView.Rows[row].Cells[1].Value.ToString();
            //EmailTextBox.Text = SociosDataGridView.Rows[row].Cells[2].Value.ToString();
            //ResponsavelFinanceiroComboBox.SelectedValue = Convert.ToInt32(SociosDataGridView.Rows[row].Cells[3].Value);
            _helper.Desabilita(DataEventoDateTimePicker, SalvarButton, NovoButton,
                                TipoEventoComboBox, PrecoTextBox, ObservacaoTextBox, CategoriaComboBox);

            _helper.Habilita(ExcluirButton, EditarButton);
        }
    }
}
