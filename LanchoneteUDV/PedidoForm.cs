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
                PrecoProduto = Double.Parse(PrecoComboBox.Text.Replace("R$ ", "")),
                Quantidade = 1,
                Retirado = RetiradoCheckBox.Checked,
                TipoPagamento = PagamentoComboBox.Text
            };

            for (int i = 0; i < Convert.ToInt32(QuantidadeTextBox.Text); i++)
            {
                _vendasPedidoService.Add(pedido);
            }

            QuantidadeTextBox.Text = "0";
            RecarregarVenda();
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

            RecarregarVenda();
            IdSocio = Convert.ToInt32(SocioComboBox.SelectedValue);
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

            if (string.IsNullOrEmpty(QuantidadeTextBox.Text))
            {
                QuantidadeTextBox.Text = "0";
            }
            if (string.IsNullOrEmpty(PrecoComboBox.Text))
            {
                PrecoComboBox.Text = "0";
            }
            quantidade = Convert.ToInt32(QuantidadeTextBox.Text);
            preco = Convert.ToDouble(PrecoComboBox.Text.Replace("R$ ", ""));
            total = preco * quantidade;
            TotalTextBox.Text = total.ToString("R$ 0.00##");
        }

        private void RecarregarVenda()
        {
            var vendas = _vendaService.TrazerVendaEscalaSocio(IdEscala, Convert.ToInt32(SocioComboBox.SelectedValue));

            if (vendas.Count() > 0)
            {
                var venda1 = vendas.First();
                TotalConsumidoTextBox.Text = "R$ " + String.Format("{0:N2}", double.Parse(venda1.TotalConsumido.ToString()));
                IdVenda = Convert.ToInt32(venda1.IdVenda);

            }
            else
            {
                IdVenda = 0;
                TotalConsumidoTextBox.Text = "R$ 0,00";

            }



            RecarregarGrid();
            RecarregarGridEstoque();
            RecarregarGridEstoqueSalgados();
        }

        private void RecarregarGrid()
        {
            PedidosDataGridView.DataSource = _vendasPedidoService.ListarVendasPedido(IdVenda);

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

            PedidosDataGridView.ClearSelection();
            ColorirRetirada();

        }
        private async void RecarregarGridEstoque()
        {
            EstoqueDataGridView.DataSource = await _vendaService.ListarEstoquePorEscala(IdEscala);
            EstoqueDataGridView.Columns[0].Width = 200;
            EstoqueDataGridView.Columns[1].DefaultCellStyle.Format = "R$ 0.00##";
            EstoqueDataGridView.Columns[2].Visible = false;
            EstoqueDataGridView.Columns[3].Visible = false;

            EstoqueDataGridView.ClearSelection();
            ColorirSemEstoque();

        }

        private async void RecarregarGridEstoqueSalgados()
        {
            EstoqueSalgadosDataGridView.DataSource = await _vendaService.ListarEstoqueSalgadosPorEscala(IdEscala);
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


        #endregion

        private void RegistrarRetiradaButton_Click(object sender, EventArgs e)
        {
            if (PedidosDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um registro! ", "ATENÇÃO!", MessageBoxButtons.OK);
            }
            else
            {
                RegistrarRetirada();
            }
        }

        private void RegistrarRetirada()
        {
            int row = PedidosDataGridView.CurrentRow.Index;
            _vendasPedidoService.RegistrarRetirada(Convert.ToInt32(PedidosDataGridView.Rows[row].Cells[0].Value));
            RecarregarGrid();
            MessageBox.Show("Retirada registrada!", "Atenção!", MessageBoxButtons.OK);

        }

        private void DesmarcarRetirada()
        {
            int row = PedidosDataGridView.CurrentRow.Index;
            _vendasPedidoService.DesmarcarRetirada(Convert.ToInt32(PedidosDataGridView.Rows[row].Cells[0].Value));
            RecarregarGrid();
            MessageBox.Show("Desmarcada retirada!", "Atenção!", MessageBoxButtons.OK);

        }

        private void PedidosDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = PedidosDataGridView.CurrentRow.Index;
            if (!Convert.ToBoolean(PedidosDataGridView.Rows[row].Cells[6].Value))
            {
                RegistrarRetirada();
            }
            else
            {
                DesmarcarRetirada();
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
                DesmarcarRetirada();
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
            ComboProduto();
        }

        private void checkBoxChurrasco_CheckedChanged(object sender, EventArgs e)
        {
            Global.ExibeChurrasco = checkBoxChurrasco.Checked;
            ComboProduto();
        }
    }
}
