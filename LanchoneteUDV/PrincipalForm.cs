

using LanchoneteUDV.Application.Interfaces;

namespace LanchoneteUDV
{
    public partial class PrincipalForm : Form
    {
        private readonly ICategoriaService _categoriaService;
        private readonly IEscalaService _escalaService;
        private readonly IProdutoService _produtoService;
        private readonly ISocioService _socioService;
        private readonly ICompraService _compraService;
        private readonly IEstoqueEscalaService _estoqueEscalaService;
        private readonly IVendaService _vendaService;
        private readonly IVendasPedidoService _vendasPedidoService;
        private readonly ICaixaService _caixaService;
        private readonly IFinanceiroService _financeiroService;
        public PrincipalForm(ICategoriaService categoriaService, IEscalaService escalaService, IProdutoService produtoService,
            ISocioService socioService, ICompraService compraService, IEstoqueEscalaService estoqueEscalaService, IVendaService vendaService, IVendasPedidoService vendasPedidoService,
            ICaixaService caixaService,IFinanceiroService financeiroService)
        {
            _categoriaService = categoriaService;
            _escalaService = escalaService;
            _produtoService = produtoService;
            _socioService = socioService;
            _compraService = compraService;
            _estoqueEscalaService = estoqueEscalaService;
            _vendaService = vendaService;
            _vendasPedidoService = vendasPedidoService;
            _caixaService = caixaService;
            _financeiroService = financeiroService;
            InitializeComponent();
        }

        private void cadastroSociosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SociosForm sc = new SociosForm(_socioService);
            sc.Show();
        }

        private void categoriasProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            CategoriasForm sc = new CategoriasForm(_categoriaService);
            sc.Show();
        }

        private void cadastroProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProdutosForm sc = new ProdutosForm(_produtoService, _categoriaService);
            sc.Show();
        }


        private void comprasProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ComprasForm sc = new ComprasForm(_compraService, _produtoService);
            sc.Show();
        }

        private void escalasDeVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EscalasForm sc = new EscalasForm(_escalaService, _produtoService, _socioService, _estoqueEscalaService, _vendaService, _vendasPedidoService);
            sc.Show();
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EstoqueForm sc = new EstoqueForm(_estoqueEscalaService);
            sc.Show();
        }

        private async void gerarRepasseTesourariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RepasseTesourariaForm sc = new RepasseTesourariaForm(_escalaService,_financeiroService,_vendaService);
            sc.Show();
        }

        private void fluxoDeCaixaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FluxoCaixaForm sc = new FluxoCaixaForm(_caixaService);
            sc.Show();
        }
    }
}