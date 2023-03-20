using LanchoneteUDV.Application.DTO;
using LanchoneteUDV.Application.Interfaces;

namespace LanchoneteUDV
{
    public partial class FilaPedidosForm : Form
    {
        private readonly IVendasPedidoService _pedidoService;
        Helper _helper = new Helper();

        private string _filtro="Todos";
        public FilaPedidosForm(IVendasPedidoService pedidoService)
        {
            _pedidoService=pedidoService;
            InitializeComponent();
        }

        private void FilaPedidosForm_Load(object sender, EventArgs e)
        {
            RecarregarGrid();
        }
        private void RecarregarGrid()
        {
       
            var lista = _pedidoService.ListarTodosVendasPedido(Convert.ToInt32(this.Tag), _filtro, Global.ExibeSoSemRetirar, Global.Agrupar).ToList();
            SortableBindingList<VendasPedidoEscalaDTO> listaSort = new SortableBindingList<VendasPedidoEscalaDTO>(lista);
            BindingSource bs = new BindingSource();
            bs.DataSource = listaSort;   // Bind to the sortable list
            PedidosDataGridView.DataSource = bs;

            PedidosDataGridView.Columns[0].Visible = false;
            PedidosDataGridView.Columns[1].HeaderText = "Data/Hora Pedido";
            PedidosDataGridView.Columns[1].Width = 150;
            
            PedidosDataGridView.Columns[2].HeaderText = "Socio";
            PedidosDataGridView.Columns[2].Width = 200;
            
            PedidosDataGridView.Columns[3].HeaderText = "Produto";
            PedidosDataGridView.Columns[3].Width = 200;
            PedidosDataGridView.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            PedidosDataGridView.Columns[4].HeaderText = "Quantidade";
            PedidosDataGridView.Columns[4].Width = 100;
     
            PedidosDataGridView.Columns[5].HeaderText = "Retirado";
            PedidosDataGridView.Columns[5].Width = 60;

            PedidosDataGridView.Columns[6].HeaderText = "Observação";
            PedidosDataGridView.Columns[6].Width = 200;

            TotalLabel.Text = lista.Sum(l=>l.Quantidade).ToString();

        }

        private void RegistrarRetiradaButton_Click(object sender, EventArgs e)
        {
            RegistrarRetirada();
        }

        private void RegistrarRetirada()
        {

            var linhasSelecionadas = PedidosDataGridView.SelectedRows
                .OfType<DataGridViewRow>()
                .Where(row => !row.IsNewRow)
                .ToArray();

            foreach (var linha in linhasSelecionadas)
            {
                //MessageBox.Show(PedidosDataGridView.Rows[linha.Index].Cells[2].Value.ToString());
                _pedidoService.RegistrarRetirada(Convert.ToInt32(PedidosDataGridView.Rows[linha.Index].Cells[0].Value));
            }

            RecarregarGrid();
            MessageBox.Show("Retirada dos selecionados foi registrada!", "Atenção!", MessageBoxButtons.OK);
            
            //PedidosDataGridView.FirstDisplayedScrollingRowIndex = linhasSelecionadas.First().Index;

            //int row = PedidosDataGridView.CurrentRow.Index;
            //_pedidoService.RegistrarRetirada(Convert.ToInt32(PedidosDataGridView.Rows[row].Cells[0].Value));
            //RecarregarGrid();
            //MessageBox.Show("Retirada registrada!", "Atenção!", MessageBoxButtons.OK);
            //PedidosDataGridView.Rows[row].Selected = true;
            //PedidosDataGridView.FirstDisplayedScrollingRowIndex = row;

        }

        private void DesmarcarRetirada()
        {

            var linhasSelecionadas = PedidosDataGridView.SelectedRows
             .OfType<DataGridViewRow>()
             .Where(row => !row.IsNewRow)
             .ToArray();

            foreach (var linha in linhasSelecionadas)
            {
                //MessageBox.Show(PedidosDataGridView.Rows[linha.Index].Cells[2].Value.ToString());
                _pedidoService.DesmarcarRetirada(Convert.ToInt32(PedidosDataGridView.Rows[linha.Index].Cells[0].Value));
            }

            RecarregarGrid();
            MessageBox.Show("Desmarcada Retirada dos selecionados!", "Atenção!", MessageBoxButtons.OK);



            //int row = PedidosDataGridView.CurrentRow.Index;

            //_pedidoService.DesmarcarRetirada(Convert.ToInt32(PedidosDataGridView.Rows[row].Cells[0].Value));
            //RecarregarGrid();
            //MessageBox.Show("Desmarcada retirada!", "Atenção!", MessageBoxButtons.OK);
            //PedidosDataGridView.Rows[row].Selected = true;
            //PedidosDataGridView.FirstDisplayedScrollingRowIndex = row;

        }

        private void DesmarcarRetiradaButton_Click(object sender, EventArgs e)
        {
            DesmarcarRetirada();
        }

        private void PedidosDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!Global.Agrupar)
            {
                int row = PedidosDataGridView.CurrentRow.Index;
                if (!Convert.ToBoolean(PedidosDataGridView.Rows[row].Cells[5].Value))
                {
                    RegistrarRetirada();
                }
                else
                {
                    DesmarcarRetirada();
                }
            }

  
        }

        private void AtualizaButton_Click(object sender, EventArgs e)
        {
            RecarregarGrid();
        }


        private void TudoRadioButton_Click(object sender, EventArgs e)
        {
            _filtro = "Todos";
            RecarregarGrid();
        }

        private void SalgadosRadioButton_Click(object sender, EventArgs e)
        {
            _filtro = "Salgados";
            RecarregarGrid();
        }

        private void ChurrascoRadioButton_Click(object sender, EventArgs e)
        {
            _filtro = "Churrasco";
            RecarregarGrid();
        }

        private void ParceriasRadioButton_Click(object sender, EventArgs e)
        {
            _filtro = "Parcerias";
            RecarregarGrid();
        }

        private void TudoRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void SalgadosRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ChurrascoRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ParceriasRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void SemRetirarCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Global.ExibeSoSemRetirar = SemRetirarCheckBox.Checked;
            RecarregarGrid();
            
        }

        private void AgruparCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Global.Agrupar = AgruparCheckBox.Checked;

            if (Global.Agrupar)
            {
                _helper.Desabilita(RegistrarRetiradaButton, DesmarcarRetiradaButton);
            }
            else
            {
                _helper.Habilita(RegistrarRetiradaButton, DesmarcarRetiradaButton);
            }
            
            RecarregarGrid();

        }
    }
}
