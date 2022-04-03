namespace LanchoneteUDV
{
    partial class RepasseTesourariaForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RepasseTesourariaForm));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.PesquisaTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EscalasDataGridView = new System.Windows.Forms.DataGridView();
            this.AbrirEscalaButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FinalizadaCheckBox = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ObservacaoTextBox = new System.Windows.Forms.TextBox();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.DataEscalaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.DescricaoTextBox = new System.Windows.Forms.TextBox();
            this.TipoSessaoComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EscalasDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.PesquisaTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.EscalasDataGridView);
            this.groupBox2.Controls.Add(this.AbrirEscalaButton);
            this.groupBox2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(12, 202);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(900, 475);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Histórico de Escalas";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(313, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 18);
            this.label8.TabIndex = 38;
            this.label8.Text = "Abrir Escala";
            // 
            // PesquisaTextBox
            // 
            this.PesquisaTextBox.Location = new System.Drawing.Point(6, 70);
            this.PesquisaTextBox.MaxLength = 150;
            this.PesquisaTextBox.Name = "PesquisaTextBox";
            this.PesquisaTextBox.Size = new System.Drawing.Size(260, 23);
            this.PesquisaTextBox.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 49);
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
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.LightCyan;
            this.EscalasDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.EscalasDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EscalasDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.EscalasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EscalasDataGridView.DefaultCellStyle = dataGridViewCellStyle9;
            this.EscalasDataGridView.Location = new System.Drawing.Point(6, 101);
            this.EscalasDataGridView.MultiSelect = false;
            this.EscalasDataGridView.Name = "EscalasDataGridView";
            this.EscalasDataGridView.ReadOnly = true;
            this.EscalasDataGridView.RowHeadersVisible = false;
            this.EscalasDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EscalasDataGridView.RowTemplate.Height = 25;
            this.EscalasDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EscalasDataGridView.Size = new System.Drawing.Size(888, 368);
            this.EscalasDataGridView.TabIndex = 0;
            this.EscalasDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EscalasDataGridView_CellClick);
            this.EscalasDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EscalasDataGridView_CellDoubleClick);
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
            this.AbrirEscalaButton.Location = new System.Drawing.Point(324, 50);
            this.AbrirEscalaButton.Name = "AbrirEscalaButton";
            this.AbrirEscalaButton.Size = new System.Drawing.Size(54, 45);
            this.AbrirEscalaButton.TabIndex = 37;
            this.AbrirEscalaButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AbrirEscalaButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.AbrirEscalaButton.UseVisualStyleBackColor = false;
            this.AbrirEscalaButton.Click += new System.EventHandler(this.AbrirEscalaButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FinalizadaCheckBox);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.ObservacaoTextBox);
            this.groupBox1.Controls.Add(this.IdTextBox);
            this.groupBox1.Controls.Add(this.DataEscalaDateTimePicker);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.DescricaoTextBox);
            this.groupBox1.Controls.Add(this.TipoSessaoComboBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(900, 193);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de Escalas";
            // 
            // FinalizadaCheckBox
            // 
            this.FinalizadaCheckBox.AutoSize = true;
            this.FinalizadaCheckBox.BackColor = System.Drawing.SystemColors.Info;
            this.FinalizadaCheckBox.Enabled = false;
            this.FinalizadaCheckBox.Location = new System.Drawing.Point(403, 52);
            this.FinalizadaCheckBox.Name = "FinalizadaCheckBox";
            this.FinalizadaCheckBox.Size = new System.Drawing.Size(86, 22);
            this.FinalizadaCheckBox.TabIndex = 36;
            this.FinalizadaCheckBox.Text = "Finalizada";
            this.FinalizadaCheckBox.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(403, 89);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 18);
            this.label11.TabIndex = 35;
            this.label11.Text = "Observação";
            // 
            // ObservacaoTextBox
            // 
            this.ObservacaoTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.ObservacaoTextBox.Enabled = false;
            this.ObservacaoTextBox.Location = new System.Drawing.Point(403, 110);
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
            this.DataEscalaDateTimePicker.Size = new System.Drawing.Size(369, 23);
            this.DataEscalaDateTimePicker.TabIndex = 0;
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
            this.DescricaoTextBox.Size = new System.Drawing.Size(367, 23);
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
            "Extra"});
            this.TipoSessaoComboBox.Location = new System.Drawing.Point(11, 156);
            this.TipoSessaoComboBox.Name = "TipoSessaoComboBox";
            this.TipoSessaoComboBox.Size = new System.Drawing.Size(367, 26);
            this.TipoSessaoComboBox.TabIndex = 1;
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
            // RepasseTesourariaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(924, 689);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RepasseTesourariaForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Repasse Tesouraria Escalas";
            this.Load += new System.EventHandler(this.RepasseTesourariaForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EscalasDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox2;
        private TextBox PesquisaTextBox;
        private Label label3;
        private DataGridView EscalasDataGridView;
        private GroupBox groupBox1;
        private Label label8;
        private Button AbrirEscalaButton;
        private CheckBox FinalizadaCheckBox;
        private Label label11;
        private TextBox ObservacaoTextBox;
        private TextBox IdTextBox;
        private DateTimePicker DataEscalaDateTimePicker;
        private Label label13;
        private TextBox DescricaoTextBox;
        private ComboBox TipoSessaoComboBox;
        private Label label2;
        private Label label1;
    }
}