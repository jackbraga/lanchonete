namespace LanchoneteUDV
{
    partial class EscalasForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EscalasForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.AbrirEscalaButton = new System.Windows.Forms.Button();
            this.FinalizadaCheckBox = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ObservacaoTextBox = new System.Windows.Forms.TextBox();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.DataEscalaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.NovoButton = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.DescricaoTextBox = new System.Windows.Forms.TextBox();
            this.TipoSessaoComboBox = new System.Windows.Forms.ComboBox();
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PesquisaTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EscalasDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EscalasDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.AbrirEscalaButton);
            this.groupBox1.Controls.Add(this.FinalizadaCheckBox);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.ObservacaoTextBox);
            this.groupBox1.Controls.Add(this.IdTextBox);
            this.groupBox1.Controls.Add(this.DataEscalaDateTimePicker);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.NovoButton);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.DescricaoTextBox);
            this.groupBox1.Controls.Add(this.TipoSessaoComboBox);
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
            this.groupBox1.Size = new System.Drawing.Size(820, 269);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de Escalas";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(518, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 18);
            this.label8.TabIndex = 38;
            this.label8.Text = "Abrir Escala";
            // 
            // AbrirEscalaButton
            // 
            this.AbrirEscalaButton.AutoSize = true;
            this.AbrirEscalaButton.BackColor = System.Drawing.SystemColors.Info;
            this.AbrirEscalaButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AbrirEscalaButton.BackgroundImage")));
            this.AbrirEscalaButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AbrirEscalaButton.Enabled = false;
            this.AbrirEscalaButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.AbrirEscalaButton.FlatAppearance.BorderSize = 0;
            this.AbrirEscalaButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AbrirEscalaButton.Location = new System.Drawing.Point(519, 197);
            this.AbrirEscalaButton.Name = "AbrirEscalaButton";
            this.AbrirEscalaButton.Size = new System.Drawing.Size(54, 45);
            this.AbrirEscalaButton.TabIndex = 37;
            this.AbrirEscalaButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AbrirEscalaButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.AbrirEscalaButton.UseVisualStyleBackColor = false;
            this.AbrirEscalaButton.Click += new System.EventHandler(this.AbrirEscalaButton_Click);
            // 
            // FinalizadaCheckBox
            // 
            this.FinalizadaCheckBox.AutoSize = true;
            this.FinalizadaCheckBox.BackColor = System.Drawing.SystemColors.Info;
            this.FinalizadaCheckBox.Enabled = false;
            this.FinalizadaCheckBox.Location = new System.Drawing.Point(323, 52);
            this.FinalizadaCheckBox.Name = "FinalizadaCheckBox";
            this.FinalizadaCheckBox.Size = new System.Drawing.Size(86, 22);
            this.FinalizadaCheckBox.TabIndex = 36;
            this.FinalizadaCheckBox.Text = "Finalizada";
            this.FinalizadaCheckBox.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(323, 89);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 18);
            this.label11.TabIndex = 35;
            this.label11.Text = "Observação";
            // 
            // ObservacaoTextBox
            // 
            this.ObservacaoTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.ObservacaoTextBox.Enabled = false;
            this.ObservacaoTextBox.Location = new System.Drawing.Point(323, 110);
            this.ObservacaoTextBox.MaxLength = 200;
            this.ObservacaoTextBox.Multiline = true;
            this.ObservacaoTextBox.Name = "ObservacaoTextBox";
            this.ObservacaoTextBox.Size = new System.Drawing.Size(491, 72);
            this.ObservacaoTextBox.TabIndex = 6;
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(166, 13);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(100, 23);
            this.IdTextBox.TabIndex = 29;
            this.IdTextBox.Visible = false;
            // 
            // DataEscalaDateTimePicker
            // 
            this.DataEscalaDateTimePicker.Enabled = false;
            this.DataEscalaDateTimePicker.Location = new System.Drawing.Point(9, 52);
            this.DataEscalaDateTimePicker.Name = "DataEscalaDateTimePicker";
            this.DataEscalaDateTimePicker.Size = new System.Drawing.Size(308, 23);
            this.DataEscalaDateTimePicker.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(226, 245);
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
            this.NovoButton.Location = new System.Drawing.Point(219, 197);
            this.NovoButton.Name = "NovoButton";
            this.NovoButton.Size = new System.Drawing.Size(54, 45);
            this.NovoButton.TabIndex = 7;
            this.NovoButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NovoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.NovoButton.UseVisualStyleBackColor = false;
            this.NovoButton.Click += new System.EventHandler(this.NovoButton_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 89);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 18);
            this.label13.TabIndex = 21;
            this.label13.Text = "Descrição";
            // 
            // DescricaoTextBox
            // 
            this.DescricaoTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.DescricaoTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.DescricaoTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.DescricaoTextBox.Enabled = false;
            this.DescricaoTextBox.Location = new System.Drawing.Point(11, 110);
            this.DescricaoTextBox.MaxLength = 150;
            this.DescricaoTextBox.Name = "DescricaoTextBox";
            this.DescricaoTextBox.Size = new System.Drawing.Size(306, 23);
            this.DescricaoTextBox.TabIndex = 3;
            // 
            // TipoSessaoComboBox
            // 
            this.TipoSessaoComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TipoSessaoComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.TipoSessaoComboBox.BackColor = System.Drawing.SystemColors.Info;
            this.TipoSessaoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoSessaoComboBox.Enabled = false;
            this.TipoSessaoComboBox.FormattingEnabled = true;
            this.TipoSessaoComboBox.Items.AddRange(new object[] {
            "Anual",
            "Escala",
            "Extra",
            "Instrutiva"});
            this.TipoSessaoComboBox.Location = new System.Drawing.Point(11, 156);
            this.TipoSessaoComboBox.Name = "TipoSessaoComboBox";
            this.TipoSessaoComboBox.Size = new System.Drawing.Size(306, 26);
            this.TipoSessaoComboBox.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(463, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "Limpar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(403, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Excluir";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(344, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Editar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(285, 245);
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
            this.LimparButton.Location = new System.Drawing.Point(459, 197);
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
            this.ExcluirButton.BackColor = System.Drawing.SystemColors.Info;
            this.ExcluirButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExcluirButton.BackgroundImage")));
            this.ExcluirButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ExcluirButton.Enabled = false;
            this.ExcluirButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ExcluirButton.FlatAppearance.BorderSize = 0;
            this.ExcluirButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExcluirButton.Location = new System.Drawing.Point(399, 197);
            this.ExcluirButton.Name = "ExcluirButton";
            this.ExcluirButton.Size = new System.Drawing.Size(54, 45);
            this.ExcluirButton.TabIndex = 9;
            this.ExcluirButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ExcluirButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ExcluirButton.UseVisualStyleBackColor = false;
            this.ExcluirButton.Click += new System.EventHandler(this.ExcluirButton_Click);
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
            this.EditarButton.Location = new System.Drawing.Point(339, 197);
            this.EditarButton.Name = "EditarButton";
            this.EditarButton.Size = new System.Drawing.Size(54, 45);
            this.EditarButton.TabIndex = 8;
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
            this.SalvarButton.Location = new System.Drawing.Point(279, 197);
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
            this.label2.Location = new System.Drawing.Point(11, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tipo de Sessão";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data da Escala";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PesquisaTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.EscalasDataGridView);
            this.groupBox2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(12, 287);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(820, 406);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Histórico de Escalas";
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
            // EscalasDataGridView
            // 
            this.EscalasDataGridView.AllowUserToAddRows = false;
            this.EscalasDataGridView.AllowUserToDeleteRows = false;
            this.EscalasDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan;
            this.EscalasDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.EscalasDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EscalasDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.EscalasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EscalasDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.EscalasDataGridView.Location = new System.Drawing.Point(6, 78);
            this.EscalasDataGridView.MultiSelect = false;
            this.EscalasDataGridView.Name = "EscalasDataGridView";
            this.EscalasDataGridView.ReadOnly = true;
            this.EscalasDataGridView.RowHeadersVisible = false;
            this.EscalasDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EscalasDataGridView.RowTemplate.Height = 25;
            this.EscalasDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EscalasDataGridView.Size = new System.Drawing.Size(808, 320);
            this.EscalasDataGridView.TabIndex = 0;
            this.EscalasDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EscalasDataGridView_CellClick);
            this.EscalasDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EscalasDataGridView_CellDoubleClick);

            // 
            // EscalasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(839, 697);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EscalasForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Escalas de Venda";
            this.Load += new System.EventHandler(this.EscalasForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EscalasDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label label11;
        private TextBox ObservacaoTextBox;
        private TextBox IdTextBox;
        private DateTimePicker DataEscalaDateTimePicker;
        private Label label14;
        private Button NovoButton;
        private Label label13;
        private TextBox DescricaoTextBox;
        private ComboBox TipoSessaoComboBox;
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
        private CheckBox FinalizadaCheckBox;
        private GroupBox groupBox2;
        private TextBox PesquisaTextBox;
        private Label label3;
        private DataGridView EscalasDataGridView;
        private Label label8;
        private Button AbrirEscalaButton;
    }
}