using LanchoneteUDV.Application.DTO;
using LanchoneteUDV.Application.Interfaces;

namespace LanchoneteUDV
{
    public partial class CategoriasForm : Form
    {
        private readonly ICategoriaService _categoriaService;
        Helper _helper = new Helper();
        public CategoriasForm(ICategoriaService categoriaService)
        {
            _categoriaService = categoriaService;
            InitializeComponent();
        }

        private void CategoriasForm_Load(object sender, EventArgs e)
        {
            Controls.Clear();
            InitializeComponent();
            RecarregaGrid();
        }

        private async void RecarregaGrid()
        {
            CategoriasDataGridView.DataSource =  _categoriaService.GetCategorias();
            CategoriasDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            CategoriasDataGridView.Columns[0].Visible = false;
            CategoriasDataGridView.Columns[1].MinimumWidth = 430;
        }
        private async void RecarregaGrid(string texto)
        {
            CategoriasDataGridView.DataSource =  _categoriaService.GetByName(texto);
            CategoriasDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            CategoriasDataGridView.Columns[0].Visible = false;
            CategoriasDataGridView.Columns[1].MinimumWidth = 430;
        }

        private void CategoriasDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = CategoriasDataGridView.CurrentRow.Index;

            IdTextBox.Text = CategoriasDataGridView.Rows[row].Cells[0].Value.ToString();
            DescricaoTextBox.Text = CategoriasDataGridView.Rows[row].Cells[1].Value.ToString();
            _helper.Desabilita(DescricaoTextBox, IdTextBox, SalvarButton);
            _helper.Habilita(ExcluirButton, EditarButton);
        }
        private  void LimparButton_Click(object sender, EventArgs e)
        {
            IdTextBox.Text = "0";
            DescricaoTextBox.Text = "";
            _helper.Habilita(DescricaoTextBox, EditarButton, SalvarButton);
            _helper.Desabilita(ExcluirButton, EditarButton);
        }

        private  void SalvarButton_Click(object sender, EventArgs e)
        {
            try
            {


                if (!string.IsNullOrEmpty(DescricaoTextBox.Text))
                {
                    if (Convert.ToInt32(IdTextBox.Text) > 0)
                    {
                         _categoriaService.Update(new Application.DTO.CategoriaDTO
                        {
                            Id = Convert.ToInt32(IdTextBox.Text),
                            Descricao = DescricaoTextBox.Text.Trim()
                        });
                    }
                    else
                    {
                         _categoriaService.Add(new Application.DTO.CategoriaDTO
                        {
                            Id = Convert.ToInt32(IdTextBox.Text),
                            Descricao = DescricaoTextBox.Text.Trim()
                        });
                    }

                    RecarregaGrid();
                    MessageBox.Show("Categoria cadastrada com sucesso!", "Sucesso!", MessageBoxButtons.OK);
                    LimparButton_Click(sender, e);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Falha!", MessageBoxButtons.OK);
            }
        }

        private void EditarButton_Click(object sender, EventArgs e)
        {
            _helper.Habilita(DescricaoTextBox, SalvarButton);
            _helper.Desabilita(EditarButton);
        }

        private void PesquisaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            RecarregaGrid(PesquisaTextBox.Text);
        }

        private  void ExcluirButton_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Deseja realmente excluir a categoria: " + DescricaoTextBox.Text, "ATENÇÃO!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                     _categoriaService.Remove(new CategoriaDTO
                    {
                        Id = Convert.ToInt32(IdTextBox.Text),
                        Descricao = DescricaoTextBox.Text
                    });
                    RecarregaGrid();
                    LimparButton_Click(sender, e);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Falha!", MessageBoxButtons.OK);
            }
        }

    }
}
