namespace LanchoneteUDV
{
    partial class ComprasForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComprasForm));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.FiltroComboBox = new System.Windows.Forms.ComboBox();
            this.PesquisaTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ComprasDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ObservacaoTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TipoEntradaComboBox = new System.Windows.Forms.ComboBox();
            this.NomeLabel = new System.Windows.Forms.Label();
            this.FixarNomecheckBox = new System.Windows.Forms.CheckBox();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.DataCompraDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.NovoButton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.QuantidadeTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.CompradoPorTextBox = new System.Windows.Forms.TextBox();
            this.PrecoTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ProdutoComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LimparButton = new System.Windows.Forms.Button();
            this.ExcluirButton = new System.Windows.Forms.Button();
            this.EditarButton = new System.Windows.Forms.Button();
            this.SalvarButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComprasDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.FiltroComboBox);
            this.groupBox2.Controls.Add(this.PesquisaTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.ComprasDataGridView);
            this.groupBox2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(12, 334);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(723, 383);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Consulta";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(272, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 18);
            this.label9.TabIndex = 17;
            this.label9.Text = "Filtro";
            // 
            // FiltroComboBox
            // 
            this.FiltroComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FiltroComboBox.FormattingEnabled = true;
            this.FiltroComboBox.Items.AddRange(new object[] {
            "Comprado Por"});
            this.FiltroComboBox.Location = new System.Drawing.Point(272, 48);
            this.FiltroComboBox.Name = "FiltroComboBox";
            this.FiltroComboBox.Size = new System.Drawing.Size(212, 26);
            this.FiltroComboBox.TabIndex = 16;
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
            // ComprasDataGridView
            // 
            this.ComprasDataGridView.AllowUserToAddRows = false;
            this.ComprasDataGridView.AllowUserToDeleteRows = false;
            this.ComprasDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan;
            this.ComprasDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ComprasDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ComprasDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ComprasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ComprasDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.ComprasDataGridView.Location = new System.Drawing.Point(6, 78);
            this.ComprasDataGridView.MultiSelect = false;
            this.ComprasDataGridView.Name = "ComprasDataGridView";
            this.ComprasDataGridView.ReadOnly = true;
            this.ComprasDataGridView.RowHeadersVisible = false;
            this.ComprasDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ComprasDataGridView.RowTemplate.Height = 25;
            this.ComprasDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ComprasDataGridView.Size = new System.Drawing.Size(711, 295);
            this.ComprasDataGridView.TabIndex = 0;
            this.ComprasDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ComprasDataGridView_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.ObservacaoTextBox);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.TipoEntradaComboBox);
            this.groupBox1.Controls.Add(this.NomeLabel);
            this.groupBox1.Controls.Add(this.FixarNomecheckBox);
            this.groupBox1.Controls.Add(this.IdTextBox);
            this.groupBox1.Controls.Add(this.DataCompraDateTimePicker);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.NovoButton);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.QuantidadeTextBox);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.CompradoPorTextBox);
            this.groupBox1.Controls.Add(this.PrecoTextBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.ProdutoComboBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.LimparButton);
            this.groupBox1.Controls.Add(this.ExcluirButton);
            this.groupBox1.Controls.Add(this.EditarButton);
            this.groupBox1.Controls.Add(this.SalvarButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(723, 316);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de Compras/Entradas no Estoque";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 148);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 18);
            this.label11.TabIndex = 35;
            this.label11.Text = "Observação";
            // 
            // ObservacaoTextBox
            // 
            this.ObservacaoTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.ObservacaoTextBox.Enabled = false;
            this.ObservacaoTextBox.Location = new System.Drawing.Point(9, 169);
            this.ObservacaoTextBox.MaxLength = 200;
            this.ObservacaoTextBox.Multiline = true;
            this.ObservacaoTextBox.Name = "ObservacaoTextBox";
            this.ObservacaoTextBox.Size = new System.Drawing.Size(708, 54);
            this.ObservacaoTextBox.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 18);
            this.label10.TabIndex = 33;
            this.label10.Text = "Tipo de Entrada";
            // 
            // TipoEntradaComboBox
            // 
            this.TipoEntradaComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TipoEntradaComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.TipoEntradaComboBox.BackColor = System.Drawing.SystemColors.Info;
            this.TipoEntradaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoEntradaComboBox.Enabled = false;
            this.TipoEntradaComboBox.FormattingEnabled = true;
            this.TipoEntradaComboBox.Items.AddRange(new object[] {
            "Compra",
            "Doação",
            "Ajuste no Estoque"});
            this.TipoEntradaComboBox.Location = new System.Drawing.Point(9, 110);
            this.TipoEntradaComboBox.Name = "TipoEntradaComboBox";
            this.TipoEntradaComboBox.Size = new System.Drawing.Size(152, 26);
            this.TipoEntradaComboBox.TabIndex = 2;
            // 
            // NomeLabel
            // 
            this.NomeLabel.AutoSize = true;
            this.NomeLabel.Location = new System.Drawing.Point(546, 264);
            this.NomeLabel.Name = "NomeLabel";
            this.NomeLabel.Size = new System.Drawing.Size(49, 18);
            this.NomeLabel.TabIndex = 31;
            this.NomeLabel.Text = "label10";
            this.NomeLabel.Visible = false;
            // 
            // FixarNomecheckBox
            // 
            this.FixarNomecheckBox.AutoSize = true;
            this.FixarNomecheckBox.Font = new System.Drawing.Font("Trebuchet MS", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FixarNomecheckBox.Location = new System.Drawing.Point(316, 135);
            this.FixarNomecheckBox.Name = "FixarNomecheckBox";
            this.FixarNomecheckBox.Size = new System.Drawing.Size(75, 19);
            this.FixarNomecheckBox.TabIndex = 30;
            this.FixarNomecheckBox.Text = "Fixar nome";
            this.FixarNomecheckBox.UseVisualStyleBackColor = true;
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(63, 241);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(100, 23);
            this.IdTextBox.TabIndex = 29;
            this.IdTextBox.Visible = false;
            // 
            // DataCompraDateTimePicker
            // 
            this.DataCompraDateTimePicker.Enabled = false;
            this.DataCompraDateTimePicker.Location = new System.Drawing.Point(9, 52);
            this.DataCompraDateTimePicker.Name = "DataCompraDateTimePicker";
            this.DataCompraDateTimePicker.Size = new System.Drawing.Size(276, 23);
            this.DataCompraDateTimePicker.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(219, 289);
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
            this.NovoButton.Location = new System.Drawing.Point(212, 241);
            this.NovoButton.Name = "NovoButton";
            this.NovoButton.Size = new System.Drawing.Size(54, 45);
            this.NovoButton.TabIndex = 7;
            this.NovoButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NovoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.NovoButton.UseVisualStyleBackColor = false;
            this.NovoButton.Click += new System.EventHandler(this.NovoButton_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(536, 89);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 18);
            this.label12.TabIndex = 23;
            this.label12.Text = "Quantidade";
            // 
            // QuantidadeTextBox
            // 
            this.QuantidadeTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.QuantidadeTextBox.Enabled = false;
            this.QuantidadeTextBox.Location = new System.Drawing.Point(536, 110);
            this.QuantidadeTextBox.MaxLength = 4;
            this.QuantidadeTextBox.Name = "QuantidadeTextBox";
            this.QuantidadeTextBox.ShortcutsEnabled = false;
            this.QuantidadeTextBox.Size = new System.Drawing.Size(94, 23);
            this.QuantidadeTextBox.TabIndex = 5;
            this.QuantidadeTextBox.Text = "0";
            this.QuantidadeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.QuantidadeTextBox_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(167, 89);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(133, 18);
            this.label13.TabIndex = 21;
            this.label13.Text = "Comprado/Doado por";
            // 
            // CompradoPorTextBox
            // 
            this.CompradoPorTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CompradoPorTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.CompradoPorTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.CompradoPorTextBox.Enabled = false;
            this.CompradoPorTextBox.Location = new System.Drawing.Point(167, 110);
            this.CompradoPorTextBox.MaxLength = 150;
            this.CompradoPorTextBox.Name = "CompradoPorTextBox";
            this.CompradoPorTextBox.Size = new System.Drawing.Size(255, 23);
            this.CompradoPorTextBox.TabIndex = 3;
            // 
            // PrecoTextBox
            // 
            this.PrecoTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.PrecoTextBox.Enabled = false;
            this.PrecoTextBox.Location = new System.Drawing.Point(440, 110);
            this.PrecoTextBox.MaxLength = 10;
            this.PrecoTextBox.Name = "PrecoTextBox";
            this.PrecoTextBox.Size = new System.Drawing.Size(90, 23);
            this.PrecoTextBox.TabIndex = 4;
            this.PrecoTextBox.Text = "0";
            this.PrecoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PrecoTextBox_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(440, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 18);
            this.label8.TabIndex = 13;
            this.label8.Text = "Preço Unitário";
            // 
            // ProdutoComboBox
            // 
            this.ProdutoComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ProdutoComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ProdutoComboBox.BackColor = System.Drawing.SystemColors.Info;
            this.ProdutoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProdutoComboBox.Enabled = false;
            this.ProdutoComboBox.FormattingEnabled = true;
            this.ProdutoComboBox.Location = new System.Drawing.Point(291, 49);
            this.ProdutoComboBox.Name = "ProdutoComboBox";
            this.ProdutoComboBox.Size = new System.Drawing.Size(426, 26);
            this.ProdutoComboBox.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(456, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "Limpar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(396, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Excluir";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(337, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Editar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(278, 289);
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
            this.LimparButton.Location = new System.Drawing.Point(452, 241);
            this.LimparButton.Name = "LimparButton";
            this.LimparButton.Size = new System.Drawing.Size(54, 45);
            this.LimparButton.TabIndex = 10;
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
            this.ExcluirButton.Location = new System.Drawing.Point(392, 241);
            this.ExcluirButton.Name = "ExcluirButton";
            this.ExcluirButton.Size = new System.Drawing.Size(54, 45);
            this.ExcluirButton.TabIndex = 9;
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
            this.EditarButton.Enabled = false;
            this.EditarButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.EditarButton.FlatAppearance.BorderSize = 0;
            this.EditarButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EditarButton.Location = new System.Drawing.Point(332, 241);
            this.EditarButton.Name = "EditarButton";
            this.EditarButton.Size = new System.Drawing.Size(54, 45);
            this.EditarButton.TabIndex = 8;
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
            this.SalvarButton.Location = new System.Drawing.Point(272, 241);
            this.SalvarButton.Name = "SalvarButton";
            this.SalvarButton.Size = new System.Drawing.Size(54, 45);
            this.SalvarButton.TabIndex = 7;
            this.SalvarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SalvarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.SalvarButton.UseVisualStyleBackColor = false;
            this.SalvarButton.Click += new System.EventHandler(this.SalvarButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Produto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data da Compra/Entrada";
            // 
            // ComprasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(743, 729);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ComprasForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compras";
            this.Load += new System.EventHandler(this.ComprasForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComprasDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox2;
        private TextBox PesquisaTextBox;
        private Label label3;
        private DataGridView ComprasDataGridView;
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
        private Label label1;
        private Label label8;
        private ComboBox ProdutoComboBox;
        private TextBox PrecoTextBox;
        private Label label13;
        private TextBox CompradoPorTextBox;
        private Label label12;
        private TextBox QuantidadeTextBox;
        private Label label14;
        private Button NovoButton;
        private DateTimePicker DataCompraDateTimePicker;
        private TextBox IdTextBox;
        private Label label9;
        private ComboBox FiltroComboBox;
        private CheckBox FixarNomecheckBox;
        private Label NomeLabel;
        private Label label10;
        private ComboBox TipoEntradaComboBox;
        private Label label11;
        private TextBox ObservacaoTextBox;
    }
}