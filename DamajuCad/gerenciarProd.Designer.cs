namespace DamajuCad
{
    partial class gerenciarProd
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
            this.dgvProduto = new System.Windows.Forms.DataGridView();
            this.buttonPesquisarProduto = new System.Windows.Forms.Button();
            this.buttonApagarProduto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProduto
            // 
            this.dgvProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduto.Location = new System.Drawing.Point(12, 21);
            this.dgvProduto.Name = "dgvProduto";
            this.dgvProduto.Size = new System.Drawing.Size(436, 400);
            this.dgvProduto.TabIndex = 0;
            // 
            // buttonPesquisarProduto
            // 
            this.buttonPesquisarProduto.Location = new System.Drawing.Point(519, 63);
            this.buttonPesquisarProduto.Name = "buttonPesquisarProduto";
            this.buttonPesquisarProduto.Size = new System.Drawing.Size(133, 48);
            this.buttonPesquisarProduto.TabIndex = 1;
            this.buttonPesquisarProduto.Text = "pesquisar produto";
            this.buttonPesquisarProduto.UseVisualStyleBackColor = true;
            this.buttonPesquisarProduto.Click += new System.EventHandler(this.buttonPesquisarProduto_Click);
            // 
            // buttonApagarProduto
            // 
            this.buttonApagarProduto.Location = new System.Drawing.Point(519, 134);
            this.buttonApagarProduto.Name = "buttonApagarProduto";
            this.buttonApagarProduto.Size = new System.Drawing.Size(133, 48);
            this.buttonApagarProduto.TabIndex = 2;
            this.buttonApagarProduto.Text = "apagar produto";
            this.buttonApagarProduto.UseVisualStyleBackColor = true;
            this.buttonApagarProduto.Click += new System.EventHandler(this.buttonApagarProduto_Click);
            // 
            // gerenciarProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonApagarProduto);
            this.Controls.Add(this.buttonPesquisarProduto);
            this.Controls.Add(this.dgvProduto);
            this.Name = "gerenciarProd";
            this.Text = "gerenciarProd";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProduto;
        private System.Windows.Forms.Button buttonPesquisarProduto;
        private System.Windows.Forms.Button buttonApagarProduto;
    }
}