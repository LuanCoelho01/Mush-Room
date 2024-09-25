namespace Mush___Room.telaProducao
{
    partial class producao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(producao));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuProducao = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFornecedores = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCompras = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRelatorios = new System.Windows.Forms.ToolStripMenuItem();
            this.gridProducao = new System.Windows.Forms.DataGridView();
            this.btnExProd = new System.Windows.Forms.Button();
            this.btnAltProd = new System.Windows.Forms.Button();
            this.btnCadProd = new System.Windows.Forms.Button();
            this.nomeEmpresa = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.menuStrip1.Location = new System.Drawing.Point(589, 16);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(460, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuProducao
            // 
            this.menuProducao.Name = "menuProducao";
            this.menuProducao.Size = new System.Drawing.Size(86, 24);
            this.menuProducao.Text = "Produção";
            // 
            // menuFornecedores
            // 
            this.menuFornecedores.Name = "menuFornecedores";
            this.menuFornecedores.Size = new System.Drawing.Size(112, 24);
            this.menuFornecedores.Text = "Fornecedores";
            // 
            // menuCompras
            // 
            this.menuCompras.Name = "menuCompras";
            this.menuCompras.Size = new System.Drawing.Size(82, 24);
            this.menuCompras.Text = "Compras";
            // 
            // menuProdutos
            // 
            this.menuProdutos.Name = "menuProdutos";
            this.menuProdutos.Size = new System.Drawing.Size(82, 24);
            this.menuProdutos.Text = "Produtos";
            // 
            // menuRelatorios
            // 
            this.menuRelatorios.Name = "menuRelatorios";
            this.menuRelatorios.Size = new System.Drawing.Size(90, 24);
            this.menuRelatorios.Text = "Relatórios";
            // 
            // gridProducao
            // 
            this.gridProducao.AllowUserToAddRows = false;
            this.gridProducao.AllowUserToOrderColumns = true;
            this.gridProducao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridProducao.BackgroundColor = System.Drawing.Color.Snow;
            this.gridProducao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProducao.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.gridProducao.Location = new System.Drawing.Point(51, 94);
            this.gridProducao.Margin = new System.Windows.Forms.Padding(4);
            this.gridProducao.MultiSelect = false;
            this.gridProducao.Name = "gridProducao";
            this.gridProducao.ReadOnly = true;
            this.gridProducao.RowHeadersVisible = false;
            this.gridProducao.RowHeadersWidth = 51;
            this.gridProducao.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridProducao.Size = new System.Drawing.Size(964, 340);
            this.gridProducao.TabIndex = 4;
            this.gridProducao.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProducao_CellClick);
            this.gridProducao.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProducao_CellContentDoubleClick);
            // 
            // btnExProd
            // 
            this.btnExProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(185)))), ((int)(((byte)(137)))));
            this.btnExProd.Location = new System.Drawing.Point(51, 441);
            this.btnExProd.Margin = new System.Windows.Forms.Padding(4);
            this.btnExProd.Name = "btnExProd";
            this.btnExProd.Size = new System.Drawing.Size(100, 48);
            this.btnExProd.TabIndex = 5;
            this.btnExProd.Text = "Excluir\r\nprodução\r\n";
            this.btnExProd.UseVisualStyleBackColor = false;
            this.btnExProd.Click += new System.EventHandler(this.btnExProd_Click);
            // 
            // btnAltProd
            // 
            this.btnAltProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(185)))), ((int)(((byte)(137)))));
            this.btnAltProd.Location = new System.Drawing.Point(159, 441);
            this.btnAltProd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAltProd.Name = "btnAltProd";
            this.btnAltProd.Size = new System.Drawing.Size(100, 48);
            this.btnAltProd.TabIndex = 6;
            this.btnAltProd.Text = "Alterar\r\nprodução";
            this.btnAltProd.UseVisualStyleBackColor = false;
            this.btnAltProd.Click += new System.EventHandler(this.btnAltProd_Click);
            // 
            // btnCadProd
            // 
            this.btnCadProd.BackColor = System.Drawing.Color.Chocolate;
            this.btnCadProd.Location = new System.Drawing.Point(267, 441);
            this.btnCadProd.Margin = new System.Windows.Forms.Padding(4);
            this.btnCadProd.Name = "btnCadProd";
            this.btnCadProd.Size = new System.Drawing.Size(100, 48);
            this.btnCadProd.TabIndex = 7;
            this.btnCadProd.Text = "Cadastrar \r\nprodução";
            this.btnCadProd.UseVisualStyleBackColor = false;
            this.btnCadProd.Click += new System.EventHandler(this.btn_cadProd);
            // 
            // nomeEmpresa
            // 
            this.nomeEmpresa.AutoSize = true;
            this.nomeEmpresa.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeEmpresa.Location = new System.Drawing.Point(101, 16);
            this.nomeEmpresa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nomeEmpresa.Name = "nomeEmpresa";
            this.nomeEmpresa.Size = new System.Drawing.Size(112, 25);
            this.nomeEmpresa.TabIndex = 9;
            this.nomeEmpresa.Text = "Mush && Room";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Mush___Room.Properties.Resources.mushroom_icon_138360;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // producao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(213)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.nomeEmpresa);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCadProd);
            this.Controls.Add(this.btnAltProd);
            this.Controls.Add(this.btnExProd);
            this.Controls.Add(this.gridProducao);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "producao";
            this.Text = "Tela de produção";
            this.Load += new System.EventHandler(this.producao_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuProducao;
        private System.Windows.Forms.ToolStripMenuItem menuFornecedores;
        private System.Windows.Forms.ToolStripMenuItem menuCompras;
        private System.Windows.Forms.ToolStripMenuItem menuProdutos;
        private System.Windows.Forms.ToolStripMenuItem menuRelatorios;
        private System.Windows.Forms.Button btnExProd;
        private System.Windows.Forms.Button btnAltProd;
        private System.Windows.Forms.Button btnCadProd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label nomeEmpresa;
        private System.Windows.Forms.DataGridView gridProducao;
    }
}