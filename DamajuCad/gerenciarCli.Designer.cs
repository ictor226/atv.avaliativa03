namespace DamajuCad
{
    partial class gerenciarCli
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
            this.buttonApagarProduto = new System.Windows.Forms.Button();
            this.buttonPesquisarCliente = new System.Windows.Forms.Button();
            this.dgvProduto = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonApagarProduto
            // 
            this.buttonApagarProduto.Location = new System.Drawing.Point(519, 136);
            this.buttonApagarProduto.Name = "buttonApagarProduto";
            this.buttonApagarProduto.Size = new System.Drawing.Size(133, 48);
            this.buttonApagarProduto.TabIndex = 5;
            this.buttonApagarProduto.Text = "Apagar Cliente";
            this.buttonApagarProduto.UseVisualStyleBackColor = true;
            this.buttonApagarProduto.Click += new System.EventHandler(this.buttonApagarProduto_Click);
            // 
            // buttonPesquisarCliente
            // 
            this.buttonPesquisarCliente.Location = new System.Drawing.Point(519, 65);
            this.buttonPesquisarCliente.Name = "buttonPesquisarCliente";
            this.buttonPesquisarCliente.Size = new System.Drawing.Size(133, 48);
            this.buttonPesquisarCliente.TabIndex = 4;
            this.buttonPesquisarCliente.Text = "Pesquisar Cliente";
            this.buttonPesquisarCliente.UseVisualStyleBackColor = true;
            this.buttonPesquisarCliente.Click += new System.EventHandler(this.buttonPesquisarCliente_Click);
            // 
            // dgvProduto
            // 
            this.dgvProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduto.Location = new System.Drawing.Point(12, 23);
            this.dgvProduto.Name = "dgvProduto";
            this.dgvProduto.Size = new System.Drawing.Size(436, 400);
            this.dgvProduto.TabIndex = 3;
            // 
            // gerenciarCli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonApagarProduto);
            this.Controls.Add(this.buttonPesquisarCliente);
            this.Controls.Add(this.dgvProduto);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "gerenciarCli";
            this.Text = "gerenciarCli";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonApagarProduto;
        private System.Windows.Forms.Button buttonPesquisarCliente;
        private System.Windows.Forms.DataGridView dgvProduto;
    }
}