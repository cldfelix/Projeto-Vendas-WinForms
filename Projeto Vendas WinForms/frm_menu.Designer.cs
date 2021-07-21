
namespace Projeto_Vendas_WinForms
{
    partial class frm_menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_menu));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_cad_produto = new System.Windows.Forms.Button();
            this.btn_cad_categoria = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 426);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtosToolStripMenuItem,
            this.categoriasToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.produtosToolStripMenuItem.Text = "Produtos";
            this.produtosToolStripMenuItem.Click += new System.EventHandler(this.produtosToolStripMenuItem_Click);
            // 
            // categoriasToolStripMenuItem
            // 
            this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.categoriasToolStripMenuItem.Text = "Categorias";
            this.categoriasToolStripMenuItem.Click += new System.EventHandler(this.categoriasToolStripMenuItem_Click);
            // 
            // btn_cad_produto
            // 
            this.btn_cad_produto.BackColor = System.Drawing.Color.Transparent;
            this.btn_cad_produto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_cad_produto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cad_produto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cad_produto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_cad_produto.ForeColor = System.Drawing.Color.DimGray;
            this.btn_cad_produto.Image = global::Projeto_Vendas_WinForms.Properties.Resources.cad_produtos_40x40;
            this.btn_cad_produto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_cad_produto.Location = new System.Drawing.Point(12, 48);
            this.btn_cad_produto.Name = "btn_cad_produto";
            this.btn_cad_produto.Size = new System.Drawing.Size(140, 72);
            this.btn_cad_produto.TabIndex = 2;
            this.btn_cad_produto.Text = "Cadastrar Produtos";
            this.btn_cad_produto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_cad_produto.UseVisualStyleBackColor = false;
            this.btn_cad_produto.Click += new System.EventHandler(this.btn_cad_produto_Click);
            // 
            // btn_cad_categoria
            // 
            this.btn_cad_categoria.BackColor = System.Drawing.Color.Transparent;
            this.btn_cad_categoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_cad_categoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cad_categoria.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cad_categoria.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_cad_categoria.ForeColor = System.Drawing.Color.DimGray;
            this.btn_cad_categoria.Image = ((System.Drawing.Image)(resources.GetObject("btn_cad_categoria.Image")));
            this.btn_cad_categoria.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_cad_categoria.Location = new System.Drawing.Point(175, 48);
            this.btn_cad_categoria.Name = "btn_cad_categoria";
            this.btn_cad_categoria.Size = new System.Drawing.Size(140, 72);
            this.btn_cad_categoria.TabIndex = 3;
            this.btn_cad_categoria.Text = "Cadastrar Categorias";
            this.btn_cad_categoria.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_cad_categoria.UseVisualStyleBackColor = false;
            this.btn_cad_categoria.Click += new System.EventHandler(this.btn_cad_categoria_Click);
            // 
            // frm_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_cad_categoria);
            this.Controls.Add(this.btn_cad_produto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu principal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem;
        private System.Windows.Forms.Button btn_cad_produto;
        private System.Windows.Forms.Button btn_cad_categoria;
    }
}

