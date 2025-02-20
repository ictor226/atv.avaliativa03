namespace DamajuCad
{
    partial class CadLanche
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
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBoxValor = new System.Windows.Forms.MaskedTextBox();
            this.Cadastrar = new System.Windows.Forms.Button();
            this.img_produto = new System.Windows.Forms.PictureBox();
            this.escolha_foto = new System.Windows.Forms.Button();
            this.labelAlert = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.textBoxCategoria = new System.Windows.Forms.TextBox();
            this.TextBoxNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.img_produto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(286, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastrar lanches";
            // 
            // maskedTextBoxValor
            // 
            this.maskedTextBoxValor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maskedTextBoxValor.Location = new System.Drawing.Point(362, 211);
            this.maskedTextBoxValor.Mask = "$-000.00";
            this.maskedTextBoxValor.Name = "maskedTextBoxValor";
            this.maskedTextBoxValor.Size = new System.Drawing.Size(65, 20);
            this.maskedTextBoxValor.TabIndex = 2;
            // 
            // Cadastrar
            // 
            this.Cadastrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cadastrar.BackColor = System.Drawing.Color.Orange;
            this.Cadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cadastrar.Location = new System.Drawing.Point(236, 266);
            this.Cadastrar.Name = "Cadastrar";
            this.Cadastrar.Size = new System.Drawing.Size(115, 26);
            this.Cadastrar.TabIndex = 4;
            this.Cadastrar.Text = "Cadastrar";
            this.Cadastrar.UseVisualStyleBackColor = false;
            this.Cadastrar.Click += new System.EventHandler(this.Cadastrar_Click);
            // 
            // img_produto
            // 
            this.img_produto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.img_produto.BackColor = System.Drawing.Color.Transparent;
            this.img_produto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.img_produto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.img_produto.Location = new System.Drawing.Point(444, 120);
            this.img_produto.Name = "img_produto";
            this.img_produto.Size = new System.Drawing.Size(155, 140);
            this.img_produto.TabIndex = 5;
            this.img_produto.TabStop = false;
            this.img_produto.Click += new System.EventHandler(this.img_produto_Click);
            // 
            // escolha_foto
            // 
            this.escolha_foto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.escolha_foto.BackColor = System.Drawing.Color.Orange;
            this.escolha_foto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.escolha_foto.Location = new System.Drawing.Point(459, 266);
            this.escolha_foto.Name = "escolha_foto";
            this.escolha_foto.Size = new System.Drawing.Size(115, 26);
            this.escolha_foto.TabIndex = 6;
            this.escolha_foto.Text = "escolha foto";
            this.escolha_foto.UseVisualStyleBackColor = false;
            this.escolha_foto.Click += new System.EventHandler(this.escolha_foto_Click);
            // 
            // labelAlert
            // 
            this.labelAlert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAlert.AutoSize = true;
            this.labelAlert.BackColor = System.Drawing.Color.Transparent;
            this.labelAlert.Location = new System.Drawing.Point(288, 316);
            this.labelAlert.Name = "labelAlert";
            this.labelAlert.Size = new System.Drawing.Size(0, 13);
            this.labelAlert.TabIndex = 7;
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonVoltar.BackColor = System.Drawing.Color.Orange;
            this.buttonVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVoltar.Location = new System.Drawing.Point(236, 298);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(115, 26);
            this.buttonVoltar.TabIndex = 8;
            this.buttonVoltar.Text = "Voltar pra Menu";
            this.buttonVoltar.UseVisualStyleBackColor = false;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxDesc.Location = new System.Drawing.Point(236, 146);
            this.textBoxDesc.Multiline = true;
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.Size = new System.Drawing.Size(191, 59);
            this.textBoxDesc.TabIndex = 12;
            // 
            // textBoxCategoria
            // 
            this.textBoxCategoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxCategoria.Location = new System.Drawing.Point(236, 211);
            this.textBoxCategoria.Name = "textBoxCategoria";
            this.textBoxCategoria.Size = new System.Drawing.Size(115, 20);
            this.textBoxCategoria.TabIndex = 13;
            // 
            // TextBoxNome
            // 
            this.TextBoxNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextBoxNome.Location = new System.Drawing.Point(236, 120);
            this.TextBoxNome.Multiline = true;
            this.TextBoxNome.Name = "TextBoxNome";
            this.TextBoxNome.Size = new System.Drawing.Size(191, 20);
            this.TextBoxNome.TabIndex = 14;
            this.TextBoxNome.TextChanged += new System.EventHandler(this.TextBoxNome_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(195, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(175, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Descrição";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(178, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Categoria";
            // 
            // CadLanche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBoxNome);
            this.Controls.Add(this.textBoxCategoria);
            this.Controls.Add(this.textBoxDesc);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.labelAlert);
            this.Controls.Add(this.escolha_foto);
            this.Controls.Add(this.img_produto);
            this.Controls.Add(this.Cadastrar);
            this.Controls.Add(this.maskedTextBoxValor);
            this.Controls.Add(this.label1);
            this.Name = "CadLanche";
            this.Text = "CadLanche";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.img_produto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxValor;
        private System.Windows.Forms.Button Cadastrar;
        private System.Windows.Forms.PictureBox img_produto;
        private System.Windows.Forms.Button escolha_foto;
        private System.Windows.Forms.Label labelAlert;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button buttonVoltar;
        private System.Windows.Forms.TextBox textBoxDesc;
        private System.Windows.Forms.TextBox textBoxCategoria;
        private System.Windows.Forms.TextBox TextBoxNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}