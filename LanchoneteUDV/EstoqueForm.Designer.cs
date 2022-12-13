namespace LanchoneteUDV
{
    partial class EstoqueForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EstoqueForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BebidasRadioButton = new System.Windows.Forms.RadioButton();
            this.ChurrascoRadioButton = new System.Windows.Forms.RadioButton();
            this.ParceriasRadioButton = new System.Windows.Forms.RadioButton();
            this.SalgadosRadioButton = new System.Windows.Forms.RadioButton();
            this.TudoRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.AtualizaButton = new System.Windows.Forms.Button();
            this.EstoqueDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EstoqueDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BebidasRadioButton);
            this.groupBox2.Controls.Add(this.ChurrascoRadioButton);
            this.groupBox2.Controls.Add(this.ParceriasRadioButton);
            this.groupBox2.Controls.Add(this.SalgadosRadioButton);
            this.groupBox2.Controls.Add(this.TudoRadioButton);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.AtualizaButton);
            this.groupBox2.Controls.Add(this.EstoqueDataGridView);
            this.groupBox2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(589, 668);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Produtos em estoque";
            // 
            // BebidasRadioButton
            // 
            this.BebidasRadioButton.AutoSize = true;
            this.BebidasRadioButton.Location = new System.Drawing.Point(470, 124);
            this.BebidasRadioButton.Name = "BebidasRadioButton";
            this.BebidasRadioButton.Size = new System.Drawing.Size(89, 22);
            this.BebidasRadioButton.TabIndex = 60;
            this.BebidasRadioButton.TabStop = true;
            this.BebidasRadioButton.Text = "Só Bebidas";
            this.BebidasRadioButton.UseVisualStyleBackColor = true;
            this.BebidasRadioButton.Click += new System.EventHandler(this.BebidasRadioButton_Click);
            // 
            // ChurrascoRadioButton
            // 
            this.ChurrascoRadioButton.AutoSize = true;
            this.ChurrascoRadioButton.Location = new System.Drawing.Point(470, 180);
            this.ChurrascoRadioButton.Name = "ChurrascoRadioButton";
            this.ChurrascoRadioButton.Size = new System.Drawing.Size(102, 22);
            this.ChurrascoRadioButton.TabIndex = 59;
            this.ChurrascoRadioButton.TabStop = true;
            this.ChurrascoRadioButton.Text = "Só Churrasco";
            this.ChurrascoRadioButton.UseVisualStyleBackColor = true;
            this.ChurrascoRadioButton.Click += new System.EventHandler(this.ChurrascoRadioButton_Click);
            // 
            // ParceriasRadioButton
            // 
            this.ParceriasRadioButton.AutoSize = true;
            this.ParceriasRadioButton.Location = new System.Drawing.Point(470, 152);
            this.ParceriasRadioButton.Name = "ParceriasRadioButton";
            this.ParceriasRadioButton.Size = new System.Drawing.Size(97, 22);
            this.ParceriasRadioButton.TabIndex = 58;
            this.ParceriasRadioButton.TabStop = true;
            this.ParceriasRadioButton.Text = "Só Parcerias";
            this.ParceriasRadioButton.UseVisualStyleBackColor = true;
            this.ParceriasRadioButton.Click += new System.EventHandler(this.ParceriasRadioButton_Click);
            // 
            // SalgadosRadioButton
            // 
            this.SalgadosRadioButton.AutoSize = true;
            this.SalgadosRadioButton.Location = new System.Drawing.Point(470, 98);
            this.SalgadosRadioButton.Name = "SalgadosRadioButton";
            this.SalgadosRadioButton.Size = new System.Drawing.Size(95, 22);
            this.SalgadosRadioButton.TabIndex = 57;
            this.SalgadosRadioButton.TabStop = true;
            this.SalgadosRadioButton.Text = "Só Salgados";
            this.SalgadosRadioButton.UseVisualStyleBackColor = true;
            this.SalgadosRadioButton.Click += new System.EventHandler(this.SalgadosRadioButton_Click);
            // 
            // TudoRadioButton
            // 
            this.TudoRadioButton.AutoSize = true;
            this.TudoRadioButton.Checked = true;
            this.TudoRadioButton.Location = new System.Drawing.Point(470, 70);
            this.TudoRadioButton.Name = "TudoRadioButton";
            this.TudoRadioButton.Size = new System.Drawing.Size(89, 22);
            this.TudoRadioButton.TabIndex = 56;
            this.TudoRadioButton.TabStop = true;
            this.TudoRadioButton.Text = "Exibe Tudo";
            this.TudoRadioButton.UseVisualStyleBackColor = true;
            this.TudoRadioButton.Click += new System.EventHandler(this.TudoRadioButton_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(522, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 45);
            this.label1.TabIndex = 53;
            this.label1.Text = "Atualizar";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AtualizaButton
            // 
            this.AtualizaButton.AutoSize = true;
            this.AtualizaButton.BackColor = System.Drawing.SystemColors.Window;
            this.AtualizaButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AtualizaButton.BackgroundImage")));
            this.AtualizaButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AtualizaButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.AtualizaButton.FlatAppearance.BorderSize = 0;
            this.AtualizaButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AtualizaButton.Location = new System.Drawing.Point(470, 22);
            this.AtualizaButton.Name = "AtualizaButton";
            this.AtualizaButton.Size = new System.Drawing.Size(46, 41);
            this.AtualizaButton.TabIndex = 52;
            this.AtualizaButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AtualizaButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.AtualizaButton.UseVisualStyleBackColor = false;
            this.AtualizaButton.Click += new System.EventHandler(this.AtualizaButton_Click);
            // 
            // EstoqueDataGridView
            // 
            this.EstoqueDataGridView.AllowUserToAddRows = false;
            this.EstoqueDataGridView.AllowUserToDeleteRows = false;
            this.EstoqueDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan;
            this.EstoqueDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.EstoqueDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EstoqueDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.EstoqueDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EstoqueDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.EstoqueDataGridView.Location = new System.Drawing.Point(6, 22);
            this.EstoqueDataGridView.MultiSelect = false;
            this.EstoqueDataGridView.Name = "EstoqueDataGridView";
            this.EstoqueDataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EstoqueDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.EstoqueDataGridView.RowHeadersVisible = false;
            this.EstoqueDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EstoqueDataGridView.RowTemplate.Height = 25;
            this.EstoqueDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EstoqueDataGridView.Size = new System.Drawing.Size(458, 639);
            this.EstoqueDataGridView.TabIndex = 0;
            this.EstoqueDataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.EstoqueDataGridView_CellMouseDoubleClick);
            // 
            // EstoqueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(596, 676);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EstoqueForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estoque";
            this.Load += new System.EventHandler(this.EstoqueForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EstoqueDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox2;
        private DataGridView EstoqueDataGridView;
        private Label label1;
        private Button AtualizaButton;
        private RadioButton BebidasRadioButton;
        private RadioButton ChurrascoRadioButton;
        private RadioButton ParceriasRadioButton;
        private RadioButton SalgadosRadioButton;
        private RadioButton TudoRadioButton;
    }
}