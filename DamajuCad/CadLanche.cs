using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; // Adicionar para trabalhar com banco de dados

namespace DamajuCad
{
    public partial class CadLanche : Form
    {
        private MySqlConnection conexao; // Definindo a variável de conexão com o banco de dados

        public CadLanche()
        {
            InitializeComponent();
          
        }


        private void Cadastrar_Click(object sender, EventArgs e)
        {
            

            string conexaoString = "Server=localhost; Port=3306; Database=damaju_bd; Uid=root; Pwd=;";

            string query = "INSERT INTO tb_produtos (Nome, Valor, Descricao, Categoria, imagem) VALUES (@Nome, @Valor, @Descricao, @Categoria, @imagem)";


            using (MySqlConnection conexao = new MySqlConnection(conexaoString))
            {
                try
                {
                    MemoryStream ms = new MemoryStream();
                    img_produto.Image.Save(ms, img_produto.Image.RawFormat);
                    byte[] imageBytes = ms.ToArray();
                    conexao.Close();



                    //Abre a conexão
                    conexao.Open();
                    //Crie o comando SQL
                    using (MySqlCommand comando = new MySqlCommand(query, conexao))
                    {
                        //Adicionar os parâmentros com os valores dos TextBox
                        comando.Parameters.AddWithValue("@Nome", TextBoxNome.Text);
                        comando.Parameters.AddWithValue("@Valor", maskedTextBoxValor.Text);
                        comando.Parameters.AddWithValue("@Descricao", textBoxDesc.Text);
                        comando.Parameters.AddWithValue("@Categoria", textBoxCategoria.Text);
                        comando.Parameters.AddWithValue("@imagem", imageBytes);

                        // Executa o comando de inserção
                        comando.ExecuteNonQuery();

                        TextBoxNome.Text = "";
                        maskedTextBoxValor.Text = "";
                        textBoxDesc.Text = "";
                        textBoxCategoria.Text = "";
                        img_produto.Text = "";
                    }
                }
                catch (Exception ex)
                {
                    // em caso de erro, exiba menssagem do erro
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void escolha_foto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.gif;*.bmp";


            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                img_produto.Image = Image.FromFile(openFileDialog.FileName);

                img_produto.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void TextBoxNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void img_produto_Click(object sender, EventArgs e)
        {

        }
    }
}

