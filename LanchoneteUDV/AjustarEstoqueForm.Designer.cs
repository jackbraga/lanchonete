namespace LanchoneteUDV
{
    partial class AjustarEstoqueForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjustarEstoqueForm));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RemoverButton = new System.Windows.Forms.Button();
            this.AdicionarButton = new System.Windows.Forms.Button();
            this.IdProdutoTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.QuantidadeTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.EstoqueAtualTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.DescricaoTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RemoverButton);
            this.groupBox2.Controls.Add(this.AdicionarButton);
            this.groupBox2.Controls.Add(this.IdProdutoTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.QuantidadeTextBox);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.EstoqueAtualTextBox);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.DescricaoTextBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(4, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(426, 127);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Produto";
            // 
            // RemoverButton
            // 
            this.RemoverButton.AutoSize = true;
            this.RemoverButton.BackColor = System.Drawing.SystemColors.Window;
            this.RemoverButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RemoverButton.BackgroundImage")));
            this.RemoverButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.RemoverButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.RemoverButton.FlatAppearance.BorderSize = 0;
            this.RemoverButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RemoverButton.Location = new System.Drawing.Point(298, 72);
            this.RemoverButton.Name = "RemoverButton";
            this.RemoverButton.Size = new System.Drawing.Size(46, 41);
            this.RemoverButton.TabIndex = 62;
            this.RemoverButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.RemoverButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.RemoverButton.UseVisualStyleBackColor = false;
            this.RemoverButton.Click += new System.EventHandler(this.RemoverButton_Click);
            // 
            // AdicionarButton
            // 
            this.AdicionarButton.AutoSize = true;
            this.AdicionarButton.BackColor = System.Drawing.SystemColors.Window;
            this.AdicionarButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AdicionarButton.BackgroundImage")));
            this.AdicionarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AdicionarButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.AdicionarButton.FlatAppearance.BorderSize = 0;
            this.AdicionarButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AdicionarButton.Location = new System.Drawing.Point(298, 28);
            this.AdicionarButton.Name = "AdicionarButton";
            this.AdicionarButton.Size = new System.Drawing.Size(46, 41);
            this.AdicionarButton.TabIndex = 61;
            this.AdicionarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AdicionarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.AdicionarButton.UseVisualStyleBackColor = false;
            this.AdicionarButton.Click += new System.EventHandler(this.AdicionarButton_Click);
            // 
            // IdProdutoTextBox
            // 
            this.IdProdutoTextBox.Location = new System.Drawing.Point(149, 10);
            this.IdProdutoTextBox.Name = "IdProdutoTextBox";
            this.IdProdutoTextBox.Size = new System.Drawing.Size(100, 23);
            this.IdProdutoTextBox.TabIndex = 60;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(350, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 45);
            this.label3.TabIndex = 59;
            this.label3.Text = "Remover";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 57;
            this.label2.Text = "Quantidade";
            // 
            // QuantidadeTextBox
            // 
            this.QuantidadeTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.QuantidadeTextBox.Location = new System.Drawing.Point(107, 90);
            this.QuantidadeTextBox.MaxLength = 150;
            this.QuantidadeTextBox.Name = "QuantidadeTextBox";
            this.QuantidadeTextBox.Size = new System.Drawing.Size(94, 23);
            this.QuantidadeTextBox.TabIndex = 56;
            this.QuantidadeTextBox.Text = "0";
            this.QuantidadeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.QuantidadeTextBox_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 69);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 18);
            this.label12.TabIndex = 25;
            this.label12.Text = "Estoque Atual";
            // 
            // EstoqueAtualTextBox
            // 
            this.EstoqueAtualTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.EstoqueAtualTextBox.Enabled = false;
            this.EstoqueAtualTextBox.Location = new System.Drawing.Point(6, 90);
            this.EstoqueAtualTextBox.MaxLength = 150;
            this.EstoqueAtualTextBox.Name = "EstoqueAtualTextBox";
            this.EstoqueAtualTextBox.Size = new System.Drawing.Size(94, 23);
            this.EstoqueAtualTextBox.TabIndex = 24;
            this.EstoqueAtualTextBox.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 18);
            this.label13.TabIndex = 55;
            this.label13.Text = "Descrição";
            // 
            // DescricaoTextBox
            // 
            this.DescricaoTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.DescricaoTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.DescricaoTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.DescricaoTextBox.Enabled = false;
            this.DescricaoTextBox.Location = new System.Drawing.Point(6, 40);
            this.DescricaoTextBox.MaxLength = 150;
            this.DescricaoTextBox.Name = "DescricaoTextBox";
            this.DescricaoTextBox.Size = new System.Drawing.Size(286, 23);
            this.DescricaoTextBox.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(350, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 45);
            this.label1.TabIndex = 53;
            this.label1.Text = "Adicionar";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            
            // 
            // AjustarEstoqueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(437, 130);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AjustarEstoqueForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajuste de Estoque";
            this.Load += new System.EventHandler(this.AjustarEstoqueForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox2;
        private Label label1;
        private Label label13;
        private TextBox DescricaoTextBox;
        private Label label12;
        private TextBox EstoqueAtualTextBox;
        private Label label2;
        private TextBox QuantidadeTextBox;
        private Label label3;
        private TextBox IdProdutoTextBox;
        private Button AdicionarButton;
        private Button RemoverButton;
    }
}