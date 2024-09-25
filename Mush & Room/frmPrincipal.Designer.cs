namespace Mush___Room
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.nomeEmpresa = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuProducao = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFornecedores = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCompras = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRelatorios = new System.Windows.Forms.ToolStripMenuItem();
            this.gridFornecedores = new System.Windows.Forms.DataGridView();
            this.gridProducao = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFornecedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeEmpresa
            // 
            this.nomeEmpresa.AutoSize = true;
            this.nomeEmpresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(213)))), ((int)(((byte)(187)))));
            this.nomeEmpresa.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 10.2F);
            this.nomeEmpresa.Location = new System.Drawing.Point(76, 37);
            this.nomeEmpresa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nomeEmpresa.Name = "nomeEmpresa";
            this.nomeEmpresa.Size = new System.Drawing.Size(112, 25);
            this.nomeEmpresa.TabIndex = 1;
            this.nomeEmpresa.Text = "Mush && Room";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(213)))), ((int)(((byte)(187)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuProducao,
            this.menuFornecedores,
            this.menuCompras,
            this.menuProdutos,
            this.menuRelatorios});
            this.menuStrip1.Location = new System.Drawing.Point(594, 16);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(455, 25);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuProducao
            // 
            this.menuProducao.Font = new System.Drawing.Font("Gentium Basic", 9F, System.Drawing.FontStyle.Bold);
            this.menuProducao.Name = "menuProducao";
            this.menuProducao.Size = new System.Drawing.Size(85, 21);
            this.menuProducao.Text = "Produção";
            this.menuProducao.Click += new System.EventHandler(this.menuProducao_Click);
            // 
            // menuFornecedores
            // 
            this.menuFornecedores.Font = new System.Drawing.Font("Gentium Basic", 9F, System.Drawing.FontStyle.Bold);
            this.menuFornecedores.Name = "menuFornecedores";
            this.menuFornecedores.Size = new System.Drawing.Size(110, 21);
            this.menuFornecedores.Text = "Fornecedores";
            this.menuFornecedores.Click += new System.EventHandler(this.menuFornecedores_Click);
            // 
            // menuCompras
            // 
            this.menuCompras.Font = new System.Drawing.Font("Gentium Basic", 9F, System.Drawing.FontStyle.Bold);
            this.menuCompras.Name = "menuCompras";
            this.menuCompras.Size = new System.Drawing.Size(80, 21);
            this.menuCompras.Text = "Compras";
            // 
            // menuProdutos
            // 
            this.menuProdutos.Font = new System.Drawing.Font("Gentium Basic", 9F, System.Drawing.FontStyle.Bold);
            this.menuProdutos.Name = "menuProdutos";
            this.menuProdutos.Size = new System.Drawing.Size(82, 21);
            this.menuProdutos.Text = "Produtos";
            // 
            // menuRelatorios
            // 
            this.menuRelatorios.Font = new System.Drawing.Font("Gentium Basic", 9F, System.Drawing.FontStyle.Bold);
            this.menuRelatorios.Name = "menuRelatorios";
            this.menuRelatorios.Size = new System.Drawing.Size(90, 21);
            this.menuRelatorios.Text = "Relatórios";
            // 
            // gridFornecedores
            // 
            this.gridFornecedores.AllowUserToAddRows = false;
            this.gridFornecedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridFornecedores.BackgroundColor = System.Drawing.Color.Snow;
            this.gridFornecedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFornecedores.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.gridFornecedores.Location = new System.Drawing.Point(40, 91);
            this.gridFornecedores.Margin = new System.Windows.Forms.Padding(4);
            this.gridFornecedores.MultiSelect = false;
            this.gridFornecedores.Name = "gridFornecedores";
            this.gridFornecedores.ReadOnly = true;
            this.gridFornecedores.RowHeadersVisible = false;
            this.gridFornecedores.RowHeadersWidth = 51;
            this.gridFornecedores.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridFornecedores.Size = new System.Drawing.Size(481, 185);
            this.gridFornecedores.TabIndex = 4;
            // 
            // gridProducao
            // 
            this.gridProducao.AllowUserToAddRows = false;
            this.gridProducao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridProducao.BackgroundColor = System.Drawing.Color.Snow;
            this.gridProducao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProducao.Location = new System.Drawing.Point(40, 321);
            this.gridProducao.Margin = new System.Windows.Forms.Padding(4);
            this.gridProducao.MultiSelect = false;
            this.gridProducao.Name = "gridProducao";
            this.gridProducao.ReadOnly = true;
            this.gridProducao.RowHeadersVisible = false;
            this.gridProducao.RowHeadersWidth = 51;
            this.gridProducao.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridProducao.Size = new System.Drawing.Size(481, 185);
            this.gridProducao.TabIndex = 4;
            // 
            // dataGridView3
            // 
            this.dataGridView3.BackgroundColor = System.Drawing.Color.Snow;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(612, 91);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.Size = new System.Drawing.Size(363, 415);
            this.dataGridView3.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Mush___Room.Properties.Resources.mushroom_icon_138360;
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(213)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.gridProducao);
            this.Controls.Add(this.gridFornecedores);
            this.Controls.Add(this.nomeEmpresa);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Inicial";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFornecedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label nomeEmpresa;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuProducao;
        private System.Windows.Forms.ToolStripMenuItem menuFornecedores;
        private System.Windows.Forms.ToolStripMenuItem menuCompras;
        private System.Windows.Forms.ToolStripMenuItem menuProdutos;
        private System.Windows.Forms.ToolStripMenuItem menuRelatorios;
        private System.Windows.Forms.DataGridView gridFornecedores;
        private System.Windows.Forms.DataGridView gridProducao;
        private System.Windows.Forms.DataGridView dataGridView3;
    }
}

