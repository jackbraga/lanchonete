namespace LanchoneteUDV
{
    partial class ProdutosParceiroForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProdutosParceiroForm));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.PesquisaTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ProdutosParceirosDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.NovoButton = new System.Windows.Forms.Button();
            this.ProdutoVendaCheckBox = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.PrecoVendaTextBox = new System.Windows.Forms.TextBox();
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
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProdutosParceirosDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.PesquisaTextBox);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.ProdutosParceirosDataGridView);
            this.groupBox3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(3, 153);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(623, 404);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Consulta";
            // 
            // PesquisaTextBox
            // 
            this.PesquisaTextBox.Location = new System.Drawing.Point(6, 49);
            this.PesquisaTextBox.MaxLength = 150;
            this.PesquisaTextBox.Name = "PesquisaTextBox";
            this.PesquisaTextBox.Size = new System.Drawing.Size(260, 23);
            this.PesquisaTextBox.TabIndex = 6;
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
            // ProdutosParceirosDataGridView
            // 
            this.ProdutosParceirosDataGridView.AllowUserToAddRows = false;
            this.ProdutosParceirosDataGridView.AllowUserToDeleteRows = false;
            this.ProdutosParceirosDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan;
            this.ProdutosParceirosDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ProdutosParceirosDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProdutosParceirosDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ProdutosParceirosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProdutosParceirosDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.ProdutosParceirosDataGridView.Location = new System.Drawing.Point(6, 75);
            this.ProdutosParceirosDataGridView.Name = "ProdutosParceirosDataGridView";
            this.ProdutosParceirosDataGridView.ReadOnly = true;
            this.ProdutosParceirosDataGridView.RowHeadersVisible = false;
            this.ProdutosParceirosDataGridView.RowTemplate.Height = 25;
            this.ProdutosParceirosDataGridView.Size = new System.Drawing.Size(611, 322);
            this.ProdutosParceirosDataGridView.TabIndex = 0;
            this.ProdutosParceirosDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProdutosParceirosDataGridView_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.NovoButton);
            this.groupBox1.Controls.Add(this.ProdutoVendaCheckBox);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.PrecoVendaTextBox);
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
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(623, 144);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro de Produtos Parceiro";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(139, 120);
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
            this.NovoButton.Location = new System.Drawing.Point(132, 72);
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
            this.ProdutoVendaCheckBox.Location = new System.Drawing.Point(454, 40);
            this.ProdutoVendaCheckBox.Name = "ProdutoVendaCheckBox";
            this.ProdutoVendaCheckBox.Size = new System.Drawing.Size(105, 22);
            this.ProdutoVendaCheckBox.TabIndex = 7;
            this.ProdutoVendaCheckBox.Text = "Produto Ativo";
            this.ProdutoVendaCheckBox.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(353, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 18);
            this.label10.TabIndex = 17;
            this.label10.Text = "Preço de Venda";
            // 
            // PrecoVendaTextBox
            // 
            this.PrecoVendaTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.PrecoVendaTextBox.Enabled = false;
            this.PrecoVendaTextBox.Location = new System.Drawing.Point(354, 40);
            this.PrecoVendaTextBox.MaxLength = 150;
            this.PrecoVendaTextBox.Name = "PrecoVendaTextBox";
            this.PrecoVendaTextBox.Size = new System.Drawing.Size(94, 23);
            this.PrecoVendaTextBox.TabIndex = 5;
            this.PrecoVendaTextBox.Text = "0";
            this.PrecoVendaTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PrecoVendaTextBox_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(376, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "Limpar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(316, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Excluir";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(257, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Editar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(198, 120);
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
            this.LimparButton.Location = new System.Drawing.Point(372, 72);
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
            this.ExcluirButton.Location = new System.Drawing.Point(312, 72);
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
            this.EditarButton.Location = new System.Drawing.Point(252, 72);
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
            this.SalvarButton.Location = new System.Drawing.Point(192, 72);
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
            this.label2.Location = new System.Drawing.Point(6, 19);
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
            this.DescricaoTextBox.Location = new System.Drawing.Point(6, 40);
            this.DescricaoTextBox.MaxLength = 100;
            this.DescricaoTextBox.Name = "DescricaoTextBox";
            this.DescricaoTextBox.Size = new System.Drawing.Size(341, 25);
            this.DescricaoTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            this.label1.Visible = false;
            // 
            // IdTextBox
            // 
            this.IdTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.IdTextBox.Enabled = false;
            this.IdTextBox.Location = new System.Drawing.Point(6, 103);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(53, 23);
            this.IdTextBox.TabIndex = 0;
            this.IdTextBox.Text = "0";
            this.IdTextBox.Visible = false;
            // 
            // ProdutosParceiroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(630, 562);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ProdutosParceiroForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos Parceiros";
            this.Load += new System.EventHandler(this.ProdutosParceiroForm_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProdutosParceirosDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox3;
        private TextBox PesquisaTextBox;
        private Label label3;
        private DataGridView ProdutosParceirosDataGridView;
        private GroupBox groupBox1;
        private Label label14;
        private Button NovoButton;
        private CheckBox ProdutoVendaCheckBox;
        private Label label10;
        private TextBox PrecoVendaTextBox;
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
    }
}