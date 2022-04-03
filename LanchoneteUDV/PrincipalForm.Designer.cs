namespace LanchoneteUDV
{
    partial class PrincipalForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.escalasDeVendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sociosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroSociosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fluxoDeCaixaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fluxoDeCaixaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gerarRepasseTesourariaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerarRecibosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendasToolStripMenuItem,
            this.produtosToolStripMenuItem,
            this.sociosToolStripMenuItem,
            this.fluxoDeCaixaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(457, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.escalasDeVendaToolStripMenuItem});
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(70, 26);
            this.vendasToolStripMenuItem.Text = "Vendas";
            // 
            // escalasDeVendaToolStripMenuItem
            // 
            this.escalasDeVendaToolStripMenuItem.Name = "escalasDeVendaToolStripMenuItem";
            this.escalasDeVendaToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.escalasDeVendaToolStripMenuItem.Text = "Escalas de Venda";
            this.escalasDeVendaToolStripMenuItem.Click += new System.EventHandler(this.escalasDeVendaToolStripMenuItem_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroProdutosToolStripMenuItem,
            this.categoriasProdutosToolStripMenuItem,
            this.comprasProdutosToolStripMenuItem,
            this.estoqueToolStripMenuItem});
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(83, 26);
            this.produtosToolStripMenuItem.Text = "Produtos";
            // 
            // cadastroProdutosToolStripMenuItem
            // 
            this.cadastroProdutosToolStripMenuItem.Name = "cadastroProdutosToolStripMenuItem";
            this.cadastroProdutosToolStripMenuItem.Size = new System.Drawing.Size(294, 26);
            this.cadastroProdutosToolStripMenuItem.Text = "Cadastro Produtos";
            this.cadastroProdutosToolStripMenuItem.Click += new System.EventHandler(this.cadastroProdutosToolStripMenuItem_Click);
            // 
            // categoriasProdutosToolStripMenuItem
            // 
            this.categoriasProdutosToolStripMenuItem.Name = "categoriasProdutosToolStripMenuItem";
            this.categoriasProdutosToolStripMenuItem.Size = new System.Drawing.Size(294, 26);
            this.categoriasProdutosToolStripMenuItem.Text = "Categorias Produtos";
            this.categoriasProdutosToolStripMenuItem.Click += new System.EventHandler(this.categoriasProdutosToolStripMenuItem_Click);
            // 
            // comprasProdutosToolStripMenuItem
            // 
            this.comprasProdutosToolStripMenuItem.Name = "comprasProdutosToolStripMenuItem";
            this.comprasProdutosToolStripMenuItem.Size = new System.Drawing.Size(294, 26);
            this.comprasProdutosToolStripMenuItem.Text = "Registro de Compras/Entradas";
            this.comprasProdutosToolStripMenuItem.Click += new System.EventHandler(this.comprasProdutosToolStripMenuItem_Click);
            // 
            // estoqueToolStripMenuItem
            // 
            this.estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            this.estoqueToolStripMenuItem.Size = new System.Drawing.Size(294, 26);
            this.estoqueToolStripMenuItem.Text = "Estoque";
            this.estoqueToolStripMenuItem.Click += new System.EventHandler(this.estoqueToolStripMenuItem_Click);
            // 
            // sociosToolStripMenuItem
            // 
            this.sociosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroSociosToolStripMenuItem});
            this.sociosToolStripMenuItem.Name = "sociosToolStripMenuItem";
            this.sociosToolStripMenuItem.Size = new System.Drawing.Size(67, 26);
            this.sociosToolStripMenuItem.Text = "Socios";
            // 
            // cadastroSociosToolStripMenuItem
            // 
            this.cadastroSociosToolStripMenuItem.Name = "cadastroSociosToolStripMenuItem";
            this.cadastroSociosToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.cadastroSociosToolStripMenuItem.Text = "Cadastro Socios";
            this.cadastroSociosToolStripMenuItem.Click += new System.EventHandler(this.cadastroSociosToolStripMenuItem_Click);
            // 
            // fluxoDeCaixaToolStripMenuItem
            // 
            this.fluxoDeCaixaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fluxoDeCaixaToolStripMenuItem1,
            this.gerarRepasseTesourariaToolStripMenuItem,
            this.gerarRecibosToolStripMenuItem});
            this.fluxoDeCaixaToolStripMenuItem.Name = "fluxoDeCaixaToolStripMenuItem";
            this.fluxoDeCaixaToolStripMenuItem.Size = new System.Drawing.Size(96, 26);
            this.fluxoDeCaixaToolStripMenuItem.Text = "Financeiro";
            // 
            // fluxoDeCaixaToolStripMenuItem1
            // 
            this.fluxoDeCaixaToolStripMenuItem1.Name = "fluxoDeCaixaToolStripMenuItem1";
            this.fluxoDeCaixaToolStripMenuItem1.Size = new System.Drawing.Size(212, 26);
            this.fluxoDeCaixaToolStripMenuItem1.Text = "Fluxo de Caixa";
            this.fluxoDeCaixaToolStripMenuItem1.Click += new System.EventHandler(this.fluxoDeCaixaToolStripMenuItem1_Click);
            // 
            // gerarRepasseTesourariaToolStripMenuItem
            // 
            this.gerarRepasseTesourariaToolStripMenuItem.Name = "gerarRepasseTesourariaToolStripMenuItem";
            this.gerarRepasseTesourariaToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.gerarRepasseTesourariaToolStripMenuItem.Text = "Repasse Tesouraria";
            this.gerarRepasseTesourariaToolStripMenuItem.Click += new System.EventHandler(this.gerarRepasseTesourariaToolStripMenuItem_Click);
            // 
            // gerarRecibosToolStripMenuItem
            // 
            this.gerarRecibosToolStripMenuItem.Name = "gerarRecibosToolStripMenuItem";
            this.gerarRecibosToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.gerarRecibosToolStripMenuItem.Text = "Recibos";
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::LanchoneteUDV.Properties.Resources.udv;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(457, 264);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PrincipalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lanchonete";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem vendasToolStripMenuItem;
        private ToolStripMenuItem produtosToolStripMenuItem;
        private ToolStripMenuItem cadastroProdutosToolStripMenuItem;
        private ToolStripMenuItem comprasProdutosToolStripMenuItem;
        private ToolStripMenuItem sociosToolStripMenuItem;
        private ToolStripMenuItem cadastroSociosToolStripMenuItem;
        private ToolStripMenuItem fluxoDeCaixaToolStripMenuItem;
        private ToolStripMenuItem categoriasProdutosToolStripMenuItem;
        private ToolStripMenuItem escalasDeVendaToolStripMenuItem;
        private ToolStripMenuItem estoqueToolStripMenuItem;
        private ToolStripMenuItem fluxoDeCaixaToolStripMenuItem1;
        private ToolStripMenuItem gerarRepasseTesourariaToolStripMenuItem;
        private ToolStripMenuItem gerarRecibosToolStripMenuItem;
    }
}