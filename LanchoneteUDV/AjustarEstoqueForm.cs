using LanchoneteUDV.Application.DTO;
using LanchoneteUDV.Application.Interfaces;
using LanchoneteUDV.Application.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LanchoneteUDV
{
    public partial class AjustarEstoqueForm : Form
    {
        public int IdProduto { get; set; }
        public string DescricaoProduto { get; set; }
        private readonly IEstoqueEscalaService _estoqueEscalaService;
        private readonly ICompraService _compraService;

        public AjustarEstoqueForm(IEstoqueEscalaService estoqueEscalaService, ICompraService compraService)
        {
            _estoqueEscalaService = estoqueEscalaService;
            _compraService = compraService;
            InitializeComponent();

        }

        private void AjustarEstoqueForm_Load(object sender, EventArgs e)
        {
            IdProdutoTextBox.Text = IdProduto.ToString();
            DescricaoTextBox.Text = DescricaoProduto;
            EstoqueAtualTextBox.Text = _estoqueEscalaService.GetEstoqueProduto(IdProduto).ToString();
        }

        private void AdicionarButton_Click(object sender, EventArgs e)
        {
            AjustarEstoque(Convert.ToInt32(QuantidadeTextBox.Text),"adicionar");
            EstoqueAtualTextBox.Text = _estoqueEscalaService.GetEstoqueProduto(IdProduto).ToString();
        }



        private void RemoverButton_Click(object sender, EventArgs e)
        {
            AjustarEstoque(-1 * Convert.ToInt32(QuantidadeTextBox.Text),"remover");
            EstoqueAtualTextBox.Text = _estoqueEscalaService.GetEstoqueProduto(IdProduto).ToString();

        }

        private void QuantidadeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void AjustarEstoque(int quantidade, string acao)
        {
            if (quantidade == 0)
            {
                MessageBox.Show("Valor deve ser maior que 0 para ajustar o estoque!", "ATENÇÃO!", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show($"Deseja realmente {acao} a quantidade no estoque?", "ATENÇÃO!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var compra = new CompraDTO
                {
                    Quantidade = quantidade,
                    CompradoPor = "TELA AJUSTE ESTOQUE",
                    DataCompra = DateTime.Now.Date,
                    IdProduto = IdProduto,
                    PrecoUnitario = 0,
                    DescricaoProduto = "",
                    TipoEntrada = "Tela Ajuste Estoque",
                    Observacao = "Tela Ajuste Estoque"
                };
                _compraService.Add(compra);
            }
            MessageBox.Show("Ajuste realizado com sucesso!", "ATENÇÃO!", MessageBoxButtons.OK);
        }
    }
}
