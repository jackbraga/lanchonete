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

            if (!ValidaCamposParaSalvar())
            {
                return;
            }

            var caixa = new CaixaDTO
            {
                DataEvento = DataEventoDateTimePicker.Value,
                IdCategoria = Convert.ToInt32(CategoriaComboBox.SelectedValue),
                Id = Convert.ToInt32(IdTextBox.Text),
                Observacao = ObservacaoTextBox.Text.Trim(),
                TipoEvento = TipoEventoComboBox.Text,
                EspecieMoeda = EspecieMoedaComboBox.Text,
                Frente = FrenteComboBox.Text,
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

            RecarregarTela();
            LimparButton_Click(sender, e);
            MessageBox.Show("Evento registrado com sucesso!", "Sucesso!", MessageBoxButtons.OK);
        }

        private bool ValidaCamposParaSalvar()
        {
            bool valido = true;

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
            else if (string.IsNullOrEmpty(EspecieMoedaComboBox.Text))
            {
                MessageBox.Show("É necessário informar a especie da moeda do Lançamento!", "Atenção!", MessageBoxButtons.OK);
                valido = false;
            }
            else if (string.IsNullOrEmpty(FrenteComboBox.Text))
            {
                MessageBox.Show("É necessário informar a frente do Lançamento!", "Atenção!", MessageBoxButtons.OK);
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
            CategoriaComboBox.DataSource = _caixaService.ListarCategoriaLancamento();
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
            CarregarResumoChurrasco();
        }

        private void RecarregarGrid()
        {

            FluxoCaixaDataGridView.DataSource = _caixaService.GetAll();
            FluxoCaixaDataGridView.Columns[0].Visible = false;

            FluxoCaixaDataGridView.Columns[1].HeaderText = "Data do Evento";
            FluxoCaixaDataGridView.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";

            FluxoCaixaDataGridView.Columns[2].HeaderText = "Tipo do Evento";

            FluxoCaixaDataGridView.Columns[3].HeaderText = "Valor";
            FluxoCaixaDataGridView.Columns[3].DefaultCellStyle.Format = "R$ 0.00##";

            FluxoCaixaDataGridView.Columns[4].HeaderText = "Categoria";
            FluxoCaixaDataGridView.Columns[4].Width = 150;

            FluxoCaixaDataGridView.Columns[5].HeaderText = "Descrição";
            FluxoCaixaDataGridView.Columns[5].Width = 150;
            FluxoCaixaDataGridView.Columns[6].Visible = false;
            FluxoCaixaDataGridView.Columns[7].HeaderText = "Moeda";

            ColorirEntradaSaida();
            FluxoCaixaDataGridView.ClearSelection();
        }

        private void FluxoCaixaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void NovoButton_Click(object sender, EventArgs e)
        {
            _helper.Habilita(DataEventoDateTimePicker, TipoEventoComboBox, CategoriaComboBox, PrecoTextBox, ObservacaoTextBox, PrecoTextBox, EspecieMoedaComboBox,FrenteComboBox,
            SalvarButton);

            _helper.Desabilita(NovoButton, EditarButton, ExcluirButton);
            LimparCampos();
            DataEventoDateTimePicker.Focus();
        }

        private void LimparCampos()
        {
            IdTextBox.Text = "0";
            TipoEventoComboBox.SelectedIndex = -1;
            CategoriaComboBox.SelectedIndex = -1;
            EspecieMoedaComboBox.SelectedIndex = -1;
            FrenteComboBox.SelectedIndex = -1;
            PrecoTextBox.Clear();
            ObservacaoTextBox.Clear();
        }

        private void LimparButton_Click(object sender, EventArgs e)
        {
            _helper.Desabilita(TipoEventoComboBox, CategoriaComboBox, PrecoTextBox, ObservacaoTextBox,
                     DataEventoDateTimePicker, ObservacaoTextBox, EspecieMoedaComboBox,
      ExcluirButton, EditarButton, SalvarButton);

            _helper.Habilita(NovoButton);
            LimparCampos();

        }

        private void ExcluirButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir o lançamento?", "ATENÇÃO!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _caixaService.Remove(Convert.ToInt32(IdTextBox.Text));
                MessageBox.Show("Lançamento removido com sucesso!", "Sucesso!", MessageBoxButtons.OK);
                LimparButton_Click(sender, e);
                RecarregarTela();
            }
        }

        private void EditarButton_Click(object sender, EventArgs e)
        {
            _helper.Habilita(DataEventoDateTimePicker, TipoEventoComboBox, CategoriaComboBox, PrecoTextBox, EspecieMoedaComboBox,
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
            var resumo = await _caixaService.ListarResumo("LANCHONETE");

            if (resumo != null)
            {

                EntradasTextBox.Text = "R$ " + String.Format("{0:N2}", resumo.Entradas);
                SaidasTextBox.Text = "R$ " + String.Format("{0:N2}", resumo.Saidas);
                FaturadoTextBox.Text = "R$ " + String.Format("{0:N2}", resumo.Faturado);
                LucroTextBox.Text = "R$ " + String.Format("{0:N2}", resumo.Lucro);
                DinheiroTextBox.Text = "R$ " + String.Format("{0:N2}", resumo.Dinheiro);
                CartaoTextBox.Text = "R$ " + String.Format("{0:N2}", resumo.Cartao);
                BoletoTextBox.Text = "R$ " + String.Format("{0:N2}", resumo.Boleto);
                SaldoAtualTextBox.Text = "R$ " + String.Format("{0:N2}", resumo.Saldo);
                ParceriasTextBox.Text = "R$ " + String.Format("{0:N2}", resumo.Parceria);
            }
        }

        private async void CarregarResumoChurrasco()
        {
            var resumo = await _caixaService.ListarResumo("CHURRASCO");


            if (resumo != null)
            {

                EntradasChurrascoTextBox.Text = "R$ " + String.Format("{0:N2}", resumo.Entradas);
                SaidasChurrascoTextBox.Text = "R$ " + String.Format("{0:N2}", resumo.Saidas);
                FaturadoChurrascoTextBox.Text = "R$ " + String.Format("{0:N2}", resumo.Faturado);
                LucroChurrascoTextBox.Text = "R$ " + String.Format("{0:N2}", resumo.Lucro);
                DinheiroChurrascoTextBox.Text = "R$ " + String.Format("{0:N2}", resumo.Dinheiro);
                CartaoChurrascoTextBox.Text = "R$ " + String.Format("{0:N2}", resumo.Cartao);
                BoletoChurrascoTextBox.Text = "R$ " + String.Format("{0:N2}", resumo.Boleto);
                SaldoChurrascoTextBox.Text = "R$ " + String.Format("{0:N2}", resumo.Saldo);
            }
        }

        private async void CarregarMesaMes(int ano)
        {

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
            _caixaService.AtualizarDinheiroCaixa(double.Parse(DinheiroTextBox.Text.Replace("R$", "").Trim()));
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
            EspecieMoedaComboBox.Text = FluxoCaixaDataGridView.Rows[row].Cells[7].Value.ToString();
            FrenteComboBox.Text = FluxoCaixaDataGridView.Rows[row].Cells[8].Value.ToString();

            double valor = (Double)FluxoCaixaDataGridView.Rows[row].Cells[3].Value;
            PrecoTextBox.Text = (valor < 0 ? valor * -1 : valor).ToString();

            _helper.Desabilita(DataEventoDateTimePicker, SalvarButton, NovoButton,
                                TipoEventoComboBox, PrecoTextBox, ObservacaoTextBox, CategoriaComboBox, EspecieMoedaComboBox, FrenteComboBox);

            _helper.Habilita(ExcluirButton, EditarButton);
        }
    }
}
