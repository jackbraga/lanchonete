using LanchoneteUDV.Application.DTO;
using LanchoneteUDV.Application.Interfaces;

namespace LanchoneteUDV
{
    public partial class FilaPedidosForm : Form
    {
        private readonly IVendasPedidoService _pedidoService;
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
            var lista = _pedidoService.ListarTodosVendasPedido(Convert.ToInt32(this.Tag)).ToList();
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


        }

        private void RegistrarRetiradaButton_Click(object sender, EventArgs e)
        {
            RegistrarRetirada();
        }

        private void RegistrarRetirada()
        {
            int row = PedidosDataGridView.CurrentRow.Index;
            _pedidoService.RegistrarRetirada(Convert.ToInt32(PedidosDataGridView.Rows[row].Cells[0].Value));
            RecarregarGrid();
            MessageBox.Show("Retirada registrada!", "Atenção!", MessageBoxButtons.OK);

        }

        private void DesmarcarRetirada()
        {
            int row = PedidosDataGridView.CurrentRow.Index;

            _pedidoService.DesmarcarRetirada(Convert.ToInt32(PedidosDataGridView.Rows[row].Cells[0].Value));
            RecarregarGrid();
            MessageBox.Show("Desmarcada retirada!", "Atenção!", MessageBoxButtons.OK);

        }

        private void DesmarcarRetiradaButton_Click(object sender, EventArgs e)
        {
            DesmarcarRetirada();
        }

        private void PedidosDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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

        private void AtualizaButton_Click(object sender, EventArgs e)
        {
            RecarregarGrid();
        }
    }
}
