﻿namespace LanchoneteUDV
{
    partial class FilaPedidosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilaPedidosForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.AgruparCheckBox = new System.Windows.Forms.CheckBox();
            this.SemRetirarCheckBox = new System.Windows.Forms.CheckBox();
            this.ChurrascoRadioButton = new System.Windows.Forms.RadioButton();
            this.ParceriasRadioButton = new System.Windows.Forms.RadioButton();
            this.SalgadosRadioButton = new System.Windows.Forms.RadioButton();
            this.TudoRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.AtualizaButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.DesmarcarRetiradaButton = new System.Windows.Forms.Button();
            this.RegistrarRetiradaButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.PedidosDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PedidosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.AgruparCheckBox);
            this.groupBox3.Controls.Add(this.SemRetirarCheckBox);
            this.groupBox3.Controls.Add(this.ChurrascoRadioButton);
            this.groupBox3.Controls.Add(this.ParceriasRadioButton);
            this.groupBox3.Controls.Add(this.SalgadosRadioButton);
            this.groupBox3.Controls.Add(this.TudoRadioButton);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.AtualizaButton);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.DesmarcarRetiradaButton);
            this.groupBox3.Controls.Add(this.RegistrarRetiradaButton);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.PedidosDataGridView);
            this.groupBox3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1063, 469);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Fila";
            // 
            // AgruparCheckBox
            // 
            this.AgruparCheckBox.AutoSize = true;
            this.AgruparCheckBox.Location = new System.Drawing.Point(931, 388);
            this.AgruparCheckBox.Name = "AgruparCheckBox";
            this.AgruparCheckBox.Size = new System.Drawing.Size(73, 22);
            this.AgruparCheckBox.TabIndex = 57;
            this.AgruparCheckBox.Text = "Agrupar";
            this.AgruparCheckBox.UseVisualStyleBackColor = true;
            this.AgruparCheckBox.CheckedChanged += new System.EventHandler(this.AgruparCheckBox_CheckedChanged);
            // 
            // SemRetirarCheckBox
            // 
            this.SemRetirarCheckBox.AutoSize = true;
            this.SemRetirarCheckBox.Location = new System.Drawing.Point(931, 347);
            this.SemRetirarCheckBox.Name = "SemRetirarCheckBox";
            this.SemRetirarCheckBox.Size = new System.Drawing.Size(111, 22);
            this.SemRetirarCheckBox.TabIndex = 56;
            this.SemRetirarCheckBox.Text = "Só sem retirar";
            this.SemRetirarCheckBox.UseVisualStyleBackColor = true;
            this.SemRetirarCheckBox.CheckedChanged += new System.EventHandler(this.SemRetirarCheckBox_CheckedChanged);
            // 
            // ChurrascoRadioButton
            // 
            this.ChurrascoRadioButton.AutoSize = true;
            this.ChurrascoRadioButton.Location = new System.Drawing.Point(931, 263);
            this.ChurrascoRadioButton.Name = "ChurrascoRadioButton";
            this.ChurrascoRadioButton.Size = new System.Drawing.Size(102, 22);
            this.ChurrascoRadioButton.TabIndex = 55;
            this.ChurrascoRadioButton.TabStop = true;
            this.ChurrascoRadioButton.Text = "Só Churrasco";
            this.ChurrascoRadioButton.UseVisualStyleBackColor = true;
            this.ChurrascoRadioButton.CheckedChanged += new System.EventHandler(this.ChurrascoRadioButton_CheckedChanged);
            this.ChurrascoRadioButton.Click += new System.EventHandler(this.ChurrascoRadioButton_Click);
            // 
            // ParceriasRadioButton
            // 
            this.ParceriasRadioButton.AutoSize = true;
            this.ParceriasRadioButton.Location = new System.Drawing.Point(931, 303);
            this.ParceriasRadioButton.Name = "ParceriasRadioButton";
            this.ParceriasRadioButton.Size = new System.Drawing.Size(97, 22);
            this.ParceriasRadioButton.TabIndex = 54;
            this.ParceriasRadioButton.TabStop = true;
            this.ParceriasRadioButton.Text = "Só Parcerias";
            this.ParceriasRadioButton.UseVisualStyleBackColor = true;
            this.ParceriasRadioButton.CheckedChanged += new System.EventHandler(this.ParceriasRadioButton_CheckedChanged);
            this.ParceriasRadioButton.Click += new System.EventHandler(this.ParceriasRadioButton_Click);
            // 
            // SalgadosRadioButton
            // 
            this.SalgadosRadioButton.AutoSize = true;
            this.SalgadosRadioButton.Location = new System.Drawing.Point(931, 220);
            this.SalgadosRadioButton.Name = "SalgadosRadioButton";
            this.SalgadosRadioButton.Size = new System.Drawing.Size(95, 22);
            this.SalgadosRadioButton.TabIndex = 53;
            this.SalgadosRadioButton.TabStop = true;
            this.SalgadosRadioButton.Text = "Só Salgados";
            this.SalgadosRadioButton.UseVisualStyleBackColor = true;
            this.SalgadosRadioButton.CheckedChanged += new System.EventHandler(this.SalgadosRadioButton_CheckedChanged);
            this.SalgadosRadioButton.Click += new System.EventHandler(this.SalgadosRadioButton_Click);
            // 
            // TudoRadioButton
            // 
            this.TudoRadioButton.AutoSize = true;
            this.TudoRadioButton.Checked = true;
            this.TudoRadioButton.Location = new System.Drawing.Point(931, 179);
            this.TudoRadioButton.Name = "TudoRadioButton";
            this.TudoRadioButton.Size = new System.Drawing.Size(89, 22);
            this.TudoRadioButton.TabIndex = 52;
            this.TudoRadioButton.TabStop = true;
            this.TudoRadioButton.Text = "Exibe Tudo";
            this.TudoRadioButton.UseVisualStyleBackColor = true;
            this.TudoRadioButton.CheckedChanged += new System.EventHandler(this.TudoRadioButton_CheckedChanged);
            this.TudoRadioButton.Click += new System.EventHandler(this.TudoRadioButton_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(983, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 45);
            this.label1.TabIndex = 51;
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
            this.AtualizaButton.Location = new System.Drawing.Point(931, 116);
            this.AtualizaButton.Name = "AtualizaButton";
            this.AtualizaButton.Size = new System.Drawing.Size(46, 41);
            this.AtualizaButton.TabIndex = 50;
            this.AtualizaButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AtualizaButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.AtualizaButton.UseVisualStyleBackColor = false;
            this.AtualizaButton.Click += new System.EventHandler(this.AtualizaButton_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(984, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 45);
            this.label6.TabIndex = 49;
            this.label6.Text = "Desmarcar Retirada";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DesmarcarRetiradaButton
            // 
            this.DesmarcarRetiradaButton.AutoSize = true;
            this.DesmarcarRetiradaButton.BackColor = System.Drawing.SystemColors.Window;
            this.DesmarcarRetiradaButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DesmarcarRetiradaButton.BackgroundImage")));
            this.DesmarcarRetiradaButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.DesmarcarRetiradaButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.DesmarcarRetiradaButton.FlatAppearance.BorderSize = 0;
            this.DesmarcarRetiradaButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DesmarcarRetiradaButton.Location = new System.Drawing.Point(931, 69);
            this.DesmarcarRetiradaButton.Name = "DesmarcarRetiradaButton";
            this.DesmarcarRetiradaButton.Size = new System.Drawing.Size(46, 41);
            this.DesmarcarRetiradaButton.TabIndex = 48;
            this.DesmarcarRetiradaButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.DesmarcarRetiradaButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.DesmarcarRetiradaButton.UseVisualStyleBackColor = false;
            this.DesmarcarRetiradaButton.Click += new System.EventHandler(this.DesmarcarRetiradaButton_Click);
            // 
            // RegistrarRetiradaButton
            // 
            this.RegistrarRetiradaButton.AutoSize = true;
            this.RegistrarRetiradaButton.BackColor = System.Drawing.SystemColors.Window;
            this.RegistrarRetiradaButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RegistrarRetiradaButton.BackgroundImage")));
            this.RegistrarRetiradaButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.RegistrarRetiradaButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.RegistrarRetiradaButton.FlatAppearance.BorderSize = 0;
            this.RegistrarRetiradaButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RegistrarRetiradaButton.Location = new System.Drawing.Point(931, 22);
            this.RegistrarRetiradaButton.Name = "RegistrarRetiradaButton";
            this.RegistrarRetiradaButton.Size = new System.Drawing.Size(46, 41);
            this.RegistrarRetiradaButton.TabIndex = 46;
            this.RegistrarRetiradaButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.RegistrarRetiradaButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.RegistrarRetiradaButton.UseVisualStyleBackColor = false;
            this.RegistrarRetiradaButton.Click += new System.EventHandler(this.RegistrarRetiradaButton_Click);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(983, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 45);
            this.label10.TabIndex = 45;
            this.label10.Text = "Registrar Retirada";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PedidosDataGridView
            // 
            this.PedidosDataGridView.AllowUserToAddRows = false;
            this.PedidosDataGridView.AllowUserToDeleteRows = false;
            this.PedidosDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan;
            this.PedidosDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.PedidosDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PedidosDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.PedidosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PedidosDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.PedidosDataGridView.Location = new System.Drawing.Point(6, 22);
            this.PedidosDataGridView.Name = "PedidosDataGridView";
            this.PedidosDataGridView.ReadOnly = true;
            this.PedidosDataGridView.RowHeadersVisible = false;
            this.PedidosDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PedidosDataGridView.RowTemplate.Height = 25;
            this.PedidosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PedidosDataGridView.Size = new System.Drawing.Size(919, 441);
            this.PedidosDataGridView.TabIndex = 0;
            this.PedidosDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PedidosDataGridView_CellDoubleClick);
            // 
            // FilaPedidosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1081, 493);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FilaPedidosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fila de Pedidos";
            this.Load += new System.EventHandler(this.FilaPedidosForm_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PedidosDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox3;
        private Label label6;
        private Button DesmarcarRetiradaButton;
        private Button RegistrarRetiradaButton;
        private Label label10;
        private DataGridView PedidosDataGridView;
        private Label label1;
        private Button AtualizaButton;
        private RadioButton ParceriasRadioButton;
        private RadioButton SalgadosRadioButton;
        private RadioButton TudoRadioButton;
        private RadioButton ChurrascoRadioButton;
        private CheckBox SemRetirarCheckBox;
        private CheckBox AgruparCheckBox;
    }
}