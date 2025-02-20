using MySql.Data.MySqlClient;
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

namespace DamajuCad
{
    public partial class CadCliente2 : Form
    {
        public CadCliente2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

           

            //Defina sua string de conexão com o banco
            string conexaoString = "Server=localhost; Port=3306; Database=damaju_bd; Uid=root; Pwd=;";

            //Defina a inserção de registro no BD

            string query = "INSERT INTO tb_cliente (Nome, Senha, Email, Cep, Cpf, Numero, Telefone, Imagem) VALUES (@Nome, @Senha, @Email, @Cep, @Cpf, @Numero, @Telefone, @Imagem)";

            //Crie uma conexão com o BD

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
                        comando.Parameters.AddWithValue("@Nome", textBoxNomeCompleto.Text);
                        comando.Parameters.AddWithValue("@Senha", textBoxSenha.Text);
                        comando.Parameters.AddWithValue("@Email", textBoxEmail.Text);
                        comando.Parameters.AddWithValue("@Cep", maskedTextBoxCEP.Text);
                        comando.Parameters.AddWithValue("@Cpf", maskedTextBoxCEP.Text);
                        comando.Parameters.AddWithValue("@Numero", maskedTextBoxNumero.Text);
                        comando.Parameters.AddWithValue("@Telefone", maskedTextBoxTelefone.Text);
                        comando.Parameters.AddWithValue("@Imagem", imageBytes);

                        // Executa o comando de inserção
                        comando.ExecuteNonQuery();

                        MessageBox.Show("Dados inseridos com sucesso!");
                        textBoxNomeCompleto.Text = "";
                        maskedTextBoxCPF.Text = "";
                        textBoxEmail.Text = "";
                        maskedTextBoxCEP.Text = "";
                        maskedTextBoxNumero.Text = "";
                        maskedTextBoxTelefone.Text = "";
                        labelAlert.Text = "";
                        textBoxNomeCompleto.Focus();
                    }
                }
                catch (Exception ex)
                {
                    // em caso de erro, exiba menssagem do erro
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

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
    }
}
