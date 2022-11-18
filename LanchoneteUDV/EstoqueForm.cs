using LanchoneteUDV.Application.Interfaces;

namespace LanchoneteUDV
{
    public partial class EstoqueForm : Form
    {
        private readonly IEstoqueEscalaService _estoqueEscalaService;
        private readonly ICompraService _compraService;
        Helper _helper = new Helper();

        private string _filtro = "Todos";


        public EstoqueForm(IEstoqueEscalaService estoqueEscalaService, ICompraService compraService)
        {
            _estoqueEscalaService = estoqueEscalaService;
            _compraService = compraService;
            InitializeComponent();
          
        }


        private void RecarregaGrid()
        {

            EstoqueDataGridView.DataSource = _estoqueEscalaService.ListarEstoque(_filtro);
            EstoqueDataGridView.Columns[0].Visible = false;

            EstoqueDataGridView.Columns[1].HeaderText = "Produto";
            EstoqueDataGridView.Columns[1].Width = 230;

            EstoqueDataGridView.Columns[2].HeaderText = "Preço";
            EstoqueDataGridView.Columns[2].DefaultCellStyle.Format = "R$ 0.00##";

            EstoqueDataGridView.Columns[3].Visible = false;
            EstoqueDataGridView.Columns[4].Visible = false;
            EstoqueDataGridView.Columns[5].Visible = false;
            EstoqueDataGridView.Columns[6].HeaderText = "Estoque";
            ColorirSemEstoque();
        }

        private void EstoqueForm_Load(object sender, EventArgs e)
        {
            RecarregaGrid();
        }

        private void AtualizaButton_Click(object sender, EventArgs e)
        {
            RecarregaGrid();
        }

        private void ColorirSemEstoque()
        {
            foreach (DataGridViewRow row in EstoqueDataGridView.Rows)
            {
                if (Convert.ToInt32(row.Cells[6].Value) <=0)
                {
                    row.DefaultCellStyle.BackColor = Color.LightPink;
                }
            }
        }

        private void EstoqueDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {


            int row = EstoqueDataGridView.CurrentRow.Index;

            int idProduto = Convert.ToInt32(EstoqueDataGridView.Rows[row].Cells[0].Value);
            string descricaoProduto = EstoqueDataGridView.Rows[row].Cells[1].Value.ToString();

            AjustarEstoqueForm frm = new AjustarEstoqueForm(_estoqueEscalaService, _compraService);
            frm.IdProduto = idProduto;
            frm.DescricaoProduto = descricaoProduto;
            frm.ShowDialog();
            RecarregaGrid();

            EstoqueDataGridView.Rows[row].Selected = true;
            EstoqueDataGridView.FirstDisplayedScrollingRowIndex = row;
            
        }

        private void TudoRadioButton_Click(object sender, EventArgs e)
        {
            _filtro = "Todos";
            RecarregaGrid();
        }

        private void SalgadosRadioButton_Click(object sender, EventArgs e)
        {
            _filtro = "Salgados";
            RecarregaGrid();
        }

        private void BebidasRadioButton_Click(object sender, EventArgs e)
        {
            _filtro = "Bebidas";
            RecarregaGrid();
        }

        private void ParceriasRadioButton_Click(object sender, EventArgs e)
        {
            _filtro = "Parcerias";
            RecarregaGrid();
        }

        private void ChurrascoRadioButton_Click(object sender, EventArgs e)
        {
            _filtro = "Churrasco";
            RecarregaGrid();
        }

    }
}
