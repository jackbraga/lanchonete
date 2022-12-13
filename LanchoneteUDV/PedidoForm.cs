using LanchoneteUDV.Application.DTO;
using LanchoneteUDV.Application.Interfaces;
using System.ComponentModel;
using System.Data;
using System.Text.RegularExpressions;

namespace LanchoneteUDV
{
    public partial class PedidoForm : Form
    {
        private readonly IProdutoService _produtoService;
        private readonly ISocioService _socioService;
        private readonly IVendaService _vendaService;
        private readonly IVendasPedidoService _vendasPedidoService;

        Helper _helper = new Helper();
        Regex reg = new Regex(@"^-?\d+[.]?\d*$");

        public int IdSocio { get; set; }
        public int IdEscala { get; set; }

        public int IdVenda { get; set; }

        public PedidoForm(IProdutoService produtoService, ISocioService socioService, IVendaService vendaService, IVendasPedidoService vendasPedido)
        {
            _produtoService = produtoService;
            _socioService = socioService;
            _vendaService = vendaService;
            _vendasPedidoService = vendasPedido;
            InitializeComponent();
        }

        #region Eventos  

        private void PedidoForm_Load(object sender, EventArgs e)
        {
            checkBoxSalgados.Checked = Global.ExibeSalgados;
            checkBoxChurrasco.Checked = Global.ExibeChurrasco;

            CarregarCombos();

            if (IdSocio > 0)
            {
                SocioComboBox.SelectedValue = IdSocio;
                _helper.Habilita(AdicionarButton);
                RecarregarVenda();

            }
            RecarregarGridEstoque();
            RecarregarGridEstoqueSalgados();

        }

