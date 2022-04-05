namespace LanchoneteUDV
{
    partial class ProdutosForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProdutosForm));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PesquisaTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ProdutosDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.NovoButton = new System.Windows.Forms.Button();
            this.ProdutoVendaCheckBox = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.EstoqueInicialTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.PrecoCustoUnitarioTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.QtdCaixaTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.PrecoVendaTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.PrecoCustoCaixaTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CategoriaComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LimparButton = new System.Windows.Forms.Button();
            this.ExcluirButton = new System.Windows.Forms.Button();
            this.EditarButton = new System.Windows.Forms.Button();
            this.SalvarButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.DescricaoTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProdutosDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PesquisaTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.ProdutosDataGridView);
            this.groupBox2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(12, 235);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(961, 383);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Consulta";
            // 
            // PesquisaTextBox
            // 
            this.PesquisaTextBox.Location = new System.Drawing.Point(6, 49);
            this.PesquisaTextBox.MaxLength = 150;
            this.PesquisaTextBox.Name = "PesquisaTextBox";
            this.PesquisaTextBox.Size = new System.Drawing.Size(260, 23);
            this.PesquisaTextBox.TabIndex = 15;
            this.PesquisaTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PesquisaTextBox_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Pesquisa";
            // 
            // ProdutosDataGridView
            // 
            this.ProdutosDataGridView.AllowUserToAddRows = false;
            this.ProdutosDataGridView.AllowUserToDeleteRows = false;
            this.ProdutosDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan;
            this.ProdutosDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ProdutosDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProdutosDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ProdutosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProdutosDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.ProdutosDataGridView.Location = new System.Drawing.Point(6, 75);
            this.ProdutosDataGridView.MultiSelect = false;
            this.ProdutosDataGridView.Name = "ProdutosDataGridView";
            this.ProdutosDataGridView.ReadOnly = true;
            this.ProdutosDataGridView.RowHeadersVisible = false;
            this.ProdutosDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProdutosDataGridView.RowTemplate.Height = 25;
            this.ProdutosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProdutosDataGridView.Size = new System.Drawing.Size(949, 295);
            this.ProdutosDataGridView.TabIndex = 0;
            this.ProdutosDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProdutosDataGridView_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.NovoButton);
            this.groupBox1.Controls.Add(this.ProdutoVendaCheckBox);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.EstoqueInicialTextBox);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.PrecoCustoUnitarioTextBox);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.QtdCaixaTextBox);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.PrecoVendaTextBox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.PrecoCustoCaixaTextBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.CategoriaComboBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.LimparButton);
            this.groupBox1.Controls.Add(this.ExcluirButton);
            this.groupBox1.Controls.Add(this.EditarButton);
            this.groupBox1.Controls.Add(this.SalvarButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.DescricaoTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.IdTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(955, 217);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro de Produtos";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(303, 189);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 18);
            this.label14.TabIndex = 27;
            this.label14.Text = "Novo";
            // 
            // NovoButton
            // 
            this.NovoButton.AutoSize = true;
            this.NovoButton.BackColor = System.Drawing.SystemColors.Window;
            this.NovoButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NovoButton.BackgroundImage")));
            this.NovoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.NovoButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.NovoButton.FlatAppearance.BorderSize = 0;
            this.NovoButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NovoButton.Location = new System.Drawing.Point(296, 141);
            this.NovoButton.Name = "NovoButton";
            this.NovoButton.Size = new System.Drawing.Size(54, 45);
            this.NovoButton.TabIndex = 9;
            this.NovoButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NovoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.NovoButton.UseVisualStyleBackColor = false;
            this.NovoButton.Click += new System.EventHandler(this.NovoButton_Click);
            // 
            // ProdutoVendaCheckBox
            // 
            this.ProdutoVendaCheckBox.AutoSize = true;
            this.ProdutoVendaCheckBox.BackColor = System.Drawing.SystemColors.Info;
            this.ProdutoVendaCheckBox.Enabled = false;
            this.ProdutoVendaCheckBox.Location = new System.Drawing.Point(662, 112);
            this.ProdutoVendaCheckBox.Name = "ProdutoVendaCheckBox";
            this.ProdutoVendaCheckBox.Size = new System.Drawing.Size(127, 22);
            this.ProdutoVendaCheckBox.TabIndex = 7;
            this.ProdutoVendaCheckBox.Text = "Produto de Venda";
            this.ProdutoVendaCheckBox.UseVisualStyleBackColor = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(552, 91);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 18);
            this.label12.TabIndex = 23;
            this.label12.Text = "Estoque inicial";
            // 
            // EstoqueInicialTextBox
            // 
            this.EstoqueInicialTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.EstoqueInicialTextBox.Enabled = false;
            this.EstoqueInicialTextBox.Location = new System.Drawing.Point(553, 112);
            this.EstoqueInicialTextBox.MaxLength = 150;
            this.EstoqueInicialTextBox.Name = "EstoqueInicialTextBox";
            this.EstoqueInicialTextBox.Size = new System.Drawing.Size(94, 23);
            this.EstoqueInicialTextBox.TabIndex = 6;
            this.EstoqueInicialTextBox.Text = "0";
            this.EstoqueInicialTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EstoqueInicialTextBox_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(295, 91);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(144, 18);
            this.label13.TabIndex = 21;
            this.label13.Text = "Preço de Custo unitário";
            // 
            // PrecoCustoUnitarioTextBox
            // 
            this.PrecoCustoUnitarioTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.PrecoCustoUnitarioTextBox.Enabled = false;
            this.PrecoCustoUnitarioTextBox.Location = new System.Drawing.Point(296, 112);
            this.PrecoCustoUnitarioTextBox.MaxLength = 150;
            this.PrecoCustoUnitarioTextBox.Name = "PrecoCustoUnitarioTextBox";
            this.PrecoCustoUnitarioTextBox.Size = new System.Drawing.Size(147, 23);
            this.PrecoCustoUnitarioTextBox.TabIndex = 4;
            this.PrecoCustoUnitarioTextBox.Text = "0";
            this.PrecoCustoUnitarioTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PrecoCustoUnitarioTextBox_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(156, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(133, 18);
            this.label11.TabIndex = 19;
            this.label11.Text = "Quantidade por caixa";
            // 
            // QtdCaixaTextBox
            // 
            this.QtdCaixaTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.QtdCaixaTextBox.Enabled = false;
            this.QtdCaixaTextBox.Location = new System.Drawing.Point(159, 112);
            this.QtdCaixaTextBox.MaxLength = 150;
            this.QtdCaixaTextBox.Name = "QtdCaixaTextBox";
            this.QtdCaixaTextBox.Size = new System.Drawing.Size(130, 23);
            this.QtdCaixaTextBox.TabIndex = 3;
            this.QtdCaixaTextBox.Text = "0";
            this.QtdCaixaTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.QtdCaixaTextBox_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(451, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 18);
            this.label10.TabIndex = 17;
            this.label10.Text = "Preço de Venda";
            // 
            // PrecoVendaTextBox
            // 
            this.PrecoVendaTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.PrecoVendaTextBox.Enabled = false;
            this.PrecoVendaTextBox.Location = new System.Drawing.Point(452, 112);
            this.PrecoVendaTextBox.MaxLength = 150;
            this.PrecoVendaTextBox.Name = "PrecoVendaTextBox";
            this.PrecoVendaTextBox.Size = new System.Drawing.Size(94, 23);
            this.PrecoVendaTextBox.TabIndex = 5;
            this.PrecoVendaTextBox.Text = "0";
            this.PrecoVendaTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PrecoVendaTextBox_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 18);
            this.label9.TabIndex = 15;
            this.label9.Text = "Preço de Custo da caixa";
            // 
            // PrecoCustoCaixaTextBox
            // 
            this.PrecoCustoCaixaTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.PrecoCustoCaixaTextBox.Enabled = false;
            this.PrecoCustoCaixaTextBox.Location = new System.Drawing.Point(9, 112);
            this.PrecoCustoCaixaTextBox.MaxLength = 150;
            this.PrecoCustoCaixaTextBox.Name = "PrecoCustoCaixaTextBox";
            this.PrecoCustoCaixaTextBox.Size = new System.Drawing.Size(144, 23);
            this.PrecoCustoCaixaTextBox.TabIndex = 2;
            this.PrecoCustoCaixaTextBox.Text = "0";
            this.PrecoCustoCaixaTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CustoCaixaTextBox_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(609, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 18);
            this.label8.TabIndex = 13;
            this.label8.Text = "Categoria";
            // 
            // CategoriaComboBox
            // 
            this.CategoriaComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CategoriaComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CategoriaComboBox.BackColor = System.Drawing.SystemColors.Info;
            this.CategoriaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoriaComboBox.Enabled = false;
            this.CategoriaComboBox.FormattingEnabled = true;
            this.CategoriaComboBox.Location = new System.Drawing.Point(609, 51);
            this.CategoriaComboBox.Name = "CategoriaComboBox";
            this.CategoriaComboBox.Size = new System.Drawing.Size(209, 26);
            this.CategoriaComboBox.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(540, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "Limpar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(480, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Excluir";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(421, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Editar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(362, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Salvar";
            // 
            // LimparButton
            // 
            this.LimparButton.AutoSize = true;
            this.LimparButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LimparButton.BackgroundImage")));
            this.LimparButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.LimparButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.LimparButton.FlatAppearance.BorderSize = 0;
            this.LimparButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LimparButton.Location = new System.Drawing.Point(536, 141);
            this.LimparButton.Name = "LimparButton";
            this.LimparButton.Size = new System.Drawing.Size(54, 45);
            this.LimparButton.TabIndex = 12;
            this.LimparButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LimparButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.LimparButton.UseVisualStyleBackColor = true;
            this.LimparButton.Click += new System.EventHandler(this.LimparButton_Click);
            // 
            // ExcluirButton
            // 
            this.ExcluirButton.AutoSize = true;
            this.ExcluirButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExcluirButton.BackgroundImage")));
            this.ExcluirButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ExcluirButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ExcluirButton.FlatAppearance.BorderSize = 0;
            this.ExcluirButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExcluirButton.Location = new System.Drawing.Point(476, 141);
            this.ExcluirButton.Name = "ExcluirButton";
            this.ExcluirButton.Size = new System.Drawing.Size(54, 45);
            this.ExcluirButton.TabIndex = 11;
            this.ExcluirButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ExcluirButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ExcluirButton.UseVisualStyleBackColor = true;
            this.ExcluirButton.Click += new System.EventHandler(this.ExcluirButton_Click);
            // 
            // EditarButton
            // 
            this.EditarButton.AutoSize = true;
            this.EditarButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EditarButton.BackgroundImage")));
            this.EditarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.EditarButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.EditarButton.FlatAppearance.BorderSize = 0;
            this.EditarButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EditarButton.Location = new System.Drawing.Point(416, 141);
            this.EditarButton.Name = "EditarButton";
            this.EditarButton.Size = new System.Drawing.Size(54, 45);
            this.EditarButton.TabIndex = 10;
            this.EditarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EditarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.EditarButton.UseVisualStyleBackColor = true;
            this.EditarButton.Click += new System.EventHandler(this.EditarButton_Click);
            // 
            // SalvarButton
            // 
            this.SalvarButton.AutoSize = true;
            this.SalvarButton.BackColor = System.Drawing.SystemColors.Window;
            this.SalvarButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SalvarButton.BackgroundImage")));
            this.SalvarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SalvarButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SalvarButton.FlatAppearance.BorderSize = 0;
            this.SalvarButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SalvarButton.Location = new System.Drawing.Point(356, 141);
            this.SalvarButton.Name = "SalvarButton";
            this.SalvarButton.Size = new System.Drawing.Size(54, 45);
            this.SalvarButton.TabIndex = 8;
            this.SalvarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SalvarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.SalvarButton.UseVisualStyleBackColor = false;
            this.SalvarButton.Click += new System.EventHandler(this.SalvarButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descrição";
            // 
            // DescricaoTextBox
            // 
            this.DescricaoTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.DescricaoTextBox.Enabled = false;
            this.DescricaoTextBox.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DescricaoTextBox.Location = new System.Drawing.Point(65, 51);
            this.DescricaoTextBox.MaxLength = 100;
            this.DescricaoTextBox.Name = "DescricaoTextBox";
            this.DescricaoTextBox.Size = new System.Drawing.Size(538, 25);
            this.DescricaoTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // IdTextBox
            // 
            this.IdTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.IdTextBox.Enabled = false;
            this.IdTextBox.Location = new System.Drawing.Point(6, 51);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(53, 23);
            this.IdTextBox.TabIndex = 0;
            this.IdTextBox.Text = "0";
            // 
            // ProdutosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(979, 624);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ProdutosForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos";
            this.Load += new System.EventHandler(this.ProdutosForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProdutosDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox2;
        private TextBox PesquisaTextBox;
        private Label label3;
        private DataGridView ProdutosDataGridView;
        private GroupBox groupBox1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button LimparButton;
        private Button ExcluirButton;
        private Button EditarButton;
        private Button SalvarButton;
        private Label label2;
        private TextBox DescricaoTextBox;
        private Label label1;
        private TextBox IdTextBox;
        private Label label8;
        private ComboBox CategoriaComboBox;
        private Label label9;
        private TextBox PrecoCustoCaixaTextBox;
        private Label label10;
        private TextBox PrecoVendaTextBox;
        private Label label11;
        private TextBox QtdCaixaTextBox;
        private Label label13;
        private TextBox PrecoCustoUnitarioTextBox;
        private Label label12;
        private TextBox EstoqueInicialTextBox;
        private CheckBox ProdutoVendaCheckBox;
        private Label label14;
        private Button NovoButton;
    }
}