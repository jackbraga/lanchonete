

using LanchoneteUDV.Application.Interfaces;

namespace LanchoneteUDV
{
    public partial class PrincipalForm : Form
    {
        private readonly ICategoriaService _categoriaService;
        public PrincipalForm(ICategoriaService categoriaService)
        {
            _categoriaService = categoriaService;
            InitializeComponent();
        }

        private void cadastroSociosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SociosForm sc = new SociosForm();
            sc.Show();
        }

        private void categoriasProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            CategoriasForm sc = new CategoriasForm(_categoriaService);
            sc.Show();
        }

        private void cadastroProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProdutosForm sc = new ProdutosForm();
            sc.Show();
        }


        private void comprasProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ComprasForm sc = new ComprasForm();
            sc.Show();
        }

        private void escalasDeVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EscalasForm sc = new EscalasForm();
            sc.Show();
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EstoqueForm sc = new EstoqueForm();
            sc.Show();
        }

        private async void gerarRepasseTesourariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //GranatumService service = new GranatumService();
            //var lancamentos = await service.GetLancamentosAsync();
            RepasseTesourariaForm sc = new RepasseTesourariaForm();
            sc.Show();
        }

        private void fluxoDeCaixaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FluxoCaixaForm sc = new FluxoCaixaForm();
            sc.Show();
        }
    }
}