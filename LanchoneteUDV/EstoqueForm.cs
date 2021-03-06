using LanchoneteUDV.Application.Interfaces;

namespace LanchoneteUDV
{
    public partial class EstoqueForm : Form
    {
        private readonly IEstoqueEscalaService _estoqueEscalaService;
        Helper _helper = new Helper();


        public EstoqueForm(IEstoqueEscalaService estoqueEscalaService)
        {
            _estoqueEscalaService = estoqueEscalaService;
            InitializeComponent();
        }


        private void RecarregaGrid()
        {

            EstoqueDataGridView.DataSource = _estoqueEscalaService.ListarEstoque();
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
    }
}