        private void QuantidadeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) return;
            if (!reg.IsMatch(QuantidadeTextBox.Text.Insert(QuantidadeTextBox.SelectionStart, e.KeyChar.ToString()) + "1")) e.Handled = true;

        }

        private void DescontoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) return;
            if (!reg.IsMatch(DescontoTextBox.Text.Insert(DescontoTextBox.SelectionStart, e.KeyChar.ToString()) + "1")) e.Handled = true;

        }

        private void DescontoTextBox_Leave(object sender, EventArgs e)
        {
            CalcularSubtotal();
        }

        private void QuantidadeTextBox_Leave(object sender, EventArgs e)
        {
            CalcularSubtotal();
        }

        private void AdicionarButton_Click(object sender, EventArgs e)
        {
            if (!ValidaCamposParaAdicionarItens())
            {
                return;
            }

            var venda = new VendaDTO
            {
                Id = IdVenda,
                IdEscala = IdEscala,
                IdSocio = Convert.ToInt32(SocioComboBox.SelectedValue)
            };
            if (venda.Id == 0)
            {
                IdVenda = _vendaService.Add(venda);
            }

            var pedido = new VendasPedidoDTO
            {
                IdVenda = IdVenda,
                IdProduto = Convert.ToInt32(ProdutosComboBox.SelectedValue),
                Observacao = ObservacaoTextBox.Text,
                DataHoraPedido = DateTime.Now,
                PrecoProduto =
                Double.Parse(PrecoComboBox.Text.Replace("R$ ", "")) - Double.Parse(DescontoTextBox.Text),
                Quantidade = 1,
                Retirado = RetiradoCheckBox.Checked,
                TipoPagamento = PagamentoComboBox.Text
            };

            for (int i = 0; i < Convert.ToInt32(QuantidadeTextBox.Text); i++)
            {
                _vendasPedidoService.Add(pedido);
            }

            QuantidadeTextBox.Text = "0";
            DescontoTextBox.Text = "0";
            RecarregarVenda();
            RecarregarGridEstoque();
            RecarregarGridEstoqueSalgados();
        }

        private bool ValidaCamposParaAdicionarItens()
        {
            bool valido = true;

            _helper.ValidaComZero(QuantidadeTextBox);

            if (string.IsNullOrEmpty(ProdutosComboBox.Text))
            {
                valido = false;
                MessageBox.Show("É necessário informar o produto!", "Atenção!", MessageBoxButtons.OK);
                return valido;
            }


            if (Convert.ToInt32(QuantidadeTextBox.Text) <= 0)
            {
                valido = false;
                MessageBox.Show("Quantidade deve ser no mínimo 1!", "Atenção!", MessageBoxButtons.OK);
                return valido;

            }
            if (string.IsNullOrEmpty(PagamentoComboBox.Text))
            {
                MessageBox.Show("É necessário informar a forma de pagamento!", "Atenção!", MessageBoxButtons.OK);
                valido = false;
                return valido;
            }

            return valido;
        }

        private void ProdutosComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            PrecoComboBox.SelectedValue = ProdutosComboBox.SelectedValue;
            CalcularSubtotal();
        }

        private void SalvarButton_Click(object sender, EventArgs e)
        {
            var venda = new VendaDTO
            {
                Id = IdVenda,
                IdEscala = IdEscala,
                IdSocio = Convert.ToInt32(SocioComboBox.SelectedValue),
                TipoPagamento = PagamentoComboBox.Text,

            };
            if (venda.Id > 0)
            {
                _vendaService.Update(venda);
            }
            else
            {
                IdVenda = _vendaService.Add(venda);
            }

        }

        private void SocioComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LimparTela();
            _helper.Habilita(AdicionarButton);


            IdSocio = Convert.ToInt32(SocioComboBox.SelectedValue);
            RecarregarVenda();
        }

        private void RegistrarRetiradaButton_Click(object sender, EventArgs e)
        {
            if (PedidosDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um registro! ", "ATENÇÃO!", MessageBoxButtons.OK);
            }
            else
            {
                int row = PedidosDataGridView.CurrentRow.Index;
                int idPedido = Convert.ToInt32(PedidosDataGridView.Rows[row].Cells[0].Value);
                RegistrarRetirada(idPedido);
            }
        }

        private void PedidosDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = PedidosDataGridView.CurrentRow.Index;
            int idPedido = Convert.ToInt32(PedidosDataGridView.Rows[row].Cells[0].Value);
            if (!Convert.ToBoolean(PedidosDataGridView.Rows[row].Cells[6].Value))
            {
                RegistrarRetirada(idPedido);
            }
            else
            {
                DesmarcarRetirada(idPedido);
            }
        }

        private void DesmarcarRetiradaButton_Click(object sender, EventArgs e)
        {
            if (PedidosDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um registro!", "ATENÇÃO!", MessageBoxButtons.OK);
            }
            else
            {
                int row = PedidosDataGridView.CurrentRow.Index;
                int idPedido = Convert.ToInt32(PedidosDataGridView.Rows[row].Cells[0].Value);
                DesmarcarRetirada(idPedido);
            }

        }

        private void RemoverButton_Click(object sender, EventArgs e)
        {
            int row;


            if (PedidosDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um registro para remover", "ATENÇÃO!", MessageBoxButtons.OK);
            }
            else
            {
                if (MessageBox.Show("Deseja realmente excluir o item do pedido?", "ATENÇÃO!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (PedidosDataGridView.Rows.Count == 1)
                    {
                        row = 0;
                    }
                    else
                    {
                        row = PedidosDataGridView.CurrentRow.Index;
                    }

                    _vendasPedidoService.Remove(Convert.ToInt32(PedidosDataGridView.Rows[row].Cells[0].Value));
                    RecarregarVenda();
                    RecarregarGridEstoque();
                    RecarregarGridEstoqueSalgados();

                }
            }
        }

        private void FilaButton_Click(object sender, EventArgs e)
        {
            FilaPedidosForm fila = new FilaPedidosForm(_vendasPedidoService);
            fila.Tag = IdEscala;
            fila.ShowDialog();
        }

        private void VisitanteButton_Click(object sender, EventArgs e)
        {
            SociosVisitanteForm frm = new SociosVisitanteForm(_socioService);
            frm.ShowDialog();
            CarregarCombos();
            SocioComboBox.SelectedValue = -1;

        }

        private void checkBoxSalgados_CheckedChanged(object sender, EventArgs e)
        {
            Global.ExibeSalgados = checkBoxSalgados.Checked;
            RecarregarGridEstoqueSalgados();
            ComboProduto();
        }

        private void checkBoxChurrasco_CheckedChanged(object sender, EventArgs e)
        {
            Global.ExibeChurrasco = checkBoxChurrasco.Checked;
            RecarregarGridEstoqueSalgados();
            ComboProduto();
        }

        private void PedidoForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                switch (e.KeyCode)
                {
                    case Keys.C:
                        AtualizarFormaPagamentoItem("CARTAO");
                        break;
                    case Keys.B:
                        AtualizarFormaPagamentoItem("BOLETO");
                        break;
                    case Keys.P:
                        AtualizarFormaPagamentoItem("PIX");
                        break;
                    case Keys.D:
                        AtualizarFormaPagamentoItem("DINHEIRO");
                        break;
                    case Keys.R:
                        MarcarTodosRetirado();
                        break;

                    default:
                        break;
                }
            }

        }

        private void MarcarTodosRetirado()
        {
            if (MessageBox.Show("Deseja marcar todos os itens como retirado?", "ATENÇÃO!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in PedidosDataGridView.Rows)
                {
                    _vendasPedidoService.RegistrarRetirada(Convert.ToInt32(row.Cells[0].Value));
                }
                RecarregarGrid();
                MessageBox.Show("Itens retirados com sucesso!", "Atenção!", MessageBoxButtons.OK);
            }

        }

        private void RegistrarPagamentoButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apenas os itens com a forma pagamento CARTAO, DINHEIRO ou PIX terão a venda registrada\n\n" +
                "Deseja realmente prosseguir?", "ATENÇÃO!", MessageBoxButtons.YesNo) == DialogResult.Yes)

            {
                foreach (DataGridViewRow row in PedidosDataGridView.Rows)
                {
                    if (row.Cells[8].Value.ToString() != "BOLETO")
                    {
                        _vendasPedidoService.RegistrarPagamentoItem(Convert.ToInt32(row.Cells[0].Value));
                    }
                }

                MessageBox.Show("Pagamento dos itens registrado! ", "ATENÇÃO!", MessageBoxButtons.OK);
                RecarregarVenda();
            }
        }

        private void RegistrarRetiradaPagoButton_Click(object sender, EventArgs e)
        {
            if (PedidosPagosDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um registro! ", "ATENÇÃO!", MessageBoxButtons.OK);
            }
            else
            {

                int row = PedidosPagosDataGridView.CurrentRow.Index;
                int idPedido = Convert.ToInt32(PedidosPagosDataGridView.Rows[row].Cells[0].Value);
                //_vendasPedidoService.RegistrarRetirada(Convert.ToInt32(PedidosDataGridView.Rows[row].Cells[0].Value));

                RegistrarRetirada(idPedido);
            }
        }

        private void DesmarcarRetiradaPagoButton_Click(object sender, EventArgs e)
        {
            if (PedidosPagosDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um registro!", "ATENÇÃO!", MessageBoxButtons.OK);
            }
            else
            {
                int row = PedidosPagosDataGridView.CurrentRow.Index;
                int idPedido = Convert.ToInt32(PedidosPagosDataGridView.Rows[row].Cells[0].Value);
                DesmarcarRetirada(idPedido);
            }
        }

        private void PedidosPagosDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = PedidosPagosDataGridView.CurrentRow.Index;
            int idPedido = Convert.ToInt32(PedidosPagosDataGridView.Rows[row].Cells[0].Value);
            if (!Convert.ToBoolean(PedidosPagosDataGridView.Rows[row].Cells[6].Value))
            {
                RegistrarRetirada(idPedido);
            }
            else
            {
                DesmarcarRetirada(idPedido);
            }
        }


        #endregion

        #region Metodos
        private void CarregarCombos()
        {

            ComboSocio();
            ComboProduto();
        }

        private void ComboSocio()
        {
            SocioComboBox.DataSource = _socioService.ListarSociosVenda();
            SocioComboBox.DisplayMember = "Nome";
            SocioComboBox.ValueMember = "ID";
            SocioComboBox.SelectedValue = -1;
        }

        private void ComboProduto()
        {
            var lista = _produtoService.ListarProdutosParaVendaPorEscala(IdEscala, Global.ExibeSalgados, Global.ExibeChurrasco);

            ProdutosComboBox.DataSource = lista;
            ProdutosComboBox.DisplayMember = "Descricao";
            ProdutosComboBox.ValueMember = "ID";
            ProdutosComboBox.SelectedValue = -1;

            PrecoComboBox.DataSource = lista;
            PrecoComboBox.DisplayMember = "PrecoVenda";

            PrecoComboBox.ValueMember = "ID";
            PrecoComboBox.SelectedValue = -1;

        }
        private void CalcularSubtotal()
        {
            int quantidade;
            double preco;
            double total;
            double desconto;

            if (string.IsNullOrEmpty(QuantidadeTextBox.Text))
            {
                QuantidadeTextBox.Text = "0";
            }
            if (string.IsNullOrEmpty(PrecoComboBox.Text))
            {
                PrecoComboBox.Text = "0";
            }

            if (string.IsNullOrEmpty(DescontoTextBox.Text))
            {
                DescontoTextBox.Text = "0";
            }

            quantidade = Convert.ToInt32(QuantidadeTextBox.Text);
            preco = Convert.ToDouble(PrecoComboBox.Text.Replace("R$ ", ""));
            desconto = Convert.ToDouble(DescontoTextBox.Text);
            total = (preco - desconto) * quantidade;
            TotalTextBox.Text = total.ToString("R$ 0.00##");
        }

        private void RecarregarVenda()
        {
            var vendas = _vendaService.TrazerVendaEscalaSocio(IdEscala, Convert.ToInt32(SocioComboBox.SelectedValue));

            if (vendas.Count() > 0)
            {
                //var vendasPedido = vendas.First();

                var totalPago = vendas.Where(x => x.ItemPago).Sum(y => y.TotalConsumido);
                var totalAPagar = vendas.Where(x => !x.ItemPago).Sum(y => y.TotalConsumido);

                TotalAPagarTextBox.Text = "R$ " + String.Format("{0:N2}", totalAPagar);

                TotalConsumidoTextBox.Text = "R$ " + String.Format("{0:N2}", totalPago);



                IdVenda = Convert.ToInt32(vendas.First().IdVenda);

            }
            else
            {
                IdVenda = 0;
                TotalAPagarTextBox.Text = "R$ " + String.Format("{0:N2}", 0);
                TotalConsumidoTextBox.Text = "R$ " + String.Format("{0:N2}", 0);

            }

            RecarregarGrid();

        }

        private void RecarregarTodosGrids()
        {

        }

        private void RecarregarGrid()
        {

            var pedidos = _vendasPedidoService.ListarVendasPedido(IdVenda);
            PedidosDataGridView.DataSource = pedidos.Where(x => !x.ItemPago).ToList();
            PedidosPagosDataGridView.DataSource = pedidos.Where(x => x.ItemPago).ToList();
            FormatarGridPedidos();
            FormatarGridPedidosPagos();
            ColorirRetirada();
        }
        private void FormatarGridPedidos()
        {

            PedidosDataGridView.Columns[0].Visible = false;
            PedidosDataGridView.Columns[1].HeaderText = "Produto";
            PedidosDataGridView.Columns[1].Width = 170;
            PedidosDataGridView.Columns[2].DefaultCellStyle.Format = "R$ 0.00##";
            PedidosDataGridView.Columns[2].HeaderText = "Preço Unitario";
            PedidosDataGridView.Columns[2].Width = 60;
            PedidosDataGridView.Columns[3].HeaderText = "Qtd";
            PedidosDataGridView.Columns[3].Width = 50;
            PedidosDataGridView.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            PedidosDataGridView.Columns[4].HeaderText = "Valor Total";
            PedidosDataGridView.Columns[4].Width = 60;
            PedidosDataGridView.Columns[4].DefaultCellStyle.Format = "R$ 0.00##";
            PedidosDataGridView.Columns[5].HeaderText = "Observacao";
            PedidosDataGridView.Columns[6].HeaderText = "Retirado";
            PedidosDataGridView.Columns[6].Width = 60;
            PedidosDataGridView.Columns[7].HeaderText = "Data/Hora";
            PedidosDataGridView.Columns[8].HeaderText = "Pagamento";
            PedidosDataGridView.Columns[9].Visible = false;

            PedidosDataGridView.ClearSelection();
        }

        private void FormatarGridPedidosPagos()
        {
            //PedidosPagosDataGridView.DataSource = _vendasPedidoService.ListarVendasPedido(IdVenda).Where(p => p.ItemPago);

            PedidosPagosDataGridView.Columns[0].Visible = false;
            PedidosPagosDataGridView.Columns[1].HeaderText = "Produto";
            PedidosPagosDataGridView.Columns[1].Width = 170;
            PedidosPagosDataGridView.Columns[2].DefaultCellStyle.Format = "R$ 0.00##";
            PedidosPagosDataGridView.Columns[2].HeaderText = "Preço Unitario";
            PedidosPagosDataGridView.Columns[2].Width = 60;
            PedidosPagosDataGridView.Columns[3].HeaderText = "Qtd";
            PedidosPagosDataGridView.Columns[3].Width = 50;
            PedidosPagosDataGridView.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            PedidosPagosDataGridView.Columns[4].HeaderText = "Valor Total";
            PedidosPagosDataGridView.Columns[4].Width = 60;
            PedidosPagosDataGridView.Columns[4].DefaultCellStyle.Format = "R$ 0.00##";
            PedidosPagosDataGridView.Columns[5].Visible = false;
            PedidosPagosDataGridView.Columns[6].HeaderText = "Retirado";
            PedidosPagosDataGridView.Columns[6].Width = 60;
            PedidosPagosDataGridView.Columns[7].HeaderText = "Data/Hora";
            PedidosPagosDataGridView.Columns[8].HeaderText = "Pagamento";
            PedidosPagosDataGridView.Columns[9].HeaderText = "Pago";

            PedidosPagosDataGridView.ClearSelection();
        }

        private async void RecarregarGridEstoque()
        {
            try
            {
                var estoque = await _vendaService.ListarEstoquePorEscala(IdEscala);
                EstoqueDataGridView.DataSource = estoque;
                EstoqueDataGridView.Columns[0].Width = 200;
                EstoqueDataGridView.Columns[1].DefaultCellStyle.Format = "R$ 0.00##";
                EstoqueDataGridView.Columns[2].Visible = false;
                EstoqueDataGridView.Columns[3].Visible = false;

                EstoqueDataGridView.ClearSelection();
                ColorirSemEstoque();

            }
            catch
            {
                // Console.WriteLine(ex.Message);

            }


        }

        private async void RecarregarGridEstoqueSalgados()
        {
            EstoqueSalgadosDataGridView.DataSource = await _vendaService.ListarEstoqueSalgadosPorEscala(IdEscala, checkBoxSalgados.Checked, checkBoxChurrasco.Checked);
            EstoqueSalgadosDataGridView.Columns[0].Width = 200;
            EstoqueSalgadosDataGridView.Columns[1].DefaultCellStyle.Format = "R$ 0.00##";
            EstoqueSalgadosDataGridView.Columns[2].Visible = false;
            EstoqueSalgadosDataGridView.Columns[3].Visible = false;

            EstoqueSalgadosDataGridView.ClearSelection();
            ColorirSemEstoque();

        }

        private void ColorirSemEstoque()
        {
            foreach (DataGridViewRow row in EstoqueDataGridView.Rows)
            {
                if (Convert.ToInt32(row.Cells[4].Value) <= 0)
                {
                    row.DefaultCellStyle.BackColor = Color.LightPink;
                }
            }

            foreach (DataGridViewRow row in EstoqueSalgadosDataGridView.Rows)
            {
                if (Convert.ToInt32(row.Cells[4].Value) <= 0)
                {
                    row.DefaultCellStyle.BackColor = Color.LightPink;
                }
            }
        }

        private void ColorirRetirada()
        {
            foreach (DataGridViewRow row in PedidosDataGridView.Rows)
            {
                if (Convert.ToBoolean(row.Cells[6].Value))
                {
                    row.DefaultCellStyle.BackColor = Color.DarkSeaGreen;
                }
            }

            foreach (DataGridViewRow row in PedidosPagosDataGridView.Rows)
            {
                if (Convert.ToBoolean(row.Cells[6].Value))
                {
                    row.DefaultCellStyle.BackColor = Color.DarkSeaGreen;
                }
            }
        }
        private void LimparTela()
        {
            PedidosDataGridView.DataSource = null;
            TotalConsumidoTextBox.Text = "R$ 0,00";
            ProdutosComboBox.SelectedValue = -1;
            PrecoComboBox.SelectedValue = -1;
            TotalTextBox.Text = "R$ 0,00";
            ObservacaoTextBox.Clear();
            QuantidadeTextBox.Text = "0";
            PagamentoComboBox.Text = "";

        }

        private void RegistrarRetirada(int idPedido)
        {
            //int row = PedidosDataGridView.CurrentRow.Index;
            //_vendasPedidoService.RegistrarRetirada(Convert.ToInt32(PedidosDataGridView.Rows[row].Cells[0].Value));
            _vendasPedidoService.RegistrarRetirada(idPedido);
            RecarregarGrid();
            MessageBox.Show("Retirada registrada!", "Atenção!", MessageBoxButtons.OK);

        }

        private void DesmarcarRetirada(int idPedido)
        {
            // int row = PedidosDataGridView.CurrentRow.Index;
            _vendasPedidoService.DesmarcarRetirada(idPedido);
            RecarregarGrid();
            MessageBox.Show("Desmarcada retirada!", "Atenção!", MessageBoxButtons.OK);

        }

        private void AtualizarFormaPagamentoItem(string pagamento)
        {
            if (PedidosDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um registro para atualizar o pagamento! ", "ATENÇÃO!", MessageBoxButtons.OK);
            }
            else
            {
                int row = PedidosDataGridView.CurrentRow.Index;
                _vendasPedidoService.AtualizaFormaPagamentoItem(Convert.ToInt32(PedidosDataGridView.Rows[row].Cells[0].Value), pagamento);
                RecarregarGrid();
                MessageBox.Show("Pagamento atualizado!", "Atenção!", MessageBoxButtons.OK);

            }
        }

        #endregion

        private void DesmarcarPagamentoButton_Click(object sender, EventArgs e)
        {
            if (PedidosPagosDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um registro! ", "ATENÇÃO!", MessageBoxButtons.OK);
            }
            else
            {
                int row = PedidosPagosDataGridView.CurrentRow.Index;
                int idPedido = Convert.ToInt32(PedidosPagosDataGridView.Rows[row].Cells[0].Value);
                _vendasPedidoService.DesmarcarPagamentoItem(idPedido);
                MessageBox.Show("Item desmarcado!", "Atenção!", MessageBoxButtons.OK);
                RecarregarVenda();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"
                              Ctrl + C: Muda o pagamento de um item para Cartão!
                              Ctrl + B: Muda o pagamento de um item para Boleto!
                              Ctrl + P: Muda o pagamento de um item para Pix!
                              Ctrl + D: Muda o pagamento de um item para Dinheiro!
                              Ctrl + R: Registra a retirada de todos os itens da lista!", "Informativo!", MessageBoxButtons.OK);
        }
    }
}
