namespace ProjetoTelas
{
    partial class frmInicial
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSair = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDados = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPessoais = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOutrasInfos = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnArquivo,
            this.btnDados});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1037, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnArquivo
            // 
            this.btnArquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSair});
            this.btnArquivo.Name = "btnArquivo";
            this.btnArquivo.Size = new System.Drawing.Size(75, 24);
            this.btnArquivo.Text = "Arquivo";
            // 
            // btnSair
            // 
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(117, 26);
            this.btnSair.Text = "Sair";
            this.btnSair.Click += new System.EventHandler(this.SairClick);
            // 
            // btnDados
            // 
            this.btnDados.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPessoais,
            this.btnOutrasInfos});
            this.btnDados.Name = "btnDados";
            this.btnDados.Size = new System.Drawing.Size(66, 24);
            this.btnDados.Text = "Dados";
            // 
            // btnPessoais
            // 
            this.btnPessoais.Name = "btnPessoais";
            this.btnPessoais.Size = new System.Drawing.Size(224, 26);
            this.btnPessoais.Text = "Pessoais";
            this.btnPessoais.Click += new System.EventHandler(this.btnPessoais_Click);
            // 
            // btnOutrasInfos
            // 
            this.btnOutrasInfos.Name = "btnOutrasInfos";
            this.btnOutrasInfos.Size = new System.Drawing.Size(224, 26);
            this.btnOutrasInfos.Text = "Outras Informações";
            this.btnOutrasInfos.Click += new System.EventHandler(this.btnOutrasInfos_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.BackgroundImage = global::ProjetoTelas.Properties.Resources.advogado;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1037, 522);
            this.panel1.TabIndex = 2;
            // 
            // frmInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 550);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmInicial";
            this.Text = "Cadastro Clientes";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnArquivo;
        private System.Windows.Forms.ToolStripMenuItem btnSair;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem btnDados;
        private System.Windows.Forms.ToolStripMenuItem btnPessoais;
        private System.Windows.Forms.ToolStripMenuItem btnOutrasInfos;
    }
}
