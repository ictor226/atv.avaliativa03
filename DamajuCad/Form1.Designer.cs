namespace DamajuCad
{
    partial class Form1
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
            this.CadLanche = new System.Windows.Forms.Button();
            this.GerenciamentoLanche = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.GerenciamentoCliente = new System.Windows.Forms.Button();
            this.CadCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CadLanche
            // 
            this.CadLanche.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CadLanche.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.CadLanche.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CadLanche.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CadLanche.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CadLanche.Location = new System.Drawing.Point(259, 153);
            this.CadLanche.Name = "CadLanche";
            this.CadLanche.Size = new System.Drawing.Size(149, 62);
            this.CadLanche.TabIndex = 1;
            this.CadLanche.Text = "Cadastrar Lanche";
            this.CadLanche.UseVisualStyleBackColor = false;
            this.CadLanche.Click += new System.EventHandler(this.CadLanche_Click);
            // 
            // GerenciamentoLanche
            // 
            this.GerenciamentoLanche.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GerenciamentoLanche.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.GerenciamentoLanche.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GerenciamentoLanche.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GerenciamentoLanche.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GerenciamentoLanche.Location = new System.Drawing.Point(445, 153);
            this.GerenciamentoLanche.Name = "GerenciamentoLanche";
            this.GerenciamentoLanche.Size = new System.Drawing.Size(149, 62);
            this.GerenciamentoLanche.TabIndex = 3;
            this.GerenciamentoLanche.Text = "Gerenciamento Lanche";
            this.GerenciamentoLanche.UseVisualStyleBackColor = false;
            this.GerenciamentoLanche.Click += new System.EventHandler(this.GerenciamentoLanche_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Khaki;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(349, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Menu Damaju";
            // 
            // GerenciamentoCliente
            // 
            this.GerenciamentoCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GerenciamentoCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.GerenciamentoCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GerenciamentoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GerenciamentoCliente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GerenciamentoCliente.Location = new System.Drawing.Point(445, 221);
            this.GerenciamentoCliente.Name = "GerenciamentoCliente";
            this.GerenciamentoCliente.Size = new System.Drawing.Size(149, 62);
            this.GerenciamentoCliente.TabIndex = 5;
            this.GerenciamentoCliente.Text = "Gerenciamento Cliente";
            this.GerenciamentoCliente.UseVisualStyleBackColor = false;
            this.GerenciamentoCliente.Click += new System.EventHandler(this.GerenciamentoCliente_Click);
            // 
            // CadCliente
            // 
            this.CadCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CadCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.CadCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CadCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CadCliente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CadCliente.Location = new System.Drawing.Point(259, 221);
            this.CadCliente.Name = "CadCliente";
            this.CadCliente.Size = new System.Drawing.Size(149, 62);
            this.CadCliente.TabIndex = 2;
            this.CadCliente.Text = "Cadastrar Cliente";
            this.CadCliente.UseVisualStyleBackColor = false;
            this.CadCliente.Click += new System.EventHandler(this.CadCliente_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GerenciamentoCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GerenciamentoLanche);
            this.Controls.Add(this.CadCliente);
            this.Controls.Add(this.CadLanche);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acesso Sistema";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CadLanche;
        private System.Windows.Forms.Button GerenciamentoLanche;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GerenciamentoCliente;
        private System.Windows.Forms.Button CadCliente;
    }
}

