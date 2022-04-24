namespace LanchoneteUDV
{
    partial class RepasseTesourariaVendaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RepasseTesourariaVendaForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ProgressLabel = new System.Windows.Forms.Label();
            this.EmailProgressBar = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.PesquisaTextBox = new System.Windows.Forms.TextBox();
            this.GerarRepasseButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.VendasDataGridView = new System.Windows.Forms.DataGridView();
            this.EmailSelecionadoButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DispararEmailsButton = new System.Windows.Forms.Button();
            this.FinalizarEscalaButton = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FinalizadaCheckBox = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ResumoVendasTextBox = new System.Windows.Forms.TextBox();
            this.DataEscalaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.DescricaoEscalaTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VendasDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ProgressLabel);
            this.groupBox2.Controls.Add(this.EmailProgressBar);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.PesquisaTextBox);
            this.groupBox2.Controls.Add(this.GerarRepasseButton);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.VendasDataGridView);
            this.groupBox2.Controls.Add(this.EmailSelecionadoButton);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.IdTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.DispararEmailsButton);
            this.groupBox2.Controls.Add(this.FinalizarEscalaButton);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(12, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(911, 536);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Histórico de Pedidos";
            // 
            // ProgressLabel
            // 
            this.ProgressLabel.AutoSize = true;
            this.ProgressLabel.Location = new System.Drawing.Point(342, 28);
            this.ProgressLabel.Name = "ProgressLabel";
            this.ProgressLabel.Size = new System.Drawing.Size(249, 18);
            this.ProgressLabel.TabIndex = 54;
            this.ProgressLabel.Text = "Disparando e-mails, por favor aguarde...";
            this.ProgressLabel.Visible = false;
            // 
            // EmailProgressBar
            // 
            this.EmailProgressBar.Location = new System.Drawing.Point(342, 49);
            this.EmailProgressBar.Name = "EmailProgressBar";
            this.EmailProgressBar.Size = new System.Drawing.Size(392, 23);
            this.EmailProgressBar.Step = 1;
            this.EmailProgressBar.TabIndex = 53;
            this.EmailProgressBar.Visible = false;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(792, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 39);
            this.label6.TabIndex = 52;
            this.label6.Text = "Gerar Repasse Tesouraria";
            // 
            // PesquisaTextBox
            // 
            this.PesquisaTextBox.Location = new System.Drawing.Point(6, 49);
            this.PesquisaTextBox.MaxLength = 150;
            this.PesquisaTextBox.Name = "PesquisaTextBox";
            this.PesquisaTextBox.Size = new System.Drawing.Size(260, 23);
            this.PesquisaTextBox.TabIndex = 15;
            // 
            // GerarRepasseButton
            // 
            this.GerarRepasseButton.AutoSize = true;
            this.GerarRepasseButton.BackColor = System.Drawing.SystemColors.Window;
            this.GerarRepasseButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GerarRepasseButton.BackgroundImage")));
            this.GerarRepasseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.GerarRepasseButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.GerarRepasseButton.FlatAppearance.BorderSize = 0;
            this.GerarRepasseButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GerarRepasseButton.Location = new System.Drawing.Point(740, 277);
            this.GerarRepasseButton.Name = "GerarRepasseButton";
            this.GerarRepasseButton.Size = new System.Drawing.Size(46, 41);
            this.GerarRepasseButton.TabIndex = 51;
            this.GerarRepasseButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.GerarRepasseButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.GerarRepasseButton.UseVisualStyleBackColor = false;
            this.GerarRepasseButton.Click += new System.EventHandler(this.GerarRepasseButton_Click);
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
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(792, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 40);
            this.label5.TabIndex = 50;
            this.label5.Text = "Disparar E-mail Socio Selecionado";
            // 
            // VendasDataGridView
            // 
            this.VendasDataGridView.AllowUserToAddRows = false;
            this.VendasDataGridView.AllowUserToDeleteRows = false;
            this.VendasDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan;
            this.VendasDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.VendasDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.VendasDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.VendasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.VendasDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.VendasDataGridView.Location = new System.Drawing.Point(6, 78);
            this.VendasDataGridView.MultiSelect = false;
            this.VendasDataGridView.Name = "VendasDataGridView";
            this.VendasDataGridView.ReadOnly = true;
            this.VendasDataGridView.RowHeadersVisible = false;
            this.VendasDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VendasDataGridView.RowTemplate.Height = 25;
            this.VendasDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.VendasDataGridView.Size = new System.Drawing.Size(728, 452);
            this.VendasDataGridView.TabIndex = 0;
            // 
            // EmailSelecionadoButton
            // 
            this.EmailSelecionadoButton.AutoSize = true;
            this.EmailSelecionadoButton.BackColor = System.Drawing.SystemColors.Info;
            this.EmailSelecionadoButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EmailSelecionadoButton.BackgroundImage")));
            this.EmailSelecionadoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.EmailSelecionadoButton.Enabled = false;
            this.EmailSelecionadoButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.EmailSelecionadoButton.FlatAppearance.BorderSize = 0;
            this.EmailSelecionadoButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EmailSelecionadoButton.Location = new System.Drawing.Point(740, 214);
            this.EmailSelecionadoButton.Name = "EmailSelecionadoButton";
            this.EmailSelecionadoButton.Size = new System.Drawing.Size(46, 41);
            this.EmailSelecionadoButton.TabIndex = 49;
            this.EmailSelecionadoButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EmailSelecionadoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.EmailSelecionadoButton.UseVisualStyleBackColor = false;
            this.EmailSelecionadoButton.Click += new System.EventHandler(this.EmailSelecionadoButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(283, 29);
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
            this.IdTextBox.Location = new System.Drawing.Point(283, 49);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(53, 23);
            this.IdTextBox.TabIndex = 0;
            this.IdTextBox.Text = "0";
            this.IdTextBox.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(384, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cardápio e Estoque";
            // 
            // DispararEmailsButton
            // 
            this.DispararEmailsButton.AutoSize = true;
            this.DispararEmailsButton.BackColor = System.Drawing.SystemColors.Info;
            this.DispararEmailsButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DispararEmailsButton.BackgroundImage")));
            this.DispararEmailsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.DispararEmailsButton.Enabled = false;
            this.DispararEmailsButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.DispararEmailsButton.FlatAppearance.BorderSize = 0;
            this.DispararEmailsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DispararEmailsButton.Location = new System.Drawing.Point(740, 147);
            this.DispararEmailsButton.Name = "DispararEmailsButton";
            this.DispararEmailsButton.Size = new System.Drawing.Size(46, 41);
            this.DispararEmailsButton.TabIndex = 48;
            this.DispararEmailsButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.DispararEmailsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.DispararEmailsButton.UseVisualStyleBackColor = false;
            this.DispararEmailsButton.Click += new System.EventHandler(this.DispararEmailsButton_Click);
            // 
            // FinalizarEscalaButton
            // 
            this.FinalizarEscalaButton.AutoSize = true;
            this.FinalizarEscalaButton.BackColor = System.Drawing.SystemColors.Window;
            this.FinalizarEscalaButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FinalizarEscalaButton.BackgroundImage")));
            this.FinalizarEscalaButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.FinalizarEscalaButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.FinalizarEscalaButton.FlatAppearance.BorderSize = 0;
            this.FinalizarEscalaButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FinalizarEscalaButton.Location = new System.Drawing.Point(740, 78);
            this.FinalizarEscalaButton.Name = "FinalizarEscalaButton";
            this.FinalizarEscalaButton.Size = new System.Drawing.Size(46, 41);
            this.FinalizarEscalaButton.TabIndex = 47;
            this.FinalizarEscalaButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.FinalizarEscalaButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.FinalizarEscalaButton.UseVisualStyleBackColor = false;
            this.FinalizarEscalaButton.Click += new System.EventHandler(this.FinalizarEscalaButton_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(792, 91);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 18);
            this.label14.TabIndex = 27;
            this.label14.Text = "Finalizar Escala";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(792, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 55);
            this.label8.TabIndex = 32;
            this.label8.Text = "Disparar E-mails todos Socios";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FinalizadaCheckBox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.ResumoVendasTextBox);
            this.groupBox1.Controls.Add(this.DataEscalaDateTimePicker);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.DescricaoEscalaTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(911, 74);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro de Pedidos";
            // 
            // FinalizadaCheckBox
            // 
            this.FinalizadaCheckBox.AutoSize = true;
            this.FinalizadaCheckBox.BackColor = System.Drawing.SystemColors.Info;
            this.FinalizadaCheckBox.Enabled = false;
            this.FinalizadaCheckBox.Location = new System.Drawing.Point(700, 43);
            this.FinalizadaCheckBox.Name = "FinalizadaCheckBox";
            this.FinalizadaCheckBox.Size = new System.Drawing.Size(86, 22);
            this.FinalizadaCheckBox.TabIndex = 37;
            this.FinalizadaCheckBox.Text = "Finalizada";
            this.FinalizadaCheckBox.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(559, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 18);
            this.label9.TabIndex = 34;
            this.label9.Text = "Resumo de Vendas";
            // 
            // ResumoVendasTextBox
            // 
            this.ResumoVendasTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ResumoVendasTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.ResumoVendasTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.ResumoVendasTextBox.Enabled = false;
            this.ResumoVendasTextBox.Location = new System.Drawing.Point(562, 43);
            this.ResumoVendasTextBox.MaxLength = 150;
            this.ResumoVendasTextBox.Name = "ResumoVendasTextBox";
            this.ResumoVendasTextBox.Size = new System.Drawing.Size(106, 23);
            this.ResumoVendasTextBox.TabIndex = 33;
            // 
            // DataEscalaDateTimePicker
            // 
            this.DataEscalaDateTimePicker.Enabled = false;
            this.DataEscalaDateTimePicker.Location = new System.Drawing.Point(7, 43);
            this.DataEscalaDateTimePicker.Name = "DataEscalaDateTimePicker";
            this.DataEscalaDateTimePicker.Size = new System.Drawing.Size(275, 23);
            this.DataEscalaDateTimePicker.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 18);
            this.label2.TabIndex = 31;
            this.label2.Text = "Data da Escala";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(285, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 18);
            this.label13.TabIndex = 29;
            this.label13.Text = "Escala";
            // 
            // DescricaoEscalaTextBox
            // 
            this.DescricaoEscalaTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.DescricaoEscalaTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.DescricaoEscalaTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.DescricaoEscalaTextBox.Enabled = false;
            this.DescricaoEscalaTextBox.Location = new System.Drawing.Point(285, 43);
            this.DescricaoEscalaTextBox.MaxLength = 150;
            this.DescricaoEscalaTextBox.Name = "DescricaoEscalaTextBox";
            this.DescricaoEscalaTextBox.Size = new System.Drawing.Size(268, 23);
            this.DescricaoEscalaTextBox.TabIndex = 28;
            // 
            // RepasseTesourariaVendaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(935, 637);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RepasseTesourariaVendaForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Repasse Tesouraria Venda";
            this.Load += new System.EventHandler(this.RepasseTesourariaVendaForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VendasDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox2;
        private TextBox PesquisaTextBox;
        private Label label3;
        private DataGridView VendasDataGridView;
        private Label label1;
        private TextBox IdTextBox;
        private Label label4;
        private GroupBox groupBox1;
        private Label label6;
        private Button GerarRepasseButton;
        private Label label5;
        private Button EmailSelecionadoButton;
        private Label label9;
        private TextBox ResumoVendasTextBox;
        private Button DispararEmailsButton;
        private DateTimePicker DataEscalaDateTimePicker;
        private Label label2;
        private Button FinalizarEscalaButton;
        private Label label13;
        private Label label8;
        private TextBox DescricaoEscalaTextBox;
        private Label label14;
        private CheckBox FinalizadaCheckBox;
        private ProgressBar EmailProgressBar;
        private Label ProgressLabel;
    }
}