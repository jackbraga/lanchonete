namespace LanchoneteUDV
{
    partial class EstoqueEscalaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EstoqueEscalaForm));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.EstoqueComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ExcluirButton = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.NovoButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LimparButton = new System.Windows.Forms.Button();
            this.EditarButton = new System.Windows.Forms.Button();
            this.SalvarButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ObservacaoTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.QtdVendaTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ProdutosComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EstoqueEscalaDataGridView = new System.Windows.Forms.DataGridView();
            this.CompletoButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EstoqueEscalaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.CompletoButton);
            this.groupBox3.Controls.Add(this.IDTextBox);
            this.groupBox3.Controls.Add(this.EstoqueComboBox);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.ExcluirButton);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.NovoButton);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.LimparButton);
            this.groupBox3.Controls.Add(this.EditarButton);
            this.groupBox3.Controls.Add(this.SalvarButton);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.ObservacaoTextBox);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.QtdVendaTextBox);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.ProdutosComboBox);
            this.groupBox3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(15, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(520, 226);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Definição de Estoque";
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(409, 192);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(100, 23);
            this.IDTextBox.TabIndex = 72;
            this.IDTextBox.Text = "0";
            // 
            // EstoqueComboBox
            // 
            this.EstoqueComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.EstoqueComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.EstoqueComboBox.BackColor = System.Drawing.SystemColors.Info;
            this.EstoqueComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.EstoqueComboBox.Enabled = false;
            this.EstoqueComboBox.FormattingEnabled = true;
            this.EstoqueComboBox.Items.AddRange(new object[] {
            "Anual",
            "Escala",
            "Extra"});
            this.EstoqueComboBox.Location = new System.Drawing.Point(271, 48);
            this.EstoqueComboBox.Name = "EstoqueComboBox";
            this.EstoqueComboBox.Size = new System.Drawing.Size(94, 26);
            this.EstoqueComboBox.TabIndex = 71;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 18);
            this.label3.TabIndex = 70;
            this.label3.Text = "Estoque Total";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(349, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 18);
            this.label8.TabIndex = 68;
            this.label8.Text = "Excluir";
            // 
            // ExcluirButton
            // 
            this.ExcluirButton.AutoSize = true;
            this.ExcluirButton.BackColor = System.Drawing.SystemColors.Info;
            this.ExcluirButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExcluirButton.BackgroundImage")));
            this.ExcluirButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ExcluirButton.Enabled = false;
            this.ExcluirButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ExcluirButton.FlatAppearance.BorderSize = 0;
            this.ExcluirButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExcluirButton.Location = new System.Drawing.Point(345, 147);
            this.ExcluirButton.Name = "ExcluirButton";
            this.ExcluirButton.Size = new System.Drawing.Size(54, 45);
            this.ExcluirButton.TabIndex = 67;
            this.ExcluirButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ExcluirButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ExcluirButton.UseVisualStyleBackColor = false;
            this.ExcluirButton.Click += new System.EventHandler(this.ExcluirButton_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(112, 195);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 18);
            this.label14.TabIndex = 66;
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
            this.NovoButton.Location = new System.Drawing.Point(105, 147);
            this.NovoButton.Name = "NovoButton";
            this.NovoButton.Size = new System.Drawing.Size(54, 45);
            this.NovoButton.TabIndex = 65;
            this.NovoButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NovoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.NovoButton.UseVisualStyleBackColor = false;
            this.NovoButton.Click += new System.EventHandler(this.NovoButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(289, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 18);
            this.label7.TabIndex = 64;
            this.label7.Text = "Limpar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 18);
            this.label4.TabIndex = 62;
            this.label4.Text = "Editar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(171, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 18);
            this.label6.TabIndex = 60;
            this.label6.Text = "Salvar";
            // 
            // LimparButton
            // 
            this.LimparButton.AutoSize = true;
            this.LimparButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LimparButton.BackgroundImage")));
            this.LimparButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.LimparButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.LimparButton.FlatAppearance.BorderSize = 0;
            this.LimparButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LimparButton.Location = new System.Drawing.Point(285, 147);
            this.LimparButton.Name = "LimparButton";
            this.LimparButton.Size = new System.Drawing.Size(54, 45);
            this.LimparButton.TabIndex = 63;
            this.LimparButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LimparButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.LimparButton.UseVisualStyleBackColor = true;
            this.LimparButton.Click += new System.EventHandler(this.LimparButton_Click);
            // 
            // EditarButton
            // 
            this.EditarButton.AutoSize = true;
            this.EditarButton.BackColor = System.Drawing.SystemColors.Info;
            this.EditarButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EditarButton.BackgroundImage")));
            this.EditarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.EditarButton.Enabled = false;
            this.EditarButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.EditarButton.FlatAppearance.BorderSize = 0;
            this.EditarButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EditarButton.Location = new System.Drawing.Point(225, 147);
            this.EditarButton.Name = "EditarButton";
            this.EditarButton.Size = new System.Drawing.Size(54, 45);
            this.EditarButton.TabIndex = 61;
            this.EditarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EditarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.EditarButton.UseVisualStyleBackColor = false;
            this.EditarButton.Click += new System.EventHandler(this.EditarButton_Click);
            // 
            // SalvarButton
            // 
            this.SalvarButton.AutoSize = true;
            this.SalvarButton.BackColor = System.Drawing.SystemColors.Info;
            this.SalvarButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SalvarButton.BackgroundImage")));
            this.SalvarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SalvarButton.Enabled = false;
            this.SalvarButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SalvarButton.FlatAppearance.BorderSize = 0;
            this.SalvarButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SalvarButton.Location = new System.Drawing.Point(165, 147);
            this.SalvarButton.Name = "SalvarButton";
            this.SalvarButton.Size = new System.Drawing.Size(54, 45);
            this.SalvarButton.TabIndex = 59;
            this.SalvarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SalvarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.SalvarButton.UseVisualStyleBackColor = false;
            this.SalvarButton.Click += new System.EventHandler(this.SalvarButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 18);
            this.label5.TabIndex = 58;
            this.label5.Text = "Observação";
            // 
            // ObservacaoTextBox
            // 
            this.ObservacaoTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ObservacaoTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.ObservacaoTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.ObservacaoTextBox.Enabled = false;
            this.ObservacaoTextBox.Location = new System.Drawing.Point(6, 102);
            this.ObservacaoTextBox.MaxLength = 150;
            this.ObservacaoTextBox.Multiline = true;
            this.ObservacaoTextBox.Name = "ObservacaoTextBox";
            this.ObservacaoTextBox.Size = new System.Drawing.Size(503, 39);
            this.ObservacaoTextBox.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(364, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 18);
            this.label1.TabIndex = 54;
            this.label1.Text = "Quantidade para Venda";
            // 
            // QtdVendaTextBox
            // 
            this.QtdVendaTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.QtdVendaTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.QtdVendaTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.QtdVendaTextBox.Enabled = false;
            this.QtdVendaTextBox.Location = new System.Drawing.Point(371, 48);
            this.QtdVendaTextBox.MaxLength = 3;
            this.QtdVendaTextBox.Name = "QtdVendaTextBox";
            this.QtdVendaTextBox.ShortcutsEnabled = false;
            this.QtdVendaTextBox.Size = new System.Drawing.Size(93, 23);
            this.QtdVendaTextBox.TabIndex = 53;
            this.QtdVendaTextBox.Text = "0";
            this.QtdVendaTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.QtdVendaTextBox_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 18);
            this.label9.TabIndex = 52;
            this.label9.Text = "Produto";
            // 
            // ProdutosComboBox
            // 
            this.ProdutosComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ProdutosComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ProdutosComboBox.BackColor = System.Drawing.SystemColors.Info;
            this.ProdutosComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProdutosComboBox.Enabled = false;
            this.ProdutosComboBox.FormattingEnabled = true;
            this.ProdutosComboBox.Items.AddRange(new object[] {
            "Anual",
            "Escala",
            "Extra"});
            this.ProdutosComboBox.Location = new System.Drawing.Point(6, 48);
            this.ProdutosComboBox.Name = "ProdutosComboBox";
            this.ProdutosComboBox.Size = new System.Drawing.Size(260, 26);
            this.ProdutosComboBox.TabIndex = 51;
            this.ProdutosComboBox.SelectionChangeCommitted += new System.EventHandler(this.ProdutosComboBox_SelectionChangeCommitted);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.EstoqueEscalaDataGridView);
            this.groupBox1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(15, 244);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(520, 487);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estoque da Escala";
            // 
            // EstoqueEscalaDataGridView
            // 
            this.EstoqueEscalaDataGridView.AllowUserToAddRows = false;
            this.EstoqueEscalaDataGridView.AllowUserToDeleteRows = false;
            this.EstoqueEscalaDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan;
            this.EstoqueEscalaDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.EstoqueEscalaDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EstoqueEscalaDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.EstoqueEscalaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EstoqueEscalaDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.EstoqueEscalaDataGridView.Location = new System.Drawing.Point(6, 22);
            this.EstoqueEscalaDataGridView.MultiSelect = false;
            this.EstoqueEscalaDataGridView.Name = "EstoqueEscalaDataGridView";
            this.EstoqueEscalaDataGridView.ReadOnly = true;
            this.EstoqueEscalaDataGridView.RowHeadersVisible = false;
            this.EstoqueEscalaDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EstoqueEscalaDataGridView.RowTemplate.Height = 25;
            this.EstoqueEscalaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EstoqueEscalaDataGridView.Size = new System.Drawing.Size(503, 459);
            this.EstoqueEscalaDataGridView.TabIndex = 0;
            this.EstoqueEscalaDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EstoqueEscalaDataGridView_CellDoubleClick);
            // 
            // CompletoButton
            // 
            this.CompletoButton.AutoSize = true;
            this.CompletoButton.BackColor = System.Drawing.SystemColors.Window;
            this.CompletoButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CompletoButton.BackgroundImage")));
            this.CompletoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CompletoButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.CompletoButton.FlatAppearance.BorderSize = 0;
            this.CompletoButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CompletoButton.Location = new System.Drawing.Point(6, 147);
            this.CompletoButton.Name = "CompletoButton";
            this.CompletoButton.Size = new System.Drawing.Size(54, 45);
            this.CompletoButton.TabIndex = 73;
            this.CompletoButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CompletoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.CompletoButton.UseVisualStyleBackColor = false;
            this.CompletoButton.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 18);
            this.label2.TabIndex = 74;
            this.label2.Text = "Completo";
            this.label2.Visible = false;
            // 
            // EstoqueEscalaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(543, 743);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EstoqueEscalaForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estoque da Escala";
            this.Load += new System.EventHandler(this.EstoqueEscalaForm_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EstoqueEscalaDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox3;
        private ComboBox ProdutosComboBox;
        private Label label9;
        private TextBox QtdVendaTextBox;
        private Label label1;
        private GroupBox groupBox1;
        private DataGridView EstoqueEscalaDataGridView;
        private Label label5;
        private TextBox ObservacaoTextBox;
        private Label label7;
        private Label label4;
        private Label label6;
        private Button LimparButton;
        private Button EditarButton;
        private Button SalvarButton;
        private Label label14;
        private Button NovoButton;
        private Label label8;
        private Button ExcluirButton;
        private Label label3;
        private ComboBox EstoqueComboBox;
        private TextBox IDTextBox;
        private Label label2;
        private Button CompletoButton;
    }
}