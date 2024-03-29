

using LanchoneteUDV.Application.Interfaces;
using LanchoneteUDV.Services.Service;
using OfficeOpenXml;

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
        private readonly IParceriasService _parceriasService;

        public PrincipalForm(ICategoriaService categoriaService, IEscalaService escalaService, IProdutoService produtoService,
            ISocioService socioService, ICompraService compraService, IEstoqueEscalaService estoqueEscalaService, IVendaService vendaService, IVendasPedidoService vendasPedidoService,
            ICaixaService caixaService,IFinanceiroService financeiroService, IParceriasService parceriasService)
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
            _parceriasService = parceriasService;
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
            EscalasForm sc = new EscalasForm(_escalaService, _produtoService, _socioService, _estoqueEscalaService, _vendaService, _vendasPedidoService, _compraService);
            sc.Show();
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EstoqueForm sc = new EstoqueForm(_estoqueEscalaService, _compraService);
            sc.Show();
        }

        private async void gerarRepasseTesourariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RepasseTesourariaForm sc = new RepasseTesourariaForm(_escalaService,_financeiroService,_vendaService,_caixaService);
            sc.Show();
        }

        private void fluxoDeCaixaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FluxoCaixaForm sc = new FluxoCaixaForm(_caixaService);
            sc.Show();
        }

        private void gerarRecibosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void cadastroDeParceirosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ParceirosForm sc = new ParceirosForm(_parceriasService, _produtoService,_vendasPedidoService);
            sc.Show();
        }
    }
}